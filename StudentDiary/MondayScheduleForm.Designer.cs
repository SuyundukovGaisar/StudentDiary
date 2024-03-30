namespace StudentDiary
{
    partial class MondayScheduleForm
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
            this.MondayScheduleGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_of_lesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MondayScheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MondayScheduleGridView
            // 
            this.MondayScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MondayScheduleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Subject,
            this.Teacher,
            this.Group,
            this.Type_of_lesson,
            this.Start_time,
            this.End_time});
            this.MondayScheduleGridView.Location = new System.Drawing.Point(12, 12);
            this.MondayScheduleGridView.Name = "MondayScheduleGridView";
            this.MondayScheduleGridView.RowHeadersWidth = 51;
            this.MondayScheduleGridView.RowTemplate.Height = 24;
            this.MondayScheduleGridView.Size = new System.Drawing.Size(776, 426);
            this.MondayScheduleGridView.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Предмет";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.Width = 125;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Преподователь";
            this.Teacher.MinimumWidth = 6;
            this.Teacher.Name = "Teacher";
            this.Teacher.Width = 125;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.MinimumWidth = 6;
            this.Group.Name = "Group";
            this.Group.Width = 125;
            // 
            // Type_of_lesson
            // 
            this.Type_of_lesson.HeaderText = "Тип занятия";
            this.Type_of_lesson.MinimumWidth = 6;
            this.Type_of_lesson.Name = "Type_of_lesson";
            this.Type_of_lesson.Width = 125;
            // 
            // Start_time
            // 
            this.Start_time.HeaderText = "Начало";
            this.Start_time.MinimumWidth = 6;
            this.Start_time.Name = "Start_time";
            this.Start_time.Width = 125;
            // 
            // End_time
            // 
            this.End_time.HeaderText = "Конец";
            this.End_time.MinimumWidth = 6;
            this.End_time.Name = "End_time";
            this.End_time.Width = 125;
            // 
            // MondayScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MondayScheduleGridView);
            this.Name = "MondayScheduleForm";
            this.Text = "Понедельник";
            ((System.ComponentModel.ISupportInitialize)(this.MondayScheduleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MondayScheduleGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_of_lesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_time;
    }
}