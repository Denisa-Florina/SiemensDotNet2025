
using System.Text;
using ProblemSiemensDonNet.service;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProblemSiemensDonNet;

public partial class Charts : Form
{
    private Service service;
    private string type;
    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="service">The service used to retrieve book data.</param>
    public Charts(Service service)
    {
        this.service = service;
        InitializeComponent();
        AuthorButton.CheckedChanged += RadioButton_CheckedChanged;
        PagesButton.CheckedChanged += RadioButton_CheckedChanged;
        GenreButton.CheckedChanged += RadioButton_CheckedChanged;
        YearButton.CheckedChanged += RadioButton_CheckedChanged;
        StockButton.CheckedChanged += RadioButton_CheckedChanged;

        GenreButton.Checked = true;
        type = "Genre";
        LoadCharts("Genre");
    }

    /// <summary>
    /// Handles the CheckedChanged event for the radio buttons.
    /// Updates the chart based on the selected grouping type.
    /// </summary>
    /// <param name="sender">The radio button that triggered the event.</param>
    /// <param name="e">The event data.</param>
    private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
        if (((RadioButton)sender).Checked)
        {
            string selected = ((RadioButton)sender).Text;
            type = selected;
            LoadCharts(selected);
        }
    }

    /// <summary>
    /// Refreshes the chart using the last selected grouping type.
    /// </summary>
    public void UpdateCharts()
    {
        LoadCharts(type);
    }

    /// <summary>
    /// Loads the chart data grouped by the specified property (e.g., Genre, Author, etc.).
    /// </summary>
    /// <param name="groupBy">The property name to group the books by (e.g., "Genre", "Author").</param>
    private void LoadCharts(string groupBy)
    {
        var books = service.GetBooks();

        var grouped = books
            .GroupBy(book =>
            {
                return groupBy switch
                {
                    "Author" => book.Author,
                    "Pages" => book.Pages.ToString(),
                    "Genre" => book.Genre,
                    "Year" => book.Year.ToString(),
                    "Stock" => book.Stock.ToString(),
                    _ => book.Genre
                };
            })
            .Select(g => new { Label = g.Key, Count = g.Count() })
            .ToList();

        chart.Series.Clear();
        chart.Titles.Clear();

        Series series = new Series
        {
            ChartType = SeriesChartType.Pie,
            IsValueShownAsLabel = true,
            LabelForeColor = Color.DarkRed,
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };

        foreach (var item in grouped)
        {
            series.Points.AddXY(item.Label, item.Count);
        }

        chart.Series.Add(series);
        chart.Titles.Add($"Books grouped by {groupBy}");
    }

    /// <summary>
    /// Handles the click event of the Export button and opens a Save File Dialog for exporting chart data.
    /// </summary>
    /// <param name="sender">The button that triggered the event.</param>
    /// <param name="e">The event data.</param>
    private void ExportButton_Click(object sender, EventArgs e)
    {
        using (var dialog = new SaveFileDialog())
        {
            dialog.Filter = "CSV Files (*.csv)|*.csv";
            dialog.Title = "Save Chart Data";
            dialog.FileName = $"books_by_{type.ToLower()}.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ExportChartDataToCsv(dialog.FileName);
            }
        }
    }
    
    /// <summary>
    /// Exports the current chart data to a CSV file at the specified file path.
    /// </summary>
    /// <param name="filePath">The destination path where the CSV file will be saved.</param>
    public void ExportChartDataToCsv(string filePath)
    {
        if (chart.Series.Count == 0 || chart.Series[0].Points.Count == 0)
        {
            MessageBox.Show("The chart contains no data to export.", "Export CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                writer.WriteLine("Category,Book Count");

                foreach (var point in chart.Series[0].Points)
                {
                    string label = point.AxisLabel ?? point.Label;
                    if (string.IsNullOrEmpty(label))
                        label = "Unknown";

                    writer.WriteLine($"\"{label}\",{point.YValues[0]}");
                }
            }

            MessageBox.Show("CSV export completed successfully.", "Export CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Export error: {ex.Message}", "Export CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}