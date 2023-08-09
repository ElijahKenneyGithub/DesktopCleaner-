namespace DesktopDeclutterer
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(48, 263);
            button1.Name = "button1";
            button1.Size = new Size(238, 113);
            button1.TabIndex = 0;
            button1.Text = "Click to Declutter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(174, 30);
            label1.Name = "label1";
            label1.Size = new Size(433, 35);
            label1.TabIndex = 1;
            label1.Text = "Elijah's Window Desktop Declutterer";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(429, 263);
            button2.Name = "button2";
            button2.Size = new Size(238, 113);
            button2.TabIndex = 2;
            button2.Text = "Reverse Declutter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Elijah's Window Desktop Declutter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public Label label1;
        private Button button2;
    }
}