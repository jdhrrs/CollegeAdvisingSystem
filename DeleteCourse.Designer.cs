namespace CISS311_Dropbox14
{
    partial class DeleteCourse
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            courseIdTextBox = new TextBox();
            courseIdLabel = new Label();
            courseTitleLabel = new Label();
            courseTitleValueLabel = new Label();
            instructorNameLabel = new Label();
            instructorNameValueLabel = new Label();
            findButton = new Button();
            deleteButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // courseIdTextBox
            // 
            courseIdTextBox.Location = new Point(149, 20);
            courseIdTextBox.Name = "courseIdTextBox";
            courseIdTextBox.Size = new Size(100, 29);
            courseIdTextBox.TabIndex = 0;
            // 
            // courseIdLabel
            // 
            courseIdLabel.AutoSize = true;
            courseIdLabel.Location = new Point(20, 23);
            courseIdLabel.Name = "courseIdLabel";
            courseIdLabel.Size = new Size(78, 21);
            courseIdLabel.TabIndex = 1;
            courseIdLabel.Text = "Course ID";
            // 
            // courseTitleLabel
            // 
            courseTitleLabel.AutoSize = true;
            courseTitleLabel.Location = new Point(20, 60);
            courseTitleLabel.Name = "courseTitleLabel";
            courseTitleLabel.Size = new Size(92, 21);
            courseTitleLabel.TabIndex = 2;
            courseTitleLabel.Text = "Course Title";
            // 
            // courseTitleValueLabel
            // 
            courseTitleValueLabel.BorderStyle = BorderStyle.Fixed3D;
            courseTitleValueLabel.Location = new Point(149, 61);
            courseTitleValueLabel.Name = "courseTitleValueLabel";
            courseTitleValueLabel.Size = new Size(200, 20);
            courseTitleValueLabel.TabIndex = 3;
            // 
            // instructorNameLabel
            // 
            instructorNameLabel.AutoSize = true;
            instructorNameLabel.Location = new Point(20, 100);
            instructorNameLabel.Name = "instructorNameLabel";
            instructorNameLabel.Size = new Size(123, 21);
            instructorNameLabel.TabIndex = 4;
            instructorNameLabel.Text = "Instructor Name";
            // 
            // instructorNameValueLabel
            // 
            instructorNameValueLabel.BorderStyle = BorderStyle.Fixed3D;
            instructorNameValueLabel.Location = new Point(149, 99);
            instructorNameValueLabel.Name = "instructorNameValueLabel";
            instructorNameValueLabel.Size = new Size(200, 20);
            instructorNameValueLabel.TabIndex = 5;
            // 
            // findButton
            // 
            findButton.Location = new Point(372, 20);
            findButton.Name = "findButton";
            findButton.Size = new Size(84, 29);
            findButton.TabIndex = 6;
            findButton.Text = "&Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Enabled = false;
            deleteButton.Location = new Point(60, 140);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(83, 44);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "&Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(180, 140);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(82, 44);
            closeButton.TabIndex = 8;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // DeleteCourse
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(515, 499);
            Controls.Add(closeButton);
            Controls.Add(deleteButton);
            Controls.Add(findButton);
            Controls.Add(instructorNameValueLabel);
            Controls.Add(instructorNameLabel);
            Controls.Add(courseTitleValueLabel);
            Controls.Add(courseTitleLabel);
            Controls.Add(courseIdLabel);
            Controls.Add(courseIdTextBox);
            Name = "DeleteCourse";
            Text = "Delete Course";
            Load += DeleteCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.Label courseIdLabel;
        private System.Windows.Forms.Label courseTitleLabel;
        private System.Windows.Forms.Label courseTitleValueLabel;
        private System.Windows.Forms.Label instructorNameLabel;
        private System.Windows.Forms.Label instructorNameValueLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
    }
}
