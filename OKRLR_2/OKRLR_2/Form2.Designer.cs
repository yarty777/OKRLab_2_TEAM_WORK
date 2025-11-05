namespace OKRLR_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBoxSum = new TextBox();
            textBoxComentar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxCategory = new ComboBox();
            comboBoxDate = new ComboBox();
            label5 = new Label();
            buttonsave = new Button();
            SuspendLayout();
            // 
            // textBoxSum
            // 
            textBoxSum.BackColor = SystemColors.GradientInactiveCaption;
            textBoxSum.Location = new Point(22, 163);
            textBoxSum.Margin = new Padding(2);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(150, 27);
            textBoxSum.TabIndex = 1;
            // 
            // textBoxComentar
            // 
            textBoxComentar.BackColor = SystemColors.GradientInactiveCaption;
            textBoxComentar.Location = new Point(22, 285);
            textBoxComentar.Margin = new Padding(2);
            textBoxComentar.Name = "textBoxComentar";
            textBoxComentar.Size = new Size(150, 27);
            textBoxComentar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(22, 75);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 4;
            label1.Text = "Категорія:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(22, 141);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 5;
            label2.Text = "Сума:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(22, 201);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 6;
            label3.Text = "Дата:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(22, 262);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 7;
            label4.Text = "Коментарій:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = SystemColors.GradientInactiveCaption;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Products", "Household chemicals", "Taxes", "Travel", "Fuel", "Devices" });
            comboBoxCategory.Location = new Point(22, 98);
            comboBoxCategory.Margin = new Padding(2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(146, 28);
            comboBoxCategory.TabIndex = 8;
            // 
            // comboBoxDate
            // 
            comboBoxDate.BackColor = SystemColors.GradientInactiveCaption;
            comboBoxDate.FormattingEnabled = true;
            comboBoxDate.Location = new Point(22, 223);
            comboBoxDate.Margin = new Padding(2);
            comboBoxDate.Name = "comboBoxDate";
            comboBoxDate.Size = new Size(146, 28);
            comboBoxDate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(22, 19);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 46);
            label5.TabIndex = 10;
            label5.Text = "ADD";
            // 
            // buttonsave
            // 
            buttonsave.Location = new Point(22, 332);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(149, 37);
            buttonsave.TabIndex = 11;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = true;
            buttonsave.Click += buttonsave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(214, 390);
            Controls.Add(buttonsave);
            Controls.Add(label5);
            Controls.Add(comboBoxDate);
            Controls.Add(comboBoxCategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxComentar);
            Controls.Add(textBoxSum);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form2";
            Text = "ExpenseTracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxSum;
        private TextBox textBoxComentar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxDate;
        private Label label5;
        private Button buttonsave;
    }
}