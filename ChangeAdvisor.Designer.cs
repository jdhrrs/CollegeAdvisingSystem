namespace CISS311_Dropbox14
{
    partial class ChangeAdvisor
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
            adviseeIdTextBox = new TextBox();
            newAdvisorComboBox = new ComboBox();
            findAdvisorButton = new Button();
            updateAdvisorButton = new Button();
            closeButton = new Button();
            label1 = new Label();
            label2 = new Label();
            adviseeNameLabel = new Label();
            label4 = new Label();
            currentAdvisorLabel = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // adviseeIdTextBox
            // 
            adviseeIdTextBox.Location = new Point(225, 48);
            adviseeIdTextBox.Margin = new Padding(4, 5, 4, 5);
            adviseeIdTextBox.Name = "adviseeIdTextBox";
            adviseeIdTextBox.Size = new Size(298, 29);
            adviseeIdTextBox.TabIndex = 0;
            // 
            // newAdvisorComboBox
            // 
            newAdvisorComboBox.FormattingEnabled = true;
            newAdvisorComboBox.Location = new Point(225, 242);
            newAdvisorComboBox.Margin = new Padding(4, 5, 4, 5);
            newAdvisorComboBox.Name = "newAdvisorComboBox";
            newAdvisorComboBox.Size = new Size(298, 29);
            newAdvisorComboBox.TabIndex = 1;
            // 
            // findAdvisorButton
            // 
            findAdvisorButton.Location = new Point(555, 48);
            findAdvisorButton.Margin = new Padding(4, 5, 4, 5);
            findAdvisorButton.Name = "findAdvisorButton";
            findAdvisorButton.Size = new Size(112, 37);
            findAdvisorButton.TabIndex = 2;
            findAdvisorButton.Text = "Find Advisee";
            findAdvisorButton.UseVisualStyleBackColor = true;
            findAdvisorButton.Click += findAdvisorButton_Click;
            // 
            // updateAdvisorButton
            // 
            updateAdvisorButton.Location = new Point(225, 323);
            updateAdvisorButton.Margin = new Padding(4, 5, 4, 5);
            updateAdvisorButton.Name = "updateAdvisorButton";
            updateAdvisorButton.Size = new Size(150, 37);
            updateAdvisorButton.TabIndex = 3;
            updateAdvisorButton.Text = "Update Advisor";
            updateAdvisorButton.UseVisualStyleBackColor = true;
            updateAdvisorButton.Click += updateAdvisorButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(412, 323);
            closeButton.Margin = new Padding(4, 5, 4, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 37);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 5;
            label1.Text = "Advisee ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 6;
            label2.Text = "Advisee Name:";
            // 
            // adviseeNameLabel
            // 
            adviseeNameLabel.AutoSize = true;
            adviseeNameLabel.BorderStyle = BorderStyle.Fixed3D;
            adviseeNameLabel.Location = new Point(225, 118);
            adviseeNameLabel.Margin = new Padding(4, 0, 4, 0);
            adviseeNameLabel.Name = "adviseeNameLabel";
            adviseeNameLabel.Size = new Size(2, 23);
            adviseeNameLabel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 183);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 8;
            label4.Text = "Current Advisor:";
            // 
            // currentAdvisorLabel
            // 
            currentAdvisorLabel.AutoSize = true;
            currentAdvisorLabel.BorderStyle = BorderStyle.Fixed3D;
            currentAdvisorLabel.Location = new Point(225, 183);
            currentAdvisorLabel.Margin = new Padding(4, 0, 4, 0);
            currentAdvisorLabel.Name = "currentAdvisorLabel";
            currentAdvisorLabel.Size = new Size(2, 23);
            currentAdvisorLabel.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 247);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 21);
            label6.TabIndex = 10;
            label6.Text = "Select Advisor:";
            // 
            // ChangeAdvisor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(726, 422);
            Controls.Add(label6);
            Controls.Add(currentAdvisorLabel);
            Controls.Add(label4);
            Controls.Add(adviseeNameLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closeButton);
            Controls.Add(updateAdvisorButton);
            Controls.Add(findAdvisorButton);
            Controls.Add(newAdvisorComboBox);
            Controls.Add(adviseeIdTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChangeAdvisor";
            Text = "Change Advisor";
            Load += ChangeAdvisor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox adviseeIdTextBox;
        private System.Windows.Forms.ComboBox newAdvisorComboBox;
        private System.Windows.Forms.Button findAdvisorButton;
        private System.Windows.Forms.Button updateAdvisorButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adviseeNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentAdvisorLabel;
        private System.Windows.Forms.Label label6;
    }
}
