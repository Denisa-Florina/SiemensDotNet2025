using System.Data.SQLite;
using ProblemSiemensDonNet.domain;
using ProblemSiemensDonNet.repository.dbUtils;

namespace ProblemSiemensDonNet.repository
{
    public class BookRepository
    {
        /// <summary>
        /// Retrieves a paginated list of books from the database.
        /// </summary>
        /// <param name="offset">The number of rows to skip before starting to return rows.</param>
        /// <param name="limit">The maximum number of books to return.</param>
        /// <returns>A list of books within the specified range.</returns>
        public List<Book> FindAll(int offset, int limit)
        {
            var books = new List<Book>();
            var conn = Connection.GetConnection();
            string query = "SELECT * FROM Books LIMIT @limit OFFSET @offset";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@limit", limit);
            cmd.Parameters.AddWithValue("@offset", offset);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                books.Add(new Book(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetInt32(5),
                    reader.GetInt32(6),
                    reader.GetInt32(7))
                {
                    Borrow = reader.GetInt32(8)
                });
            }

            return books;
        }

        /// <summary>
        /// Retrieves all books from the database.
        /// </summary>
        /// <returns>A list containing all books.</returns>
        public List<Book> FindAll()
        {
            var books = new List<Book>();
            var conn = Connection.GetConnection();
            string query = "SELECT * FROM Books";
            using var cmd = new SQLiteCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                books.Add(new Book(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetInt32(5),
                    reader.GetInt32(6),
                    reader.GetInt32(7))
                {
                    Borrow = reader.GetInt32(8)
                });
            }

            return books;
        }

        /// <summary>
        /// Saves a new book to the database.
        /// </summary>
        /// <param name="book">The book to be inserted.</param>
        public void Save(Book book)
        {
            var conn = Connection.GetConnection();
            string query = @"INSERT INTO Books (Author, Title, Genre, Publisher, Pages, Year, Stock, Borrow)
                             VALUES (@Author, @Title, @Genre, @Publisher, @Pages, @Year, @Stock, @Borrow)";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Author", book.Author);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Genre", book.Genre);
            cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
            cmd.Parameters.AddWithValue("@Pages", book.Pages);
            cmd.Parameters.AddWithValue("@Year", book.Year);
            cmd.Parameters.AddWithValue("@Stock", book.Stock);
            cmd.Parameters.AddWithValue("@Borrow", book.Borrow);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Deletes a book from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the book to be deleted.</param>
        public void Delete(int id)
        {
            var conn = Connection.GetConnection();
            string query = "DELETE FROM Books WHERE Id = @Id";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates an existing book's details in the database.
        /// </summary>
        /// <param name="book">The book with updated information.</param>
        public void Update(Book book)
        {
            var conn = Connection.GetConnection();
            string query = "UPDATE Books SET Author = @Author, Title = @Title, Genre = @Genre, Publisher = @Publisher, Pages = @Pages, Year = @Year, Stock = @Stock WHERE Id = @Id";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Author", book.Author);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Genre", book.Genre);
            cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
            cmd.Parameters.AddWithValue("@Pages", book.Pages);
            cmd.Parameters.AddWithValue("@Year", book.Year);
            cmd.Parameters.AddWithValue("@Stock", book.Stock);
            cmd.Parameters.AddWithValue("@Id", book.Id);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates the number of borrowed copies for a specific book.
        /// </summary>
        /// <param name="id">The ID of the book.</param>
        /// <param name="newBorrow">The new borrow count.</param>
        public void UpdateBorrow(int id, int newBorrow)
        {
            var conn = Connection.GetConnection();
            string query = "UPDATE Books SET Borrow = @Borrow WHERE Id = @Id";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Borrow", newBorrow);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Returns the total number of books in the database.
        /// </summary>
        /// <returns>The total count of books.</returns>
        public int TotalPages()
        {
            var conn = Connection.GetConnection();
            string query = $"SELECT COUNT(*) FROM Books";
            using var cmd = new SQLiteCommand(query, conn);
            var res = cmd.ExecuteScalar();
            return Convert.ToInt32(res);
        }

        /// <summary>
        /// Returns the total number of books that match a specific filter.
        /// </summary>
        /// <param name="column">The column to filter by (e.g., "Author").</param>
        /// <param name="value">The value to match in the specified column.</param>
        /// <returns>The number of filtered results.</returns>
        public int TotalFilteredPages(string column, string value)
        {
            var conn = Connection.GetConnection();
            string query = $"SELECT COUNT(*) FROM Books WHERE {column} LIKE @value";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@value", $"%{value}%");
            var res = cmd.ExecuteScalar();
            return Convert.ToInt32(res);
        }

        /// <summary>
        /// Retrieves a filtered and paginated list of books from the database.
        /// </summary>
        /// <param name="column">The column to filter by (e.g., "Title").</param>
        /// <param name="value">The value to search for in the specified column.</param>
        /// <param name="offset">The number of rows to skip.</param>
        /// <param name="limit">The maximum number of books to return.</param>
        /// <returns>A list of filtered books.</returns>
        public List<Book> FilterBy(string column, string value, int offset, int limit)
        {
            var books = new List<Book>();
            var conn = Connection.GetConnection();
            string query = $"SELECT * FROM Books WHERE {column} LIKE @value LIMIT @limit OFFSET @offset";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@value", $"%{value}%");
            cmd.Parameters.AddWithValue("@limit", limit);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                books.Add(new Book(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetInt32(5),
                    reader.GetInt32(6),
                    reader.GetInt32(7))
                {
                    Borrow = reader.GetInt32(8)
                });
            }

            return books;
        }
    }
}
