namespace ProblemSiemensDonNet.domain;

public class Book
{
    public int Id { get; set; }
    public string Author {get; set;}
    public string Title {get; set;}
    public string Genre  {get; set;}
    public string Publisher  {get; set;}
    public int Pages  {get; set;}
    public int Year  {get; set;}
    public int Stock  {get; set;}
    public int Borrow {get; set;}
    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="Author"></param>
    /// <param name="Title"></param>
    /// <param name="Genre"></param>
    /// <param name="Publisher"></param>
    /// <param name="Pages"></param>
    /// <param name="Year"></param>
    /// <param name="Stock"></param>
    public Book(int Id, string Author, string Title, string Genre, string Publisher, int Pages, int Year, int Stock)
    {
       this.Id = Id;
       this.Author = Author;
       this.Title = Title;
       this.Genre = Genre;
       this.Publisher = Publisher;
       this.Pages = Pages;
       this.Year = Year;
       this.Stock = Stock;
       Borrow = 0;
    }
    
}