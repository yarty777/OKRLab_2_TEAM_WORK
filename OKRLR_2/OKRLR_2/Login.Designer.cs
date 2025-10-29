namespace OKRLR_2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(60, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 31);
            textBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 272);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 31);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(60, 142);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 5;
            label1.Text = "Введіть email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(60, 241);
            label2.Name = "label2";
            label2.Size = new Size(167, 28);
            label2.TabIndex = 6;
            label2.Text = "Введіть пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(35, 37);
            label4.Name = "label4";
            label4.Size = new Size(252, 45);
            label4.TabIndex = 8;
            label4.Text = "ExpenseTracker";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_abstract_relief_texture_crafted_from_wood_stone_or_alternative_materials_png_image_12227775;
            ClientSize = new Size(321, 450);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}