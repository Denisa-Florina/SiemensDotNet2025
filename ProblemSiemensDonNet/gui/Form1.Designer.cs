namespace ProblemSiemensDonNet;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        SearchTextBox = new System.Windows.Forms.TextBox();
        SearchLabel = new System.Windows.Forms.Label();
        AuthorRadioButton = new System.Windows.Forms.RadioButton();
        TitleRadioButton = new System.Windows.Forms.RadioButton();
        GenreRadioButton = new System.Windows.Forms.RadioButton();
        AddButton = new System.Windows.Forms.Button();
        BorrowButton = new System.Windows.Forms.Button();
        DeleteButton = new System.Windows.Forms.Button();
        InfoLabel = new System.Windows.Forms.Label();
        PublisherRadioButton = new System.Windows.Forms.RadioButton();
        YearRadioButton = new System.Windows.Forms.RadioButton();
        PagesRadioButton = new System.Windows.Forms.RadioButton();
        ReturnButton = new System.Windows.Forms.Button();
        InfoLabel2 = new System.Windows.Forms.Label();
        NumberOfBooksBox = new System.Windows.Forms.NumericUpDown();
        ModifyButton = new System.Windows.Forms.Button();
        NextButton = new System.Windows.Forms.Button();
        PrevButton = new System.Windows.Forms.Button();
        PageLabel = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NumberOfBooksBox).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new System.Drawing.Point(10, 28);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new System.Drawing.Size(987, 515);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // SearchTextBox
        // 
        SearchTextBox.Location = new System.Drawing.Point(1018, 59);
        SearchTextBox.Name = "SearchTextBox";
        SearchTextBox.Size = new System.Drawing.Size(404, 27);
        SearchTextBox.TabIndex = 1;
        SearchTextBox.TextChanged += SearchTextBox_TextChanged;
        // 
        // SearchLabel
        // 
        SearchLabel.BackColor = System.Drawing.Color.Linen;
        SearchLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        SearchLabel.Location = new System.Drawing.Point(1018, 28);
        SearchLabel.Name = "SearchLabel";
        SearchLabel.Size = new System.Drawing.Size(104, 28);
        SearchLabel.TabIndex = 2;
        SearchLabel.Text = "Search:";
        // 
        // AuthorRadioButton
        // 
        AuthorRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        AuthorRadioButton.Location = new System.Drawing.Point(1018, 101);
        AuthorRadioButton.Name = "AuthorRadioButton";
        AuthorRadioButton.Size = new System.Drawing.Size(104, 38);
        AuthorRadioButton.TabIndex = 3;
        AuthorRadioButton.TabStop = true;
        AuthorRadioButton.Text = "Author";
        AuthorRadioButton.UseVisualStyleBackColor = true;
        // 
        // TitleRadioButton
        // 
        TitleRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        TitleRadioButton.Location = new System.Drawing.Point(1173, 101);
        TitleRadioButton.Name = "TitleRadioButton";
        TitleRadioButton.Size = new System.Drawing.Size(108, 38);
        TitleRadioButton.TabIndex = 4;
        TitleRadioButton.TabStop = true;
        TitleRadioButton.Text = "Title";
        TitleRadioButton.UseVisualStyleBackColor = true;
        // 
        // GenreRadioButton
        // 
        GenreRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        GenreRadioButton.Location = new System.Drawing.Point(1318, 101);
        GenreRadioButton.Name = "GenreRadioButton";
        GenreRadioButton.Size = new System.Drawing.Size(104, 38);
        GenreRadioButton.TabIndex = 5;
        GenreRadioButton.TabStop = true;
        GenreRadioButton.Text = "Genre";
        GenreRadioButton.UseVisualStyleBackColor = true;
        // 
        // AddButton
        // 
        AddButton.BackColor = System.Drawing.Color.Linen;
        AddButton.Location = new System.Drawing.Point(1031, 499);
        AddButton.Name = "AddButton";
        AddButton.Size = new System.Drawing.Size(116, 44);
        AddButton.TabIndex = 7;
        AddButton.Text = "Add";
        AddButton.UseVisualStyleBackColor = false;
        AddButton.Click += AddButton_Click;
        // 
        // BorrowButton
        // 
        BorrowButton.BackColor = System.Drawing.Color.Linen;
        BorrowButton.Location = new System.Drawing.Point(1031, 445);
        BorrowButton.Name = "BorrowButton";
        BorrowButton.Size = new System.Drawing.Size(190, 44);
        BorrowButton.TabIndex = 8;
        BorrowButton.Text = "Borrow";
        BorrowButton.UseVisualStyleBackColor = false;
        BorrowButton.Click += BorrowButton_Click;
        // 
        // DeleteButton
        // 
        DeleteButton.BackColor = System.Drawing.Color.Linen;
        DeleteButton.Location = new System.Drawing.Point(1173, 499);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new System.Drawing.Size(116, 44);
        DeleteButton.TabIndex = 9;
        DeleteButton.Text = "Delete";
        DeleteButton.UseVisualStyleBackColor = false;
        DeleteButton.Click += DeleteButton_Click;
        // 
        // InfoLabel
        // 
        InfoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        InfoLabel.Location = new System.Drawing.Point(1018, 558);
        InfoLabel.Name = "InfoLabel";
        InfoLabel.Size = new System.Drawing.Size(431, 31);
        InfoLabel.TabIndex = 10;
        InfoLabel.Text = "Select a book from the list to borrow, delete, return or modify.";
        // 
        // PublisherRadioButton
        // 
        PublisherRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        PublisherRadioButton.Location = new System.Drawing.Point(1018, 160);
        PublisherRadioButton.Name = "PublisherRadioButton";
        PublisherRadioButton.Size = new System.Drawing.Size(104, 44);
        PublisherRadioButton.TabIndex = 11;
        PublisherRadioButton.TabStop = true;
        PublisherRadioButton.Text = "Publisher";
        PublisherRadioButton.UseVisualStyleBackColor = true;
        // 
        // YearRadioButton
        // 
        YearRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        YearRadioButton.Location = new System.Drawing.Point(1318, 160);
        YearRadioButton.Name = "YearRadioButton";
        YearRadioButton.Size = new System.Drawing.Size(104, 49);
        YearRadioButton.TabIndex = 12;
        YearRadioButton.TabStop = true;
        YearRadioButton.Text = "Publication\r\nYear";
        YearRadioButton.UseVisualStyleBackColor = true;
        // 
        // PagesRadioButton
        // 
        PagesRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        PagesRadioButton.Location = new System.Drawing.Point(1173, 160);
        PagesRadioButton.Name = "PagesRadioButton";
        PagesRadioButton.Size = new System.Drawing.Size(108, 46);
        PagesRadioButton.TabIndex = 13;
        PagesRadioButton.TabStop = true;
        PagesRadioButton.Text = "Pages";
        PagesRadioButton.UseVisualStyleBackColor = true;
        // 
        // ReturnButton
        // 
        ReturnButton.BackColor = System.Drawing.Color.Linen;
        ReturnButton.Location = new System.Drawing.Point(1232, 445);
        ReturnButton.Name = "ReturnButton";
        ReturnButton.Size = new System.Drawing.Size(190, 44);
        ReturnButton.TabIndex = 15;
        ReturnButton.Text = "Return";
        ReturnButton.UseVisualStyleBackColor = false;
        ReturnButton.Click += ReturnButton_Click;
        // 
        // InfoLabel2
        // 
        InfoLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        InfoLabel2.Location = new System.Drawing.Point(1031, 416);
        InfoLabel2.Name = "InfoLabel2";
        InfoLabel2.Size = new System.Drawing.Size(172, 23);
        InfoLabel2.TabIndex = 16;
        InfoLabel2.Text = "Books to return/borrow:";
        // 
        // NumberOfBooksBox
        // 
        NumberOfBooksBox.Location = new System.Drawing.Point(1330, 412);
        NumberOfBooksBox.Name = "NumberOfBooksBox";
        NumberOfBooksBox.Size = new System.Drawing.Size(92, 27);
        NumberOfBooksBox.TabIndex = 17;
        // 
        // ModifyButton
        // 
        ModifyButton.BackColor = System.Drawing.Color.Linen;
        ModifyButton.Location = new System.Drawing.Point(1306, 499);
        ModifyButton.Name = "ModifyButton";
        ModifyButton.Size = new System.Drawing.Size(116, 44);
        ModifyButton.TabIndex = 20;
        ModifyButton.Text = "Modify";
        ModifyButton.UseVisualStyleBackColor = false;
        ModifyButton.Click += ModifyButton_Click;
        // 
        // NextButton
        // 
        NextButton.BackColor = System.Drawing.Color.Linen;
        NextButton.Location = new System.Drawing.Point(556, 562);
        NextButton.Name = "NextButton";
        NextButton.Size = new System.Drawing.Size(79, 38);
        NextButton.TabIndex = 21;
        NextButton.Text = "Next";
        NextButton.UseVisualStyleBackColor = false;
        NextButton.Click += NextButton_Click;
        // 
        // PrevButton
        // 
        PrevButton.BackColor = System.Drawing.Color.Linen;
        PrevButton.Location = new System.Drawing.Point(395, 562);
        PrevButton.Name = "PrevButton";
        PrevButton.Size = new System.Drawing.Size(78, 38);
        PrevButton.TabIndex = 22;
        PrevButton.Text = "Prev";
        PrevButton.UseVisualStyleBackColor = false;
        PrevButton.Click += PrevButton_Click;
        // 
        // PageLabel
        // 
        PageLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        PageLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        PageLabel.Location = new System.Drawing.Point(487, 565);
        PageLabel.Name = "PageLabel";
        PageLabel.Size = new System.Drawing.Size(68, 31);
        PageLabel.TabIndex = 23;
        PageLabel.Text = "1/20";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.DarkGray;
        ClientSize = new System.Drawing.Size(1440, 609);
        Controls.Add(PageLabel);
        Controls.Add(PrevButton);
        Controls.Add(NextButton);
        Controls.Add(ModifyButton);
        Controls.Add(NumberOfBooksBox);
        Controls.Add(InfoLabel2);
        Controls.Add(ReturnButton);
        Controls.Add(PagesRadioButton);
        Controls.Add(YearRadioButton);
        Controls.Add(PublisherRadioButton);
        Controls.Add(InfoLabel);
        Controls.Add(DeleteButton);
        Controls.Add(BorrowButton);
        Controls.Add(AddButton);
        Controls.Add(GenreRadioButton);
        Controls.Add(TitleRadioButton);
        Controls.Add(AuthorRadioButton);
        Controls.Add(SearchLabel);
        Controls.Add(SearchTextBox);
        Controls.Add(dataGridView1);
        Text = "Welcome";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)NumberOfBooksBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label PageLabel;

    private System.Windows.Forms.Button NextButton;
    private System.Windows.Forms.Button PrevButton;

    private System.Windows.Forms.DataGridView dataGridView2;

    private System.Windows.Forms.Button ModifyButton;

    private System.Windows.Forms.NumericUpDown NumberOfBooksBox;

    private System.Windows.Forms.Button ReturnButton;
    private System.Windows.Forms.Label InfoLabel2;

    private System.Windows.Forms.RadioButton PagesRadioButton;

    private System.Windows.Forms.RadioButton PublisherRadioButton;
    private System.Windows.Forms.RadioButton YearRadioButton;

    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Button BorrowButton;
    private System.Windows.Forms.Button DeleteButton;
    private System.Windows.Forms.Label InfoLabel;

    private System.Windows.Forms.RadioButton GenreRadioButton;

    private System.Windows.Forms.RadioButton TitleRadioButton;

    private System.Windows.Forms.RadioButton AuthorRadioButton;

    private System.Windows.Forms.TextBox SearchTextBox;
    private System.Windows.Forms.Label SearchLabel;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}