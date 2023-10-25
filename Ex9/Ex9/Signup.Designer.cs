namespace Ex9
{
    partial class Signup
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
            this.name = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.uname_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create User";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(230, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 28);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(180, 216);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(138, 28);
            this.pass.TabIndex = 2;
            this.pass.Text = "Password";
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(180, 171);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(143, 28);
            this.uname.TabIndex = 3;
            this.uname.Text = "Username";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(230, 123);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(87, 28);
            this.email.TabIndex = 4;
            this.email.Text = "Email";
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Prestige Elite Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(336, 71);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(180, 30);
            this.name_box.TabIndex = 5;
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Prestige Elite Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(336, 121);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(180, 30);
            this.email_box.TabIndex = 6;
            // 
            // uname_box
            // 
            this.uname_box.Font = new System.Drawing.Font("Prestige Elite Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_box.Location = new System.Drawing.Point(336, 169);
            this.uname_box.Name = "uname_box";
            this.uname_box.Size = new System.Drawing.Size(180, 30);
            this.uname_box.TabIndex = 7;
            // 
            // pass_box
            // 
            this.pass_box.Font = new System.Drawing.Font("Prestige Elite Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.Location = new System.Drawing.Point(336, 214);
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '*';
            this.pass_box.Size = new System.Drawing.Size(180, 30);
            this.pass_box.TabIndex = 8;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Montserrat", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.submit.Location = new System.Drawing.Point(292, 269);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(91, 33);
            this.submit.TabIndex = 9;
            this.submit.Text = "Create";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.uname_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.email);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox uname_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Button submit;
    }
}