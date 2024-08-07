namespace CISS311_Dropbox14
{
    partial class AdvisorAndAdvisee
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
            groupBox1 = new GroupBox();
            closeButton = new Button();
            saveButton = new Button();
            advisorComboBox = new ComboBox();
            adviseeNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(closeButton);
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(advisorComboBox);
            groupBox1.Controls.Add(adviseeNameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Advisee";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(255, 110);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 34);
            closeButton.TabIndex = 5;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(130, 110);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 34);
            saveButton.TabIndex = 4;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // advisorComboBox
            // 
            advisorComboBox.FormattingEnabled = true;
            advisorComboBox.Location = new Point(130, 70);
            advisorComboBox.Name = "advisorComboBox";
            advisorComboBox.Size = new Size(200, 29);
            advisorComboBox.TabIndex = 1;
            // 
            // adviseeNameTextBox
            // 
            adviseeNameTextBox.Location = new Point(130, 30);
            adviseeNameTextBox.Name = "adviseeNameTextBox";
            adviseeNameTextBox.Size = new Size(200, 29);
            adviseeNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 73);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 3;
            label2.Text = "Select Advisor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 2;
            label1.Text = "Advisee Name";
            // 
            // AdvisorAndAdvisee
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(384, 181);
            Controls.Add(groupBox1);
            Name = "AdvisorAndAdvisee";
            Text = "Advisor and Advisee";
            Load += AdvisorAndAdvisee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox adviseeNameTextBox;
        private System.Windows.Forms.ComboBox advisorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
    }
}
