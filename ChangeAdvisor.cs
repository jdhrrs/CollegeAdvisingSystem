// ChangeAdvisor.cs
// Justin Harris 
// CISS 311 Advanced Agile Software Development 
// Dropbox14
// Aug 6, 2024

/*
 * This file defines the ChangeAdvisor form, which allows users to change the advisor 
 * for a specified advisee in the database. The form includes functionalities to:
 * 
 *  Load all available advisors into a ComboBox when the form is loaded.
 *  Find and display the current advisor and advisee information based on the entered advisee ID.
 *  Update the advisor for the specified advisee to a new advisor selected from the ComboBox.
 * 
 *  The form interacts with the database using SQL queries to fetch and update data.
 *  The following are the main components and functionalities:
 * 
 *  ChangeAdvisor_Load: Populates the newAdvisorComboBox with advisor names from the database.
 *  findAdvisorButton_Click: Finds and displays the current advisor and advisee information based on the advisee ID.
 *  updateAdvisorButton_Click: Updates the advisor for the specified advisee to the new advisor selected from the ComboBox.
 *  closeButton_Click: Closes the form.
 * 
 * The database connection is managed using the connection string defined in the project settings.
 */



using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CISS311_Dropbox14
{
    public partial class ChangeAdvisor : Form
    {
        // Constructor to initialize the form components
        public ChangeAdvisor()
        {
            InitializeComponent();
        }

        // Event handler for the form load event
        private void ChangeAdvisor_Load(object sender, EventArgs e)
        {
            // Fill newAdvisorComboBox with advisor names when the form loads
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStringAdvisingDB))
            {
                // SQL query to select all advisors
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Advisor", conn))
                {
                    // Fill a DataTable with the result of the query
                    DataTable advisorTable = new DataTable();
                    adapter.Fill(advisorTable);

                    // Bind the DataTable to the ComboBox
                    newAdvisorComboBox.DisplayMember = "advisorName";
                    newAdvisorComboBox.ValueMember = "advisorId";
                    newAdvisorComboBox.DataSource = advisorTable;
                }
            }
        }

        // Event handler for the find advisor button click event
        private void findAdvisorButton_Click(object sender, EventArgs e)
        {
            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStringAdvisingDB))
            {
                // SQL query to select advisee and their current advisor by adviseeId
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT Advisee.adviseeName, Advisor.advisorName AS currentAdvisor FROM Advisee " +
                    "JOIN Advisor ON Advisee.AdvisorID = Advisor.AdvisorId WHERE Advisee.adviseeId = @adviseeId", conn))
                {
                    // Add parameter to the query
                    adapter.SelectCommand.Parameters.AddWithValue("@adviseeId", adviseeIdTextBox.Text);

                    // Fill a DataTable with the result of the query
                    DataTable adviseeTable = new DataTable();
                    adapter.Fill(adviseeTable);

                    // Check if any rows were returned
                    if (adviseeTable.Rows.Count < 1)
                    {
                        // No advisee found, update the UI accordingly
                        adviseeNameLabel.Text = "Advisee not found";
                        currentAdvisorLabel.Text = "N/A";
                        newAdvisorComboBox.Enabled = false;
                        updateAdvisorButton.Enabled = false;
                    }
                    else
                    {
                        // Advisee found, update the UI with the advisee's information
                        DataRow dr = adviseeTable.Rows[0];
                        adviseeNameLabel.Text = dr["adviseeName"].ToString();
                        currentAdvisorLabel.Text = dr["currentAdvisor"].ToString();
                        newAdvisorComboBox.Enabled = true;
                        updateAdvisorButton.Enabled = true;
                    }
                }
            }
        }

        // Event handler for the update advisor button click event
        private void updateAdvisorButton_Click(object sender, EventArgs e)
        {
            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStringAdvisingDB))
            {
                // SQL command to update the advisorId for the selected advisee
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Advisee SET AdvisorID = @newAdvisorId WHERE adviseeId = @adviseeId", conn))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@newAdvisorId", newAdvisorComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@adviseeId", adviseeIdTextBox.Text);

                    // Open the connection and execute the command
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Show a confirmation message
                    MessageBox.Show("Advisor updated.");
                }
            }
        }

        // Event handler for the close button click event
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}

