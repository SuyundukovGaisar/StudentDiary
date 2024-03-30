namespace StudentDiary
{
    partial class ProfileStudentForm
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
            this.NameStudentInfoLabel = new System.Windows.Forms.Label();
            this.NameStudentLabel = new System.Windows.Forms.Label();
            this.EmailStudentLabel = new System.Windows.Forms.Label();
            this.EmaiStudentInfoLabel = new System.Windows.Forms.Label();
            this.PasswordStudentLabel = new System.Windows.Forms.Label();
            this.PasswordStudentInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameStudentInfoLabel
            // 
            this.NameStudentInfoLabel.AutoSize = true;
            this.NameStudentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameStudentInfoLabel.Location = new System.Drawing.Point(12, 77);
            this.NameStudentInfoLabel.Name = "NameStudentInfoLabel";
            this.NameStudentInfoLabel.Size = new System.Drawing.Size(297, 25);
            this.NameStudentInfoLabel.TabIndex = 0;
            this.NameStudentInfoLabel.Text = "Суюндуков Гайсар Эдуардович";
            // 
            // NameStudentLabel
            // 
            this.NameStudentLabel.AutoSize = true;
            this.NameStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameStudentLabel.Location = new System.Drawing.Point(12, 41);
            this.NameStudentLabel.Name = "NameStudentLabel";
            this.NameStudentLabel.Size = new System.Drawing.Size(66, 25);
            this.NameStudentLabel.TabIndex = 1;
            this.NameStudentLabel.Text = "ФИО:";
            // 
            // EmailStudentLabel
            // 
            this.EmailStudentLabel.AutoSize = true;
            this.EmailStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailStudentLabel.Location = new System.Drawing.Point(12, 119);
            this.EmailStudentLabel.Name = "EmailStudentLabel";
            this.EmailStudentLabel.Size = new System.Drawing.Size(66, 25);
            this.EmailStudentLabel.TabIndex = 2;
            this.EmailStudentLabel.Text = "Email:";
            // 
            // EmaiStudentInfoLabel
            // 
            this.EmaiStudentInfoLabel.AutoSize = true;
            this.EmaiStudentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmaiStudentInfoLabel.Location = new System.Drawing.Point(12, 157);
            this.EmaiStudentInfoLabel.Name = "EmaiStudentInfoLabel";
            this.EmaiStudentInfoLabel.Size = new System.Drawing.Size(144, 25);
            this.EmaiStudentInfoLabel.TabIndex = 3;
            this.EmaiStudentInfoLabel.Text = "aaaaa@mail.ru";
            // 
            // PasswordStudentLabel
            // 
            this.PasswordStudentLabel.AutoSize = true;
            this.PasswordStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordStudentLabel.Location = new System.Drawing.Point(12, 195);
            this.PasswordStudentLabel.Name = "PasswordStudentLabel";
            this.PasswordStudentLabel.Size = new System.Drawing.Size(80, 25);
            this.PasswordStudentLabel.TabIndex = 6;
            this.PasswordStudentLabel.Text = "Пароль";
            // 
            // PasswordStudentInfoLabel
            // 
            this.PasswordStudentInfoLabel.AutoSize = true;
            this.PasswordStudentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordStudentInfoLabel.Location = new System.Drawing.Point(17, 235);
            this.PasswordStudentInfoLabel.Name = "PasswordStudentInfoLabel";
            this.PasswordStudentInfoLabel.Size = new System.Drawing.Size(84, 25);
            this.PasswordStudentInfoLabel.TabIndex = 7;
            this.PasswordStudentInfoLabel.Text = "*********";
            // 
            // ProfileStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(468, 418);
            this.Controls.Add(this.PasswordStudentInfoLabel);
            this.Controls.Add(this.PasswordStudentLabel);
            this.Controls.Add(this.EmaiStudentInfoLabel);
            this.Controls.Add(this.EmailStudentLabel);
            this.Controls.Add(this.NameStudentLabel);
            this.Controls.Add(this.NameStudentInfoLabel);
            this.Name = "ProfileStudentForm";
            this.Text = "Профиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameStudentInfoLabel;
        private System.Windows.Forms.Label NameStudentLabel;
        private System.Windows.Forms.Label EmailStudentLabel;
        private System.Windows.Forms.Label EmaiStudentInfoLabel;
        private System.Windows.Forms.Label PasswordStudentLabel;
        private System.Windows.Forms.Label PasswordStudentInfoLabel;
    }
}