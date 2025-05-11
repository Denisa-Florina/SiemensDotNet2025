using ProblemSiemensDonNet.domain;
using ProblemSiemensDonNet.repository;

namespace ProblemSiemensDonNet.service;

public class Service
{
    private BookRepository Repository;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="repository">The book repository instance used for data operations.</param>
    public Service(BookRepository repository)
    {
        Repository = repository;
    }

    /// <summary>
    /// Calculates the total number of pages based on a filter applied to a specific column and value.
    /// </summary>
    /// <param name="column">The column to filter by.</param>
    /// <param name="value">The value to filter with.</param>
    /// <returns>Total number of filtered pages.</returns>
    public int TotalFilteredPages(string column, string value)
    {
        return Repository.TotalFilteredPages(column, value);
    }

    /// <summary>
    /// Filters books based on a column and value, with pagination.
    /// </summary>
    /// <param name="column">The column to filter by.</param>
    /// <param name="value">The filter value.</param>
    /// <param name="offset">The starting point in the list.</param>
    /// <param name="limit">The number of books to retrieve.</param>
    /// <returns>A list of filtered books.</returns>
    public List<Book> FilterBy(string column, string value, int offset, int limit)
    {
        return Repository.FilterBy(column, value, offset, limit);
    }

    /// <summary>
    /// Adds a new book to the repository.
    /// </summary>
    /// <param name="book">The book to be added.</param>
    public void AddBook(Book book)
    {
        Repository.Save(book);
    }

    /// <summary>
    /// Retrieves all books from the repository.
    /// </summary>
    /// <returns>A list of all books.</returns>
    public List<Book> GetBooks()
    {
        return Repository.FindAll();
    }

    /// <summary>
    /// Deletes a book with the specified ID from the repository.
    /// </summary>
    /// <param name="id">The ID of the book to delete.</param>
    public void DeleteBook(int id)
    {
        Repository.Delete(id);
    }

    /// <summary>
    /// Updates the details of an existing book.
    /// </summary>
    /// <param name="book">The book with updated information.</param>
    public void UpdateBook(Book book)
    {
        Repository.Update(book);
    }

    /// <summary>
    /// Retrieves a paginated list of books.
    /// </summary>
    /// <param name="offset">The starting index.</param>
    /// <param name="rowsPerPage">The number of books per page.</param>
    /// <returns>A list of books for the given page.</returns>
    public List<Book> GetBooksPaged(int offset, int rowsPerPage)
    {
        return Repository.FindAll(offset, rowsPerPage);
    }

    /// <summary>
    /// Gets the total number of pages based on all books.
    /// </summary>
    /// <returns>Total number of book pages.</returns>
    public int TotalBooks()
    {
        return Repository.TotalPages();
    }

    /// <summary>
    /// Handles borrowing or returning books based on the provided type.
    /// </summary>
    /// <param name="id">The ID of the book to borrow or return.</param>
    /// <param name="numberOfBooks">The number of books to borrow or return.</param>
    /// <param name="type">The type of operation: "Borrow" or "Return".</param>
    /// <exception cref="Exception">Thrown when trying to borrow more books than are in stock or return more than borrowed.</exception>
    public void BorrowBook(int id, int numberOfBooks, string type)
    {
        List<Book> books = GetBooks();
        
        foreach (Book book in books){
            if (book.Id == id)
            {
                int stock = book.Stock;
                int borrow = book.Borrow;

                if (type == "Return")
                {
                    if (borrow - numberOfBooks < 0)
                    {
                        Repository.UpdateBorrow(id, 0);
                        throw new Exception("Too many books to return. I'll take only " + borrow + " .");
                    }
                    Repository.UpdateBorrow(id, borrow - numberOfBooks);
                }
                else if (type == "Borrow")
                {
                    if (borrow + numberOfBooks > stock)
                    {
                        Repository.UpdateBorrow(id, stock);
                        int res = stock - borrow;
                        throw new Exception("Too many books to borrow. I'll give you only " + res + " .");
                    }
                    Repository.UpdateBorrow(id, borrow + numberOfBooks);
                    
                }
            }
        }
    }

}