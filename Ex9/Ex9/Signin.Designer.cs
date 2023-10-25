namespace Ex9
{
    partial class Signin
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
            this.uname = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.signin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "SignIn";
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(260, 121);
            this.uname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(137, 36);
            this.uname.TabIndex = 1;
            this.uname.Text = "Username";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(260, 182);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(130, 36);
            this.pass.TabIndex = 2;
            this.pass.Text = "Password";
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(427, 118);
            this.name_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(225, 33);
            this.name_box.TabIndex = 3;
            // 
            // pass_box
            // 
            this.pass_box.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.Location = new System.Drawing.Point(427, 185);
            this.pass_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '*';
            this.pass_box.Size = new System.Drawing.Size(225, 33);
            this.pass_box.TabIndex = 4;
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signin_btn.Font = new System.Drawing.Font("Microsoft Uighur", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.signin_btn.Location = new System.Drawing.Point(400, 281);
            this.signin_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(100, 34);
            this.signin_btn.TabIndex = 5;
            this.signin_btn.Text = "Sign In";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 554);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Signin";
            this.Text = "Signin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Button signin_btn;
    }
}