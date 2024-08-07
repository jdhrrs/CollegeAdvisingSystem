using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CISS311_Dropbox14.Properties;

namespace CISS311_Dropbox14
{
    public partial class UpdateAdviseeName : Form
    {
        public UpdateAdviseeName()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.connStringAdvisingDB))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT * FROM Advisee WHERE adviseeId = @adviseeId", conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@adviseeId", adviseeIdTextBox.Text);
                    DataTable adviseeTable = new DataTable();
                    adapter.Fill(adviseeTable);

                    if (adviseeTable.Rows.Count < 1)
                    {
                        currentNameLabel.Text = "No student found";
                        newNameTextBox.Enabled = false;
                        updateButton.Enabled = false;
                    }
                    else
                    {
                        DataRow dr = adviseeTable.Rows[0];
                        currentNameLabel.Text = dr["adviseeName"].ToString();
                        newNameTextBox.Enabled = true;
                        newNameTextBox.Focus();
                        updateButton.Enabled = true;
                    }
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStringAdvisingDB))
            {
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Advisee SET adviseeName = @adviseeName WHERE adviseeId = @adviseeId", conn))
                {
                    cmd.Parameters.AddWithValue("@adviseeName", newNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@adviseeId", adviseeIdTextBox.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisee updated.");
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
