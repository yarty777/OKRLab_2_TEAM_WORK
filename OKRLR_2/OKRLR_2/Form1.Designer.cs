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
            Category = new DataGridViewTextBoxColumn();
            Sum = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Comment = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            увійтиToolStripMenuItem = new ToolStripMenuItem();
            заєструватисяToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Category, Sum, Date, Comment });
            dataGridView1.Location = new Point(216, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(664, 342);
            dataGridView1.TabIndex = 0;
            // 
            // Category
            // 
            Category.HeaderText = "Категорія";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.Width = 150;
            // 
            // Sum
            // 
            Sum.HeaderText = "Сума";
            Sum.MinimumWidth = 8;
            Sum.Name = "Sum";
            Sum.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Дата";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 150;
            // 
            // Comment
            // 
            Comment.HeaderText = "Коментар";
            Comment.MinimumWidth = 8;
            Comment.Name = "Comment";
            Comment.Width = 150;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 33);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(16, 210);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(159, 33);
            comboBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 282);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 31);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 108);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 4;
            label1.Text = "Місяць";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 182);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 5;
            label2.Text = "Категорія";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 254);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 6;
            label3.Text = "Пошук";
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, увійтиToolStripMenuItem, заєструватисяToolStripMenuItem });
            menuStrip1.Location = new Point(383, 27);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(485, 36);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(65, 32);
            addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(62, 32);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(84, 32);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // увійтиToolStripMenuItem
            // 
            увійтиToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            увійтиToolStripMenuItem.Name = "увійтиToolStripMenuItem";
            увійтиToolStripMenuItem.Size = new Size(87, 32);
            увійтиToolStripMenuItem.Text = "Увійти";
            // 
            // заєструватисяToolStripMenuItem
            // 
            заєструватисяToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            заєструватисяToolStripMenuItem.Name = "заєструватисяToolStripMenuItem";
            заєструватисяToolStripMenuItem.Size = new Size(179, 32);
            заєструватисяToolStripMenuItem.Text = "Зареєструватись";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(331, 54);
            label4.TabIndex = 8;
            label4.Text = "ExpenseTracker";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 499);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem увійтиToolStripMenuItem;
        private ToolStripMenuItem заєструватисяToolStripMenuItem;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Sum;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Comment;
        private Label label4;
    }
}
