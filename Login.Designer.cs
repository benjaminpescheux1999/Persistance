
namespace Persistance
{
    partial class Login
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
            this.Connect = new System.Windows.Forms.Button();
            this.NamePers = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(248, 254);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(274, 42);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // NamePers
            // 
            this.NamePers.Location = new System.Drawing.Point(248, 193);
            this.NamePers.Name = "NamePers";
            this.NamePers.Size = new System.Drawing.Size(141, 23);
            this.NamePers.TabIndex = 1;
            this.NamePers.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(395, 193);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(127, 23);
            this.Password.TabIndex = 2;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(287, 172);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(39, 15);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Name";
            this.LabelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(428, 172);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(57, 15);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Password";
            this.LabelPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(248, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(274, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.NamePers);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox NamePers;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

