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
            textBoxSum = new TextBox();
            textBoxComentar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxCategory = new ComboBox();
            comboBoxDate = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(28, 204);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(186, 31);
            textBoxSum.TabIndex = 1;
            // 
            // textBoxComentar
            // 
            textBoxComentar.Location = new Point(28, 356);
            textBoxComentar.Name = "textBoxComentar";
            textBoxComentar.Size = new Size(186, 31);
            textBoxComentar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 94);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 4;
            label1.Text = "Категорія:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 176);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 5;
            label2.Text = "Сума:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 251);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 6;
            label3.Text = "Дата:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 328);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 7;
            label4.Text = "Коментарій:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(28, 122);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(182, 33);
            comboBoxCategory.TabIndex = 8;
            // 
            // comboBoxDate
            // 
            comboBoxDate.FormattingEnabled = true;
            comboBoxDate.Location = new Point(28, 279);
            comboBoxDate.Name = "comboBoxDate";
            comboBoxDate.Size = new Size(182, 33);
            comboBoxDate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(28, 24);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 54);
            label5.TabIndex = 10;
            label5.Text = "ADD";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 450);
            Controls.Add(label5);
            Controls.Add(comboBoxDate);
            Controls.Add(comboBoxCategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxComentar);
            Controls.Add(textBoxSum);
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
    }
}