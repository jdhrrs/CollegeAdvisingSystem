namespace CISS311_Dropbox14
{
    partial class UpdateAdviseeName
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adviseeIdTextBox;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            currentNameLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            adviseeIdTextBox = new TextBox();
            newNameTextBox = new TextBox();
            findButton = new Button();
            updateButton = new Button();
            closeButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(currentNameLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(adviseeIdTextBox);
            groupBox1.Controls.Add(newNameTextBox);
            groupBox1.Controls.Add(findButton);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(closeButton);
            groupBox1.Location = new Point(18, 19);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(390, 383);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update Advisee Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Advisee ID";
            // 
            // currentNameLabel
            // 
            currentNameLabel.AutoSize = true;
            currentNameLabel.BorderStyle = BorderStyle.Fixed3D;
            currentNameLabel.Location = new Point(14, 121);
            currentNameLabel.Margin = new Padding(4, 0, 4, 0);
            currentNameLabel.Name = "currentNameLabel";
            currentNameLabel.Size = new Size(2, 23);
            currentNameLabel.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 95);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 2;
            label3.Text = "Current Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 176);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 3;
            label4.Text = "New Name";
            // 
            // adviseeIdTextBox
            // 
            adviseeIdTextBox.Location = new Point(117, 42);
            adviseeIdTextBox.Margin = new Padding(4, 5, 4, 5);
            adviseeIdTextBox.Name = "adviseeIdTextBox";
            adviseeIdTextBox.Size = new Size(148, 29);
            adviseeIdTextBox.TabIndex = 4;
            // 
            // newNameTextBox
            // 
            newNameTextBox.Enabled = false;
            newNameTextBox.Location = new Point(117, 171);
            newNameTextBox.Margin = new Padding(4, 5, 4, 5);
            newNameTextBox.Name = "newNameTextBox";
            newNameTextBox.Size = new Size(148, 29);
            newNameTextBox.TabIndex = 5;
            // 
            // findButton
            // 
            findButton.Location = new Point(276, 39);
            findButton.Margin = new Padding(4, 5, 4, 5);
            findButton.Name = "findButton";
            findButton.Size = new Size(86, 37);
            findButton.TabIndex = 6;
            findButton.Text = "&Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // updateButton
            // 
            updateButton.Enabled = false;
            updateButton.Location = new Point(117, 233);
            updateButton.Margin = new Padding(4, 5, 4, 5);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(112, 37);
            updateButton.TabIndex = 7;
            updateButton.Text = "&Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(238, 233);
            closeButton.Margin = new Padding(4, 5, 4, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 37);
            closeButton.TabIndex = 8;
            closeButton.Text = "C&lose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // UpdateAdviseeName
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 422);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UpdateAdviseeName";
            Text = "Update Advisee Name";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
    }
}
