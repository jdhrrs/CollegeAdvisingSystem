namespace CISS311_Dropbox14
{
    partial class UpdateAdvisor
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
            advisorDataGridView = new DataGridView();
            updateButton = new Button();
            closeButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advisorDataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(advisorDataGridView);
            groupBox1.Location = new Point(18, 19);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1140, 646);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Advisor data";
            // 
            // advisorDataGridView
            // 
            advisorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advisorDataGridView.Location = new Point(9, 31);
            advisorDataGridView.Margin = new Padding(4, 5, 4, 5);
            advisorDataGridView.Name = "advisorDataGridView";
            advisorDataGridView.Size = new Size(1122, 606);
            advisorDataGridView.TabIndex = 0;
            advisorDataGridView.CellContentClick += advisorDataGridView_CellContentClick;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(924, 675);
            updateButton.Margin = new Padding(4, 5, 4, 5);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(112, 37);
            updateButton.TabIndex = 1;
            updateButton.Text = "&Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(1046, 675);
            closeButton.Margin = new Padding(4, 5, 4, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 37);
            closeButton.TabIndex = 2;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // UpdateAdvisor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1176, 745);
            Controls.Add(closeButton);
            Controls.Add(updateButton);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UpdateAdvisor";
            Text = "Update Advisor";
            Load += UpdateAdvisor_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)advisorDataGridView).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView advisorDataGridView;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
    }
}
