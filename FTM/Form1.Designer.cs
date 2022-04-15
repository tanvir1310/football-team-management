namespace FTM
{
    partial class Form1Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2UserName = new System.Windows.Forms.Label();
            this.label3password = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.button1Login = new System.Windows.Forms.Button();
            this.button2Clear = new System.Windows.Forms.Button();
            this.button2Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(125, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Football Team";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(47, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 451);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2Exit);
            this.panel2.Controls.Add(this.button2Clear);
            this.panel2.Controls.Add(this.button1Login);
            this.panel2.Controls.Add(this.textPassword);
            this.panel2.Controls.Add(this.textUsername);
            this.panel2.Controls.Add(this.label3password);
            this.panel2.Controls.Add(this.label2UserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(465, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 451);
            this.panel2.TabIndex = 2;
            // 
            // label2UserName
            // 
            this.label2UserName.AutoSize = true;
            this.label2UserName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2UserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2UserName.Location = new System.Drawing.Point(42, 180);
            this.label2UserName.Name = "label2UserName";
            this.label2UserName.Size = new System.Drawing.Size(90, 19);
            this.label2UserName.TabIndex = 1;
            this.label2UserName.Text = "User Name";
            // 
            // label3password
            // 
            this.label3password.AutoSize = true;
            this.label3password.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3password.Location = new System.Drawing.Point(42, 249);
            this.label3password.Name = "label3password";
            this.label3password.Size = new System.Drawing.Size(80, 19);
            this.label3password.TabIndex = 2;
            this.label3password.Text = "Password";
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(156, 176);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(254, 28);
            this.textUsername.TabIndex = 3;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(156, 246);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(254, 28);
            this.textPassword.TabIndex = 4;
            // 
            // button1Login
            // 
            this.button1Login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1Login.Location = new System.Drawing.Point(330, 310);
            this.button1Login.Name = "button1Login";
            this.button1Login.Size = new System.Drawing.Size(80, 32);
            this.button1Login.TabIndex = 5;
            this.button1Login.Text = "Login";
            this.button1Login.UseVisualStyleBackColor = false;
            // 
            // button2Clear
            // 
            this.button2Clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2Clear.Location = new System.Drawing.Point(156, 310);
            this.button2Clear.Name = "button2Clear";
            this.button2Clear.Size = new System.Drawing.Size(80, 32);
            this.button2Clear.TabIndex = 6;
            this.button2Clear.Text = "Clear";
            this.button2Clear.UseVisualStyleBackColor = false;
            // 
            // button2Exit
            // 
            this.button2Exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2Exit.Location = new System.Drawing.Point(46, 404);
            this.button2Exit.Name = "button2Exit";
            this.button2Exit.Size = new System.Drawing.Size(80, 32);
            this.button2Exit.TabIndex = 7;
            this.button2Exit.Text = "Exit";
            this.button2Exit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::FTM.Properties.Resources.team_423_845005;
            this.pictureBox1.Location = new System.Drawing.Point(3, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 275);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(159, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Management System";
            // 
            // Form1Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1045, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2Exit;
        private System.Windows.Forms.Button button2Clear;
        private System.Windows.Forms.Button button1Login;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label3password;
        private System.Windows.Forms.Label label2UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

