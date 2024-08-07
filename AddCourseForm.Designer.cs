namespace CISS311_Dropbox14
{
    partial class AddCourseForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseNameTextBox; // Ensure this control is defined
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox instructorComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;

        // Method to initialize the controls
        private void InitializeComponent()
        {
            label1 = new Label();
            courseIdTextBox = new TextBox();
            label2 = new Label();
            courseNameTextBox = new TextBox();
            label3 = new Label();
            instructorComboBox = new ComboBox();
            saveButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Course ID:";
            // 
            // courseIdTextBox
            // 
            courseIdTextBox.Location = new Point(116, 12);
            courseIdTextBox.Name = "courseIdTextBox";
            courseIdTextBox.Size = new Size(100, 29);
            courseIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 2;
            label2.Text = "Course Name:";
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.Location = new Point(116, 38);
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(100, 29);
            courseNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 4;
            label3.Text = "Instructor:";
            // 
            // instructorComboBox
            // 
            instructorComboBox.FormattingEnabled = true;
            instructorComboBox.Location = new Point(116, 67);
            instructorComboBox.Name = "instructorComboBox";
            instructorComboBox.Size = new Size(100, 29);
            instructorComboBox.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(26, 145);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(81, 45);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(166, 145);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(91, 45);
            closeButton.TabIndex = 7;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // AddCourseForm
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(284, 261);
            Controls.Add(closeButton);
            Controls.Add(saveButton);
            Controls.Add(instructorComboBox);
            Controls.Add(label3);
            Controls.Add(courseNameTextBox);
            Controls.Add(label2);
            Controls.Add(courseIdTextBox);
            Controls.Add(label1);
            Name = "AddCourseForm";
            Load += AddCourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
