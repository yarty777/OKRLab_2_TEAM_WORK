namespace OKRLR_2
{
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
            dataGridView1 = new DataGridView();
            ColumnCategory = new DataGridViewTextBoxColumn();
            ColumnSum = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnComment = new DataGridViewTextBoxColumn();
            comboBoxMonth = new ComboBox();
            comboBoxCategory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            увійтиToolStripMenuItem = new ToolStripMenuItem();
            заєструватисяToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            buttonFindExpensive = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnCategory, ColumnSum, ColumnDate, ColumnComment });
            dataGridView1.Location = new Point(150, 65);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(554, 307);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnCategory
            // 
            ColumnCategory.HeaderText = "Категорія";
            ColumnCategory.MinimumWidth = 8;
            ColumnCategory.Name = "ColumnCategory";
            ColumnCategory.Width = 150;
            // 
            // ColumnSum
            // 
            ColumnSum.HeaderText = "Сума";
            ColumnSum.MinimumWidth = 8;
            ColumnSum.Name = "ColumnSum";
            ColumnSum.Width = 125;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Дата";
            ColumnDate.MinimumWidth = 8;
            ColumnDate.Name = "ColumnDate";
            ColumnDate.Width = 125;
            // 
            // ColumnComment
            // 
            ColumnComment.HeaderText = "Коментар";
            ColumnComment.MinimumWidth = 8;
            ColumnComment.Name = "ColumnComment";
            ColumnComment.Width = 150;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBoxMonth.Location = new Point(13, 109);
            comboBoxMonth.Margin = new Padding(2);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(128, 28);
            comboBoxMonth.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Products", "Household chemicals", "Taxes", "Travel", "Fuel", "Devices" });
            comboBoxCategory.Location = new Point(13, 168);
            comboBoxCategory.Margin = new Padding(2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(128, 28);
            comboBoxCategory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 4;
            label1.Text = "Місяць";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 146);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Категорія";
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, увійтиToolStripMenuItem, заєструватисяToolStripMenuItem });
            menuStrip1.Location = new Point(289, 22);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(416, 31);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(55, 27);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(53, 27);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(73, 27);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // увійтиToolStripMenuItem
            // 
            увійтиToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            увійтиToolStripMenuItem.Name = "увійтиToolStripMenuItem";
            увійтиToolStripMenuItem.Size = new Size(74, 27);
            увійтиToolStripMenuItem.Text = "Увійти";
            // 
            // заєструватисяToolStripMenuItem
            // 
            заєструватисяToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            заєструватисяToolStripMenuItem.Name = "заєструватисяToolStripMenuItem";
            заєструватисяToolStripMenuItem.Size = new Size(154, 27);
            заєструватисяToolStripMenuItem.Text = "Зареєструватись";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(13, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(284, 46);
            label4.TabIndex = 8;
            label4.Text = "ExpenseTracker";
            label4.Click += label4_Click;
            // 
            // buttonFindExpensive
            // 
            buttonFindExpensive.Location = new Point(6, 316);
            buttonFindExpensive.Name = "buttonFindExpensive";
            buttonFindExpensive.Size = new Size(139, 30);
            buttonFindExpensive.TabIndex = 9;
            buttonFindExpensive.Text = "Пошук витрат";
            buttonFindExpensive.UseVisualStyleBackColor = true;
            buttonFindExpensive.Click += buttonFindExpensive_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 383);
            Controls.Add(buttonFindExpensive);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxMonth);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "ExpenseTracker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxCategory;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem увійтиToolStripMenuItem;
        private ToolStripMenuItem заєструватисяToolStripMenuItem;
        private Label label4;
        private Button buttonFindExpensive;
        private DataGridViewTextBoxColumn ColumnCategory;
        private DataGridViewTextBoxColumn ColumnSum;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnComment;
    }
}
