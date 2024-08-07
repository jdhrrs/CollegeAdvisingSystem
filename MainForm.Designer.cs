namespace CISS311_Dropbox14
{
    partial class MainForm
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
            addAdviseeButton = new Button();
            addCourseButton = new Button();
            updateAdviseeButton = new Button();
            changeAdvisorButton = new Button();
            updateAdvisorButton = new Button();
            deleteCourseButton = new Button();
            closeButton = new Button();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // addAdviseeButton
            // 
            addAdviseeButton.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addAdviseeButton.Location = new Point(124, 81);
            addAdviseeButton.Name = "addAdviseeButton";
            addAdviseeButton.Size = new Size(128, 88);
            addAdviseeButton.TabIndex = 0;
            addAdviseeButton.Text = "Add Advisee";
            addAdviseeButton.UseVisualStyleBackColor = true;
            addAdviseeButton.Click += addAdviseeButton_Click;
            // 
            // addCourseButton
            // 
            addCourseButton.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCourseButton.Location = new Point(335, 81);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(141, 88);
            addCourseButton.TabIndex = 1;
            addCourseButton.Text = "Add Course";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // updateAdviseeButton
            // 
            updateAdviseeButton.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateAdviseeButton.Location = new Point(563, 81);
            updateAdviseeButton.Name = "updateAdviseeButton";
            updateAdviseeButton.Size = new Size(130, 88);
            updateAdviseeButton.TabIndex = 3;
            updateAdviseeButton.Text = "Update Advisee";
            updateAdviseeButton.UseVisualStyleBackColor = true;
            updateAdviseeButton.Click += updateAdviseeButton_Click;
            // 
            // changeAdvisorButton
            // 
            changeAdvisorButton.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeAdvisorButton.Location = new Point(243, 229);
            changeAdvisorButton.Name = "changeAdvisorButton";
            changeAdvisorButton.Size = new Size(149, 102);
            changeAdvisorButton.TabIndex = 4;
            changeAdvisorButton.Text = "Change Advisor";
            changeAdvisorButton.UseVisualStyleBackColor = true;
            changeAdvisorButton.Click += changeAdvisorButton_Click;
            // 
            // updateAdvisorButton
            // 
            updateAdvisorButton.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateAdvisorButton.Location = new Point(25, 229);
            updateAdvisorButton.Name = "updateAdvisorButton";
            updateAdvisorButton.Size = new Size(148, 102);
            updateAdvisorButton.TabIndex = 5;
            updateAdvisorButton.Text = "Update Advisor";
            updateAdvisorButton.UseVisualStyleBackColor = true;
            updateAdvisorButton.Click += updateAdvisorButton_Click;
            // 
            // deleteCourseButton
            // 
            deleteCourseButton.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteCourseButton.Location = new Point(450, 229);
            deleteCourseButton.Name = "deleteCourseButton";
            deleteCourseButton.Size = new Size(144, 102);
            deleteCourseButton.TabIndex = 6;
            deleteCourseButton.Text = "Delete Course";
            deleteCourseButton.UseVisualStyleBackColor = true;
            deleteCourseButton.Click += deleteCourseButton_Click;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(643, 229);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(138, 102);
            closeButton.TabIndex = 7;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Modern No. 20", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.LightCyan;
            titleLabel.Location = new Point(284, 18);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(242, 34);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "Advising System";
            // 
            // MainForm
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(793, 450);
            Controls.Add(titleLabel);
            Controls.Add(deleteCourseButton);
            Controls.Add(updateAdvisorButton);
            Controls.Add(changeAdvisorButton);
            Controls.Add(updateAdviseeButton);
            Controls.Add(addAdviseeButton);
            Controls.Add(addCourseButton);
            Controls.Add(closeButton);
            Name = "MainForm";
            Text = "Welcome To The Advising System";
            Load += MainForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button addAdviseeButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button advisorAndAdviseeButton;
        private System.Windows.Forms.Button updateAdviseeButton;
        private System.Windows.Forms.Button changeAdvisorButton;
        private System.Windows.Forms.Button updateAdvisorButton;
        private System.Windows.Forms.Button deleteCourseButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel; // Add this line for the label definition
    }
}
