using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CISS311_Dropbox14
{
    public partial class UpdateAdvisor : Form
    {
        private SqlDataAdapter adapter;
        private DataTable advisorTable;

        public UpdateAdvisor()
        {
            InitializeComponent();
            advisorTable = new DataTable();
        }

        // Event handler for the form load event
        private void UpdateAdvisor_Load(object sender, EventArgs e)
        {
            // Initialize the SQL connection using the connection string from the settings
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStringAdvisingDB))
            {
                try
                {
                    // SQL query to select all advisors
                    adapter = new SqlDataAdapter("SELECT * FROM Advisor", conn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    // Fill a DataTable with the result of the query
                    advisorTable = new DataTable();
                    adapter.Fill(advisorTable);

                    // Bind the DataTable to the DataGridView
                    advisorDataGridView.DataSource = advisorTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading advisor data: " + ex.Message);
                }
            }
        }

        private void advisorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStringAdvisingDB))
            {
                try
                {
                    adapter = new SqlDataAdapter("SELECT * FROM Advisor", conn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    // Fill a DataTable with the result of the query
                    advisorTable = new DataTable();
                    adapter.Fill(advisorTable);

                    // Bind the DataTable to the DataGridView
                    advisorDataGridView.DataSource = advisorTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading advisor data: " + ex.Message);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {    // Logic for the UpdateButton
            adapter.Update(advisorTable);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
