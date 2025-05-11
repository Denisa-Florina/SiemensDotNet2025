using System.ComponentModel;

namespace ProblemSiemensDonNet;

partial class AddBook
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
        TitleBox = new System.Windows.Forms.TextBox();
        AuthorBox = new System.Windows.Forms.TextBox();
        GenreBox = new System.Windows.Forms.TextBox();
        TitleLabel = new System.Windows.Forms.Label();
        AuthorLabel = new System.Windows.Forms.Label();
        GenreLabel = new System.Windows.Forms.Label();
        PublisherLabel = new System.Windows.Forms.Label();
        PublisherBox = new System.Windows.Forms.TextBox();
        PagesLabel = new System.Windows.Forms.Label();
        YearLabel = new System.Windows.Forms.Label();
        AddButton = new System.Windows.Forms.Button();
        PagesBox = new System.Windows.Forms.NumericUpDown();
        YearBox = new System.Windows.Forms.NumericUpDown();
        StockLabel = new System.Windows.Forms.Label();
        StockBox = new System.Windows.Forms.NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)PagesBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)YearBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)StockBox).BeginInit();
        SuspendLayout();
        // 
        // TitleBox
        // 
        TitleBox.Location = new System.Drawing.Point(173, 65);
        TitleBox.Name = "TitleBox";
        TitleBox.Size = new System.Drawing.Size(349, 27);
        TitleBox.TabIndex = 0;
        // 
        // AuthorBox
        // 
        AuthorBox.Location = new System.Drawing.Point(174, 141);
        AuthorBox.Name = "AuthorBox";
        AuthorBox.Size = new System.Drawing.Size(348, 27);
        AuthorBox.TabIndex = 1;
        // 
        // GenreBox
        // 
        GenreBox.Location = new System.Drawing.Point(173, 218);
        GenreBox.Name = "GenreBox";
        GenreBox.Size = new System.Drawing.Size(348, 27);
        GenreBox.TabIndex = 2;
        // 
        // TitleLabel
        // 
        TitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        TitleLabel.Location = new System.Drawing.Point(97, 65);
        TitleLabel.Name = "TitleLabel";
        TitleLabel.Size = new System.Drawing.Size(43, 23);
        TitleLabel.TabIndex = 3;
        TitleLabel.Text = "Title:";
        // 
        // AuthorLabel
        // 
        AuthorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        AuthorLabel.Location = new System.Drawing.Point(82, 141);
        AuthorLabel.Name = "AuthorLabel";
        AuthorLabel.Size = new System.Drawing.Size(58, 23);
        AuthorLabel.TabIndex = 4;
        AuthorLabel.Text = "Author:";
        // 
        // GenreLabel
        // 
        GenreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        GenreLabel.Location = new System.Drawing.Point(86, 218);
        GenreLabel.Name = "GenreLabel";
        GenreLabel.Size = new System.Drawing.Size(54, 23);
        GenreLabel.TabIndex = 5;
        GenreLabel.Text = "Genre:";
        // 
        // PublisherLabel
        // 
        PublisherLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        PublisherLabel.Location = new System.Drawing.Point(67, 302);
        PublisherLabel.Name = "PublisherLabel";
        PublisherLabel.Size = new System.Drawing.Size(83, 23);
        PublisherLabel.TabIndex = 6;
        PublisherLabel.Text = "Publisher:";
        // 
        // PublisherBox
        // 
        PublisherBox.Location = new System.Drawing.Point(173, 302);
        PublisherBox.Name = "PublisherBox";
        PublisherBox.Size = new System.Drawing.Size(349, 27);
        PublisherBox.TabIndex = 7;
        // 
        // PagesLabel
        // 
        PagesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        PagesLabel.Location = new System.Drawing.Point(86, 381);
        PagesLabel.Name = "PagesLabel";
        PagesLabel.Size = new System.Drawing.Size(54, 23);
        PagesLabel.TabIndex = 8;
        PagesLabel.Text = "Pages:";
        // 
        // YearLabel
        // 
        YearLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        YearLabel.Location = new System.Drawing.Point(19, 463);
        YearLabel.Name = "YearLabel";
        YearLabel.Size = new System.Drawing.Size(121, 24);
        YearLabel.TabIndex = 10;
        YearLabel.Text = "Publication Year:";
        // 
        // AddButton
        // 
        AddButton.BackColor = System.Drawing.Color.Linen;
        AddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        AddButton.Location = new System.Drawing.Point(223, 617);
        AddButton.Name = "AddButton";
        AddButton.Size = new System.Drawing.Size(121, 43);
        AddButton.TabIndex = 12;
        AddButton.Text = "Add";
        AddButton.UseVisualStyleBackColor = false;
        AddButton.Click += AddButton_Click;
        // 
        // PagesBox
        // 
        PagesBox.Location = new System.Drawing.Point(174, 377);
        PagesBox.Name = "PagesBox";
        PagesBox.Size = new System.Drawing.Size(348, 27);
        PagesBox.TabIndex = 13;
        // 
        // YearBox
        // 
        YearBox.Location = new System.Drawing.Point(173, 460);
        YearBox.Name = "YearBox";
        YearBox.Size = new System.Drawing.Size(348, 27);
        YearBox.TabIndex = 14;
        // 
        // StockLabel
        // 
        StockLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        StockLabel.Location = new System.Drawing.Point(86, 533);
        StockLabel.Name = "StockLabel";
        StockLabel.Size = new System.Drawing.Size(54, 35);
        StockLabel.TabIndex = 15;
        StockLabel.Text = "Stock:";
        // 
        // StockBox
        // 
        StockBox.Location = new System.Drawing.Point(173, 533);
        StockBox.Name = "StockBox";
        StockBox.Size = new System.Drawing.Size(349, 27);
        StockBox.TabIndex = 16;
        // 
        // AddBook
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Gray;
        ClientSize = new System.Drawing.Size(597, 708);
        Controls.Add(StockBox);
        Controls.Add(StockLabel);
        Controls.Add(YearBox);
        Controls.Add(PagesBox);
        Controls.Add(AddButton);
        Controls.Add(YearLabel);
        Controls.Add(PagesLabel);
        Controls.Add(PublisherBox);
        Controls.Add(PublisherLabel);
        Controls.Add(GenreLabel);
        Controls.Add(AuthorLabel);
        Controls.Add(TitleLabel);
        Controls.Add(GenreBox);
        Controls.Add(AuthorBox);
        Controls.Add(TitleBox);
        Text = "AddBook";
        ((System.ComponentModel.ISupportInitialize)PagesBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)YearBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)StockBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label StockLabel;
    private System.Windows.Forms.NumericUpDown StockBox;

    private System.Windows.Forms.NumericUpDown YearBox;

    private System.Windows.Forms.NumericUpDown PagesBox;

    private System.Windows.Forms.Label AuthorLabel;
    private System.Windows.Forms.Label GenreLabel;
    private System.Windows.Forms.Label PublisherLabel;
    private System.Windows.Forms.TextBox PublisherBox;
    private System.Windows.Forms.Label PagesLabel;
    private System.Windows.Forms.Label YearLabel;
    private System.Windows.Forms.Button AddButton;

    private System.Windows.Forms.TextBox TitleBox;
    private System.Windows.Forms.TextBox AuthorBox;
    private System.Windows.Forms.TextBox GenreBox;
    private System.Windows.Forms.Label TitleLabel;

    #endregion
}