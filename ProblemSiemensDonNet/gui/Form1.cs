using System.Configuration;
using LiveCharts.Wpf.Charts.Base;
using ProblemSiemensDonNet.domain;
using ProblemSiemensDonNet.service;

namespace ProblemSiemensDonNet;

public partial class Form1 : Form
{
    private Service service;
    private Charts charts;
    private int currentPage = 0;
    private int totalPages;
    private int rowsPerPage = 16;
    private bool filter = false;
    
    /// <summary>
    /// Initializes the main form with the provided service.
    /// Sets up event handlers, pagination, and initial data loading.
    /// </summary>
    /// <param name="service">Service instance used to interact with the application logic.</param>
    public Form1(Service service)
    {
        charts = new Charts(service);
        this.service = service;
        totalPages = service.TotalBooks() / rowsPerPage;
        InitializeComponent();
        
        this.BackgroundImage = Image.FromFile("utils/blur.jpg");
        InfoLabel.BackColor = Color.Transparent;
        SearchLabel.BackColor = Color.Transparent;
        AuthorRadioButton.BackColor = Color.Transparent;
        GenreRadioButton.BackColor = Color.Transparent;
        TitleRadioButton.BackColor = Color.Transparent;
        PublisherRadioButton.BackColor = Color.Transparent;
        PagesRadioButton.BackColor = Color.Transparent;
        YearRadioButton.BackColor = Color.Transparent;
        InfoLabel2.BackColor = Color.Transparent;
        PageLabel.BackColor = Color.Transparent;
        
        
        AuthorRadioButton.CheckedChanged += RadioButton_CheckedChanged;
        PagesRadioButton.CheckedChanged += RadioButton_CheckedChanged;
        GenreRadioButton.CheckedChanged += RadioButton_CheckedChanged;
        YearRadioButton.CheckedChanged += RadioButton_CheckedChanged;
        TitleRadioButton.CheckedChanged += RadioButton_CheckedChanged;
        PublisherRadioButton.CheckedChanged += RadioButton_CheckedChanged;
        
        
        NumberOfBooksBox.Maximum = 1000;
        NumberOfBooksBox.Minimum = 1;
        AuthorRadioButton.Checked = true;
        PageLabel.Text = (currentPage + 1).ToString() + "/" + totalPages.ToString();
        
        LoadBook();
        charts.Show();
    }

    /// <summary>
    /// Event handler triggered when a radio button is selected.
    /// Calls the Filter method to apply the selected filter.
    /// </summary>
    /// <param name="sender">The radio button that triggered the event.</param>
    /// <param name="e">Event data.</param>
    private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
        Filter();
    }
    
    
    /// <summary>
    /// Loads the books to display on the current page.
    /// If a filter is applied, it filters the data accordingly.
    /// </summary>
    private void LoadBook()
    {
        int offset = currentPage * rowsPerPage;
        if (filter == false)
        {
            totalPages = (int)Math.Ceiling(service.TotalBooks() / (double)rowsPerPage);
            var books = service.GetBooksPaged(offset, rowsPerPage);
            PageLabel.Text = (currentPage + 1).ToString() + "/" + totalPages.ToString();
            dataGridView1.DataSource = books;
            dataGridView1.Columns["Id"].Visible = false;
        }
        else
        {
            Filter();
        }
    }
    
    /// <summary>
    /// Opens the AddBook form to add a new book.
    /// Updates the charts and book list after the book is added.
    /// </summary>
    /// <param name="sender">The Add button.</param>
    /// <param name="e">Event data.</param>
    private void AddButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new AddBook(service).ShowDialog();
        charts.UpdateCharts();
        LoadBook();
        this.Show();
    }

    /// <summary>
    /// Deletes the selected book after confirmation.
    /// Updates the chart and book list.
    /// </summary>
    /// <param name="sender">The Delete button.</param>
    /// <param name="e">Event data.</param>
    private void DeleteButton_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            var result = MessageBox.Show($"Are you sure you want to delete the book ?", 
                "Confirm Delete", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes)
            {
                service.DeleteBook(id);
                LoadBook();
                charts.UpdateCharts();
            }
        }
        else
        {
            MessageBox.Show("Please select a book to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
    
    // <summary>
    /// Borrows a specified number of copies of the selected book.
    /// </summary>
    /// <param name="sender">The Borrow button.</param>
    /// <param name="e">Event data.</param>
    private void BorrowButton_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            int numberOfBooks = (int)NumberOfBooksBox.Value;

            if (numberOfBooks >= 1)
            {
                try
                {
                    service.BorrowBook(id, numberOfBooks, "Borrow");
                }catch(Exception ex){
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadBook();
            }
        }
        else
        {
            MessageBox.Show("Please select a book to borrow.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    /// <summary>
    /// Returns a specified number of copies of the selected book.
    /// </summary>
    /// <param name="sender">The Return button.</param>
    /// <param name="e">Event data.</param>
    private void ReturnButton_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            int numberOfBooks = (int)NumberOfBooksBox.Value;

            if (numberOfBooks >= 1)
            {
                try
                {
                    service.BorrowBook(id, numberOfBooks, "Return");
                }catch(Exception ex){
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadBook();
            }
        }
        else
        {
            MessageBox.Show("Please select a book to return.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    /// <summary>
    /// Applies the selected filter on the book list based on the input text and category.
    /// </summary>
    private void Filter()
    {
        string value = SearchTextBox.Text.Trim();
        string column = "";
        
        if (string.IsNullOrWhiteSpace(value))
        {
            filter = false;
            LoadBook();
            return;
        }

        if (AuthorRadioButton.Checked)
            column = "Author";
        else if (TitleRadioButton.Checked)
            column = "Title";
        else if (GenreRadioButton.Checked)
            column = "Genre";
        else if (PublisherRadioButton.Checked)
            column = "Publisher";
        else if (PagesRadioButton.Checked)
            column = "Pages";
        else if (YearRadioButton.Checked)
            column = "Year";
        else
        {
            MessageBox.Show("Please select a filter category.", "No Filter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        
        if (PagesRadioButton.Checked || YearRadioButton.Checked)
        {
            if (!int.TryParse(value, out _))
            {
                SearchTextBox.Text = "";
                return;
            }
        }

        filter = true;
        int offset = currentPage * rowsPerPage;
        var filteredBooks = service.FilterBy(column, value, offset, rowsPerPage);
        totalPages = (int)Math.Ceiling(service.TotalFilteredPages(column, value) / (double)rowsPerPage);
        PageLabel.Text = (currentPage + 1).ToString() + "/" + totalPages.ToString();
        dataGridView1.DataSource = filteredBooks;
    }

    /// <summary>
    /// Triggers filtering when the search box text changes.
    /// </summary>
    /// <param name="sender">The search textbox.</param>
    /// <param name="e">Event data.</param>
    private void SearchTextBox_TextChanged(object sender, EventArgs e)
    {
        currentPage = 0;
        Filter();
    }

    /// <summary>
    /// Opens the ModifyBook form for editing the selected book's details.
    /// </summary>
    /// <param name="sender">The Modify button.</param>
    /// <param name="e">Event data.</param>
    private void ModifyButton_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            string author = Convert.ToString(selectedRow.Cells["Author"].Value);
            string title = Convert.ToString(selectedRow.Cells["Title"].Value);
            string genre = Convert.ToString(selectedRow.Cells["Genre"].Value);
            string publisher = Convert.ToString(selectedRow.Cells["Publisher"].Value);
            int pages = Convert.ToInt32(selectedRow.Cells["Pages"].Value);
            int year = Convert.ToInt32(selectedRow.Cells["Year"].Value);
            int stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value);
            
            Book book = new Book(id, author, title, genre, publisher, pages, year, stock);
            
            this.Hide();
            new ModifyBook(service, book).ShowDialog();
            LoadBook();
            charts.UpdateCharts();
            this.Show();
        }
    }

    /// <summary>
    /// Navigates to the previous page of the paginated book list.
    /// </summary>
    /// <param name="sender">The Previous Page button.</param>
    /// <param name="e">Event data.</param>
    private void PrevButton_Click(object sender, EventArgs e)
    {
        currentPage -= 1;
        if (currentPage == -1)
        {
            currentPage = totalPages-1 ;
        }
        PageLabel.Text = (currentPage + 1).ToString() + "/" + totalPages.ToString();
        LoadBook();
    }
    
    /// <summary>
    /// Navigates to the next page of the paginated book list.
    /// </summary>
    /// <param name="sender">The Next Page button.</param>
    /// <param name="e">Event data.</param>
    private void NextButton_Click(object sender, EventArgs e)
    {
        currentPage += 1;
        if (currentPage >= totalPages)
        {
            currentPage = 0;
        }
        PageLabel.Text = (currentPage + 1).ToString() + "/" + totalPages.ToString();
        LoadBook();
    }
}