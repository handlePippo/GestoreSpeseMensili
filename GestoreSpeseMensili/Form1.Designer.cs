using GestoreSpeseMensili.Utils;
using GestoreSpeseMensili.Utils.Enum;

namespace GestoreSpeseMensili
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboChooseCategory = new System.Windows.Forms.ComboBox();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.MainBox = new System.Windows.Forms.GroupBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.ShopAmountLabel = new System.Windows.Forms.Label();
            this.EditSaveShopBtn = new System.Windows.Forms.Button();
            this.ExpirationDTPicker = new System.Windows.Forms.DateTimePicker();
            this.CreationDTPicker = new System.Windows.Forms.DateTimePicker();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.CreationDateLabel = new System.Windows.Forms.Label();
            this.ShopDetailTextBox = new System.Windows.Forms.TextBox();
            this.ShopDetailLabel = new System.Windows.Forms.Label();
            this.AddShopBtn = new System.Windows.Forms.Button();
            this.SpeseListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminaSpesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicaSpesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.MainBox.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ComboChooseCategory
            // 
            this.ComboChooseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboChooseCategory.FormattingEnabled = true;
            this.ComboChooseCategory.Items.AddRange(new object[] {
            "Select a category..",
            "Mandatory",
            "Extra",
            "Saving"});
            this.ComboChooseCategory.Location = new System.Drawing.Point(12, 27);
            this.ComboChooseCategory.Name = "ComboChooseCategory";
            this.ComboChooseCategory.Size = new System.Drawing.Size(454, 21);
            this.ComboChooseCategory.TabIndex = 2;
            this.ComboChooseCategory.SelectedIndexChanged += new System.EventHandler(this.ComboChooseCategory_SelectedIndexChanged);
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Location = new System.Drawing.Point(472, 27);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(109, 21);
            this.AddCategoryBtn.TabIndex = 3;
            this.AddCategoryBtn.Text = "Aggiungi categoria";
            this.AddCategoryBtn.UseVisualStyleBackColor = true;
            // 
            // MainBox
            // 
            this.MainBox.Controls.Add(this.AmountTextBox);
            this.MainBox.Controls.Add(this.ShopAmountLabel);
            this.MainBox.Controls.Add(this.EditSaveShopBtn);
            this.MainBox.Controls.Add(this.ExpirationDTPicker);
            this.MainBox.Controls.Add(this.CreationDTPicker);
            this.MainBox.Controls.Add(this.ExpirationDateLabel);
            this.MainBox.Controls.Add(this.CreationDateLabel);
            this.MainBox.Controls.Add(this.ShopDetailTextBox);
            this.MainBox.Controls.Add(this.ShopDetailLabel);
            this.MainBox.Controls.Add(this.AddShopBtn);
            this.MainBox.Controls.Add(this.SpeseListBox);
            this.MainBox.Location = new System.Drawing.Point(12, 54);
            this.MainBox.Name = "MainBox";
            this.MainBox.Size = new System.Drawing.Size(604, 564);
            this.MainBox.TabIndex = 4;
            this.MainBox.TabStop = false;
            this.MainBox.Text = "Categoria";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(359, 226);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(201, 20);
            this.AmountTextBox.TabIndex = 10;
            // 
            // ShopAmountLabel
            // 
            this.ShopAmountLabel.AutoSize = true;
            this.ShopAmountLabel.Location = new System.Drawing.Point(259, 229);
            this.ShopAmountLabel.Name = "ShopAmountLabel";
            this.ShopAmountLabel.Size = new System.Drawing.Size(60, 13);
            this.ShopAmountLabel.TabIndex = 9;
            this.ShopAmountLabel.Text = "Ammontare";
            // 
            // EditSaveShopBtn
            // 
            this.EditSaveShopBtn.Location = new System.Drawing.Point(566, 24);
            this.EditSaveShopBtn.Name = "EditSaveShopBtn";
            this.EditSaveShopBtn.Size = new System.Drawing.Size(35, 36);
            this.EditSaveShopBtn.TabIndex = 5;
            this.EditSaveShopBtn.Text = "Edit";
            this.EditSaveShopBtn.UseVisualStyleBackColor = true;
            this.EditSaveShopBtn.Click += new System.EventHandler(this.EditSaveBtn_Click);
            // 
            // ExpirationDTPicker
            // 
            this.ExpirationDTPicker.Location = new System.Drawing.Point(358, 175);
            this.ExpirationDTPicker.Name = "ExpirationDTPicker";
            this.ExpirationDTPicker.Size = new System.Drawing.Size(200, 20);
            this.ExpirationDTPicker.TabIndex = 6;
            // 
            // CreationDTPicker
            // 
            this.CreationDTPicker.Location = new System.Drawing.Point(359, 144);
            this.CreationDTPicker.Name = "CreationDTPicker";
            this.CreationDTPicker.Size = new System.Drawing.Size(200, 20);
            this.CreationDTPicker.TabIndex = 7;
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.AutoSize = true;
            this.ExpirationDateLabel.Location = new System.Drawing.Point(259, 179);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(55, 13);
            this.ExpirationDateLabel.TabIndex = 8;
            this.ExpirationDateLabel.Text = "Scadenza";
            // 
            // CreationDateLabel
            // 
            this.CreationDateLabel.AutoSize = true;
            this.CreationDateLabel.Location = new System.Drawing.Point(259, 147);
            this.CreationDateLabel.Name = "CreationDateLabel";
            this.CreationDateLabel.Size = new System.Drawing.Size(54, 13);
            this.CreationDateLabel.TabIndex = 7;
            this.CreationDateLabel.Text = "Creazione";
            this.CreationDateLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // ShopDetailTextBox
            // 
            this.ShopDetailTextBox.Location = new System.Drawing.Point(258, 24);
            this.ShopDetailTextBox.Multiline = true;
            this.ShopDetailTextBox.Name = "ShopDetailTextBox";
            this.ShopDetailTextBox.ReadOnly = true;
            this.ShopDetailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShopDetailTextBox.Size = new System.Drawing.Size(305, 111);
            this.ShopDetailTextBox.TabIndex = 6;
            // 
            // ShopDetailLabel
            // 
            this.ShopDetailLabel.AutoSize = true;
            this.ShopDetailLabel.Location = new System.Drawing.Point(258, 9);
            this.ShopDetailLabel.Name = "ShopDetailLabel";
            this.ShopDetailLabel.Size = new System.Drawing.Size(35, 13);
            this.ShopDetailLabel.TabIndex = 5;
            this.ShopDetailLabel.Text = "label1";
            // 
            // AddShopBtn
            // 
            this.AddShopBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddShopBtn.Enabled = false;
            this.AddShopBtn.Location = new System.Drawing.Point(6, 525);
            this.AddShopBtn.Name = "AddShopBtn";
            this.AddShopBtn.Size = new System.Drawing.Size(246, 35);
            this.AddShopBtn.TabIndex = 5;
            this.AddShopBtn.Text = "Aggiungi spesa";
            this.AddShopBtn.UseVisualStyleBackColor = false;
            this.AddShopBtn.Click += new System.EventHandler(this.AddShopBtn_Click);
            // 
            // SpeseListBox
            // 
            this.SpeseListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.SpeseListBox.FormattingEnabled = true;
            this.SpeseListBox.Location = new System.Drawing.Point(6, 24);
            this.SpeseListBox.Name = "SpeseListBox";
            this.SpeseListBox.Size = new System.Drawing.Size(246, 498);
            this.SpeseListBox.TabIndex = 0;
            this.SpeseListBox.SelectedIndexChanged += new System.EventHandler(this.SpeseListBox_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminaSpesaToolStripMenuItem,
            this.duplicaSpesaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            // 
            // eliminaSpesaToolStripMenuItem
            // 
            this.eliminaSpesaToolStripMenuItem.Name = "eliminaSpesaToolStripMenuItem";
            this.eliminaSpesaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.eliminaSpesaToolStripMenuItem.Text = "Elimina spesa";
            // 
            // duplicaSpesaToolStripMenuItem
            // 
            this.duplicaSpesaToolStripMenuItem.Name = "duplicaSpesaToolStripMenuItem";
            this.duplicaSpesaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.duplicaSpesaToolStripMenuItem.Text = "Duplica spesa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 630);
            this.Controls.Add(this.MainBox);
            this.Controls.Add(this.AddCategoryBtn);
            this.Controls.Add(this.ComboChooseCategory);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestore spese";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainBox.ResumeLayout(false);
            this.MainBox.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        internal System.Windows.Forms.ComboBox ComboChooseCategory;
        internal System.Windows.Forms.Button AddCategoryBtn;
        internal System.Windows.Forms.GroupBox MainBox;
        internal System.Windows.Forms.ListBox SpeseListBox;
        internal System.Windows.Forms.Button AddShopBtn;
        internal System.Windows.Forms.TextBox ShopDetailTextBox;
        internal System.Windows.Forms.Label ShopDetailLabel;
        internal System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem eliminaSpesaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem duplicaSpesaToolStripMenuItem;
        internal System.Windows.Forms.Label ExpirationDateLabel;
        internal System.Windows.Forms.Label CreationDateLabel;
        internal System.Windows.Forms.DateTimePicker ExpirationDTPicker;
        internal System.Windows.Forms.DateTimePicker CreationDTPicker;
        internal System.Windows.Forms.Button EditSaveShopBtn;
        internal System.Windows.Forms.TextBox AmountTextBox;
        internal System.Windows.Forms.Label ShopAmountLabel;
        internal System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

