namespace MyNewWinFormsApp;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        CategoryComboBox = new ComboBox();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        contextMenuStrip1 = new ContextMenuStrip(components);
        deleteExpenseToolStripMenuItem = new ToolStripMenuItem();
        duplicateExpenseToolStripMenuItem = new ToolStripMenuItem();
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        AddCategoryBtn = new Button();
        CategoryGroupBox = new GroupBox();
        ExpenseAmountTextBox = new TextBox();
        ExpenseAmoutLabel = new Label();
        ExpenseCreationDateLabel = new Label();
        ExpenseExpirationDateLabel = new Label();
        ExpenseExpirationDtp = new DateTimePicker();
        ExpenseCreationDtp = new DateTimePicker();
        ExpenseDescriptionTextBox = new TextBox();
        ExpenseEditSaveBtn = new Button();
        AddExpenseBtn = new Button();
        ExpensesListBox = new ListBox();
        menuStrip1.SuspendLayout();
        contextMenuStrip1.SuspendLayout();
        CategoryGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // CategoryComboBox
        // 
        CategoryComboBox.FormattingEnabled = true;
        CategoryComboBox.Items.AddRange(new object[] { "Select a category..", "Mandatory", "Extra", "Saving" });
        CategoryComboBox.Location = new Point(28, 49);
        CategoryComboBox.Name = "CategoryComboBox";
        CategoryComboBox.Size = new Size(643, 23);
        CategoryComboBox.TabIndex = 2;
        CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(8, 2, 0, 2);
        menuStrip1.Size = new Size(1183, 24);
        menuStrip1.TabIndex = 1;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "File";
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteExpenseToolStripMenuItem, duplicateExpenseToolStripMenuItem });
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(170, 48);
        // 
        // deleteExpenseToolStripMenuItem
        // 
        deleteExpenseToolStripMenuItem.Name = "deleteExpenseToolStripMenuItem";
        deleteExpenseToolStripMenuItem.Size = new Size(169, 22);
        deleteExpenseToolStripMenuItem.Text = "Delete expense";
        // 
        // duplicateExpenseToolStripMenuItem
        // 
        duplicateExpenseToolStripMenuItem.Name = "duplicateExpenseToolStripMenuItem";
        duplicateExpenseToolStripMenuItem.Size = new Size(169, 22);
        duplicateExpenseToolStripMenuItem.Text = "Duplicate expense";
        // 
        // AddCategoryBtn
        // 
        AddCategoryBtn.Location = new Point(688, 49);
        AddCategoryBtn.Name = "AddCategoryBtn";
        AddCategoryBtn.Size = new Size(149, 23);
        AddCategoryBtn.TabIndex = 2;
        AddCategoryBtn.Text = "Add Category";
        AddCategoryBtn.UseVisualStyleBackColor = true;
        // 
        // CategoryGroupBox
        // 
        CategoryGroupBox.Controls.Add(ExpenseAmountTextBox);
        CategoryGroupBox.Controls.Add(ExpenseAmoutLabel);
        CategoryGroupBox.Controls.Add(ExpenseCreationDateLabel);
        CategoryGroupBox.Controls.Add(ExpenseExpirationDateLabel);
        CategoryGroupBox.Controls.Add(ExpenseExpirationDtp);
        CategoryGroupBox.Controls.Add(ExpenseCreationDtp);
        CategoryGroupBox.Controls.Add(ExpenseDescriptionTextBox);
        CategoryGroupBox.Controls.Add(ExpenseEditSaveBtn);
        CategoryGroupBox.Controls.Add(AddExpenseBtn);
        CategoryGroupBox.Controls.Add(ExpensesListBox);
        CategoryGroupBox.Location = new Point(28, 80);
        CategoryGroupBox.Margin = new Padding(4);
        CategoryGroupBox.Name = "CategoryGroupBox";
        CategoryGroupBox.Size = new Size(863, 671);
        CategoryGroupBox.TabIndex = 3;
        CategoryGroupBox.TabStop = false;
        CategoryGroupBox.Text = "Category";
        // 
        // ExpenseAmountTextBox
        // 
        ExpenseAmountTextBox.Cursor = Cursors.IBeam;
        ExpenseAmountTextBox.Location = new Point(513, 305);
        ExpenseAmountTextBox.Margin = new Padding(4);
        ExpenseAmountTextBox.Name = "ExpenseAmountTextBox";
        ExpenseAmountTextBox.Size = new Size(279, 23);
        ExpenseAmountTextBox.TabIndex = 11;
        // 
        // ExpenseAmoutLabel
        // 
        ExpenseAmoutLabel.AutoSize = true;
        ExpenseAmoutLabel.Location = new Point(387, 308);
        ExpenseAmoutLabel.Name = "ExpenseAmoutLabel";
        ExpenseAmoutLabel.Size = new Size(51, 15);
        ExpenseAmoutLabel.TabIndex = 10;
        ExpenseAmoutLabel.Text = "Amount";
        // 
        // ExpenseCreationDateLabel
        // 
        ExpenseCreationDateLabel.AutoSize = true;
        ExpenseCreationDateLabel.Location = new Point(386, 171);
        ExpenseCreationDateLabel.Name = "ExpenseCreationDateLabel";
        ExpenseCreationDateLabel.Size = new Size(31, 15);
        ExpenseCreationDateLabel.TabIndex = 9;
        ExpenseCreationDateLabel.Text = "Start";
        // 
        // ExpenseExpirationDateLabel
        // 
        ExpenseExpirationDateLabel.AutoSize = true;
        ExpenseExpirationDateLabel.Location = new Point(386, 218);
        ExpenseExpirationDateLabel.Name = "ExpenseExpirationDateLabel";
        ExpenseExpirationDateLabel.Size = new Size(59, 15);
        ExpenseExpirationDateLabel.TabIndex = 8;
        ExpenseExpirationDateLabel.Text = "Expiration";
        // 
        // ExpenseExpirationDtp
        // 
        ExpenseExpirationDtp.Location = new Point(513, 212);
        ExpenseExpirationDtp.Name = "ExpenseExpirationDtp";
        ExpenseExpirationDtp.Size = new Size(279, 23);
        ExpenseExpirationDtp.TabIndex = 7;
        // 
        // ExpenseCreationDtp
        // 
        ExpenseCreationDtp.Location = new Point(513, 165);
        ExpenseCreationDtp.Name = "ExpenseCreationDtp";
        ExpenseCreationDtp.Size = new Size(279, 23);
        ExpenseCreationDtp.TabIndex = 6;
        // 
        // ExpenseDescriptionTextBox
        // 
        ExpenseDescriptionTextBox.Cursor = Cursors.IBeam;
        ExpenseDescriptionTextBox.Location = new Point(387, 22);
        ExpenseDescriptionTextBox.Margin = new Padding(4);
        ExpenseDescriptionTextBox.Multiline = true;
        ExpenseDescriptionTextBox.Name = "ExpenseDescriptionTextBox";
        ExpenseDescriptionTextBox.ReadOnly = true;
        ExpenseDescriptionTextBox.ScrollBars = ScrollBars.Vertical;
        ExpenseDescriptionTextBox.Size = new Size(405, 136);
        ExpenseDescriptionTextBox.TabIndex = 5;
        // 
        // ExpenseEditSaveBtn
        // 
        ExpenseEditSaveBtn.Location = new Point(799, 22);
        ExpenseEditSaveBtn.Name = "ExpenseEditSaveBtn";
        ExpenseEditSaveBtn.Size = new Size(58, 43);
        ExpenseEditSaveBtn.TabIndex = 4;
        ExpenseEditSaveBtn.Text = "Edit";
        ExpenseEditSaveBtn.UseVisualStyleBackColor = true;
        ExpenseEditSaveBtn.Click += ExpenseEditSaveBtn_Click;
        // 
        // AddExpenseBtn
        // 
        AddExpenseBtn.Location = new Point(6, 617);
        AddExpenseBtn.Name = "AddExpenseBtn";
        AddExpenseBtn.Size = new Size(374, 48);
        AddExpenseBtn.TabIndex = 1;
        AddExpenseBtn.Text = "Add Expense";
        AddExpenseBtn.UseVisualStyleBackColor = true;
        AddExpenseBtn.Click += AddExpenseBtn_Click;
        // 
        // ExpensesListBox
        // 
        ExpensesListBox.FormattingEnabled = true;
        ExpensesListBox.Location = new Point(6, 22);
        ExpensesListBox.Name = "ExpensesListBox";
        ExpensesListBox.Size = new Size(374, 589);
        ExpensesListBox.TabIndex = 0;
        ExpensesListBox.SelectedIndexChanged += ExpensesListBox_SelectedIndexChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1183, 763);
        Controls.Add(CategoryGroupBox);
        Controls.Add(AddCategoryBtn);
        Controls.Add(CategoryComboBox);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        Text = "Month Expense Manager";
        Load += Form1_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        contextMenuStrip1.ResumeLayout(false);
        CategoryGroupBox.ResumeLayout(false);
        CategoryGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox CategoryComboBox;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem deleteExpenseToolStripMenuItem;
    private ToolStripMenuItem duplicateExpenseToolStripMenuItem;
    internal System.ComponentModel.BackgroundWorker backgroundWorker1;
    private Button AddCategoryBtn;
    private GroupBox CategoryGroupBox;
    internal TextBox ExpenseAmountTextBox;
    private Label ExpenseAmoutLabel;
    private Label ExpenseCreationDateLabel;
    private Label ExpenseExpirationDateLabel;
    internal TextBox ExpenseDescriptionTextBox;
    internal DateTimePicker ExpenseCreationDtp;
    internal DateTimePicker ExpenseExpirationDtp;
    internal Button AddExpenseBtn;
    internal ListBox ExpensesListBox;
    internal Button ExpenseEditSaveBtn;
}
