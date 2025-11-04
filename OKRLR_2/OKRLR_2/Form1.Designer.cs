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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            buttonStats = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnCategory, ColumnSum, ColumnDate, ColumnComment });
            dataGridView1.Location = new Point(207, 81);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(633, 384);
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
            comboBoxMonth.BackColor = SystemColors.GradientInactiveCaption;
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBoxMonth.Location = new Point(18, 136);
            comboBoxMonth.Margin = new Padding(2);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(174, 33);
            comboBoxMonth.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = SystemColors.GradientInactiveCaption;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Products", "Household chemicals", "Taxes", "Travel", "Fuel", "Devices" });
            comboBoxCategory.Location = new Point(18, 210);
            comboBoxCategory.Margin = new Padding(2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(174, 33);
            comboBoxCategory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(18, 108);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 4;
            label1.Text = "Місяць:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(18, 182);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 5;
            label2.Text = "Категорія:";
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.BackColor = SystemColors.InactiveBorder;
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, увійтиToolStripMenuItem, заєструватисяToolStripMenuItem });
            menuStrip1.Location = new Point(350, 27);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(490, 36);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(63, 32);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = SystemColors.InactiveBorder;
            editToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(61, 32);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(83, 32);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // увійтиToolStripMenuItem
            // 
            увійтиToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            увійтиToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            увійтиToolStripMenuItem.Name = "увійтиToolStripMenuItem";
            увійтиToolStripMenuItem.Size = new Size(83, 32);
            увійтиToolStripMenuItem.Text = "Увійти";
            увійтиToolStripMenuItem.Click += увійтиToolStripMenuItem_Click;
            // 
            // заєструватисяToolStripMenuItem
            // 
            заєструватисяToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            заєструватисяToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            заєструватисяToolStripMenuItem.Name = "заєструватисяToolStripMenuItem";
            заєструватисяToolStripMenuItem.Size = new Size(191, 32);
            заєструватисяToolStripMenuItem.Text = "Зареєструватись";
            заєструватисяToolStripMenuItem.Click += заєструватисяToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(18, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(331, 54);
            label4.TabIndex = 8;
            label4.Text = "ExpenseTracker";
            label4.Click += label4_Click;
            // 
            // buttonFindExpensive
            // 
            buttonFindExpensive.BackColor = SystemColors.InactiveCaptionText;
            buttonFindExpensive.ForeColor = SystemColors.ButtonHighlight;
            buttonFindExpensive.Location = new Point(18, 317);
            buttonFindExpensive.Margin = new Padding(4);
            buttonFindExpensive.Name = "buttonFindExpensive";
            buttonFindExpensive.Size = new Size(174, 38);
            buttonFindExpensive.TabIndex = 9;
            buttonFindExpensive.Text = "Пошук витрат";
            buttonFindExpensive.UseVisualStyleBackColor = false;
            buttonFindExpensive.Click += buttonFindExpensive_Click;
            // 
            // buttonStats
            // 
            buttonStats.BackColor = SystemColors.InactiveCaptionText;
            buttonStats.ForeColor = SystemColors.ButtonHighlight;
            buttonStats.Location = new Point(18, 387);
            buttonStats.Margin = new Padding(4);
            buttonStats.Name = "buttonStats";
            buttonStats.Size = new Size(174, 38);
            buttonStats.TabIndex = 10;
            buttonStats.Text = "Статистика";
            buttonStats.UseVisualStyleBackColor = false;
            buttonStats.Click += buttonStats_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(889, 479);
            Controls.Add(buttonStats);
            Controls.Add(buttonFindExpensive);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxMonth);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button buttonStats;
    }
}
