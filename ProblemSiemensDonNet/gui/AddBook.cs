using ProblemSiemensDonNet.domain;
using ProblemSiemensDonNet.service;

namespace ProblemSiemensDonNet;

public partial class AddBook : Form
{
    private Service service;
    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="service">The service used to add a new book to the system.</param>
    public AddBook(Service service)
    {
        this.service = service;
        InitializeComponent();
        
        TitleLabel.BackColor = Color.Transparent;
        AuthorLabel.BackColor = Color.Transparent;
        PublisherLabel.BackColor = Color.Transparent;
        PagesLabel.BackColor = Color.Transparent;
        YearLabel.BackColor = Color.Transparent;
        GenreLabel.BackColor = Color.Transparent;
        StockLabel.BackColor = Color.Transparent;
        
        this.BackgroundImage = Image.FromFile("utils/blur.jpg");
        YearBox.Maximum = DateTime.Now.Year;
        StockBox.Maximum = 100000;
    }

    /// <summary>
    /// Handles the Add button click event. Validates input fields and adds a new book using the provided service.
    /// </summary>
    /// <param name="sender">The control that triggered the event.</param>
    /// <param name="e">The event data.</param>
    private void AddButton_Click(object sender, EventArgs e)
    {
        string Title = TitleBox.Text;
        string Author = AuthorBox.Text;
        string Genre = GenreBox.Text;
        string Publisher = PublisherBox.Text;
        int Pages = (int)PagesBox.Value;
        int Year = (int)YearBox.Value;
        int Stock = (int)StockBox.Value;

        if (Title != "" && Author != "" && Genre != "" && Publisher != "" && Pages > 0 && Year > 1200 && Year <= DateTime.Now.Year && Stock > 0)
        {
            service.AddBook(new Book(0, Author, Title, Genre, Publisher, Pages, Year, Stock));
            this.Close();
        }
        else
        {
            MessageBox.Show("Please fill in all the required fields correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}