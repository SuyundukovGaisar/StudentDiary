namespace StudentDiary
{
    partial class ExamStudentForm
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
            this.ExamStudentGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ExamStudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExamStudentGridView
            // 
            this.ExamStudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamStudentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NameExam,
            this.Mark});
            this.ExamStudentGridView.Location = new System.Drawing.Point(13, 12);
            this.ExamStudentGridView.Name = "ExamStudentGridView";
            this.ExamStudentGridView.RowHeadersWidth = 51;
            this.ExamStudentGridView.RowTemplate.Height = 24;
            this.ExamStudentGridView.Size = new System.Drawing.Size(775, 426);
            this.ExamStudentGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // NameExam
            // 
            this.NameExam.HeaderText = "Название";
            this.NameExam.MinimumWidth = 6;
            this.NameExam.Name = "NameExam";
            this.NameExam.Width = 125;
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Оценка";
            this.Mark.MinimumWidth = 6;
            this.Mark.Name = "Mark";
            this.Mark.Width = 125;
            // 
            // ExamStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExamStudentGridView);
            this.Name = "ExamStudentForm";
            this.Text = "Экзамены";
            ((System.ComponentModel.ISupportInitialize)(this.ExamStudentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExamStudentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
    }
}