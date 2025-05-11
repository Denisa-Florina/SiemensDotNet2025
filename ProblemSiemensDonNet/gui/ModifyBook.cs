using ProblemSiemensDonNet.domain;
using ProblemSiemensDonNet.service;

namespace ProblemSiemensDonNet;

public partial class ModifyBook : Form
{
    private readonly Service _service;
    private readonly Book _selectedBook;
    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="service">The service used to update the book in the database.</param>
    /// <param name="book">The book to be modified.</param>
    public ModifyBook(Service service, Book book)
    {
        _selectedBook = book;
        this._service = service;
        InitializeComponent();
        
        TitleLabel.BackColor = Color.Transparent;
        AuthorLabel.BackColor = Color.Transparent;
        PublisherLabel.BackColor = Color.Transparent;
        PagesLabel.BackColor = Color.Transparent;
        YearLabel.BackColor = Color.Transparent;
        GenreLabel.BackColor = Color.Transparent;
        StockLabel.BackColor = Color.Transparent;
        
        BackgroundImage = Image.FromFile("utils/blur.jpg");
        YearBox.Maximum = DateTime.Now.Year;
        StockBox.Maximum = 100000;

        LoadFields();
    }

    /// <summary>
    /// Loads the current book details into the form fields.
    /// </summary>
    private void LoadFields()
    {
        TitleBox.Text = _selectedBook.Title;
        AuthorBox.Text = _selectedBook.Author;
        GenreBox.Text = _selectedBook.Genre;
        PublisherBox.Text = _selectedBook.Publisher;
        PagesBox.Text = _selectedBook.Pages.ToString();
        YearBox.Text = _selectedBook.Year.ToString();
        StockBox.Text = _selectedBook.Stock.ToString();
        
    }

    /// <summary>
    /// Handles the click event for the "Change" button.
    /// Validates the input and updates the book if valid.
    /// </summary>
    /// <param name="sender">The control that triggered the event.</param>
    /// <param name="e">The event arguments.</param>
    private void ChangeButton_Click(object sender, EventArgs e)
    {
        string title = TitleBox.Text;
        string author = AuthorBox.Text;
        string genre = GenreBox.Text;
        string publisher = PublisherBox.Text;
        int pages = (int)PagesBox.Value;
        int year = (int)YearBox.Value; 
        int stock = (int)StockBox.Value; 

        if (title != "" && author != "" && genre != "" && publisher != "" && pages > 0 && year > 1200 && year <= DateTime.Now.Year && stock > 0)
        {
            _service.UpdateBook(new Book(_selectedBook.Id, author, title, genre, publisher, pages, year, stock));
            this.Close();
        }
        else
        {
            MessageBox.Show("Please fill in all the required fields correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}