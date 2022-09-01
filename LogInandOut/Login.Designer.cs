namespace LogInandOut
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBusername = new System.Windows.Forms.TextBox();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btnLogout.Location = new System.Drawing.Point(514, 308);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(235, 82);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btnLogin.Location = new System.Drawing.Point(204, 308);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(234, 82);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label1.Location = new System.Drawing.Point(346, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label2.Location = new System.Drawing.Point(122, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label3.Location = new System.Drawing.Point(127, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // TBusername
            // 
            this.TBusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.TBusername.Location = new System.Drawing.Point(307, 96);
            this.TBusername.Name = "TBusername";
            this.TBusername.Size = new System.Drawing.Size(390, 37);
            this.TBusername.TabIndex = 5;
            // 
            // TBpassword
            // 
            this.TBpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.TBpassword.Location = new System.Drawing.Point(307, 213);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.Size = new System.Drawing.Size(390, 37);
            this.TBpassword.TabIndex = 6;
            this.TBpassword.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.TBusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnLogout);
            this.Name = "Login";
            this.Text = "Username";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBusername;
        private System.Windows.Forms.TextBox TBpassword;
    }
}

