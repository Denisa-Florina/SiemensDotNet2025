using System.ComponentModel;

namespace ProblemSiemensDonNet;

partial class Charts
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        AuthorButton = new System.Windows.Forms.RadioButton();
        PagesButton = new System.Windows.Forms.RadioButton();
        GenreButton = new System.Windows.Forms.RadioButton();
        YearButton = new System.Windows.Forms.RadioButton();
        StockButton = new System.Windows.Forms.RadioButton();
        ExportButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
        SuspendLayout();
        // 
        // chart
        // 
        chartArea1.Name = "ChartArea1";
        chart.ChartAreas.Add(chartArea1);
        legend1.Name = "Legend1";
        chart.Legends.Add(legend1);
        chart.Location = new System.Drawing.Point(14, 17);
        chart.Name = "chart";
        chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
        series1.ChartArea = "ChartArea1";
        series1.Legend = "Legend1";
        series1.Name = "Series1";
        chart.Series.Add(series1);
        chart.Size = new System.Drawing.Size(799, 594);
        chart.TabIndex = 0;
        chart.Text = "chart";
        // 
        // AuthorButton
        // 
        AuthorButton.Location = new System.Drawing.Point(860, 232);
        AuthorButton.Name = "AuthorButton";
        AuthorButton.Size = new System.Drawing.Size(75, 52);
        AuthorButton.TabIndex = 2;
        AuthorButton.TabStop = true;
        AuthorButton.Text = "Author";
        AuthorButton.UseVisualStyleBackColor = true;
        // 
        // PagesButton
        // 
        PagesButton.Location = new System.Drawing.Point(860, 299);
        PagesButton.Name = "PagesButton";
        PagesButton.Size = new System.Drawing.Size(75, 47);
        PagesButton.TabIndex = 3;
        PagesButton.TabStop = true;
        PagesButton.Text = "Pages";
        PagesButton.UseVisualStyleBackColor = true;
        // 
        // GenreButton
        // 
        GenreButton.Location = new System.Drawing.Point(860, 171);
        GenreButton.Name = "GenreButton";
        GenreButton.Size = new System.Drawing.Size(82, 46);
        GenreButton.TabIndex = 4;
        GenreButton.TabStop = true;
        GenreButton.Text = "Genre";
        GenreButton.UseVisualStyleBackColor = true;
        // 
        // YearButton
        // 
        YearButton.Location = new System.Drawing.Point(860, 365);
        YearButton.Name = "YearButton";
        YearButton.Size = new System.Drawing.Size(82, 47);
        YearButton.TabIndex = 5;
        YearButton.TabStop = true;
        YearButton.Text = "Year";
        YearButton.UseVisualStyleBackColor = true;
        // 
        // StockButton
        // 
        StockButton.Location = new System.Drawing.Point(860, 427);
        StockButton.Name = "StockButton";
        StockButton.Size = new System.Drawing.Size(75, 43);
        StockButton.TabIndex = 6;
        StockButton.TabStop = true;
        StockButton.Text = "Stock";
        StockButton.UseVisualStyleBackColor = true;
        // 
        // ExportButton
        // 
        ExportButton.Location = new System.Drawing.Point(849, 510);
        ExportButton.Name = "ExportButton";
        ExportButton.Size = new System.Drawing.Size(85, 44);
        ExportButton.TabIndex = 7;
        ExportButton.Text = "Export";
        ExportButton.UseVisualStyleBackColor = true;
        ExportButton.Click += ExportButton_Click;
        // 
        // Charts
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(965, 641);
        Controls.Add(ExportButton);
        Controls.Add(StockButton);
        Controls.Add(YearButton);
        Controls.Add(GenreButton);
        Controls.Add(PagesButton);
        Controls.Add(AuthorButton);
        Controls.Add(chart);
        Text = "Charts";
        ((System.ComponentModel.ISupportInitialize)chart).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button ExportButton;

    private System.Windows.Forms.RadioButton PagesButton;
    private System.Windows.Forms.RadioButton AuthorButton;
    private System.Windows.Forms.RadioButton GenreButton;
    private System.Windows.Forms.RadioButton YearButton;
    private System.Windows.Forms.RadioButton StockButton;

    private System.Windows.Forms.DataVisualization.Charting.Chart chart;

    #endregion
}