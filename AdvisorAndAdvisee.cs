// Justin Harris 
// CISS 311 Advanced Agile Software Development 
// Dropbox14
// Aug 6, 2024.

/*
 * This file defines the AdvisorAndAdvisee form, which allows users to select an advisor from a ComboBox 
 * and view the associated advisees in a ListBox. The form also includes functionality to load data from 
 * a database and a close button to exit the form.
 */

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CISS311_Dropbox14
{
    public partial class AdvisorAndAdvisee : Form
    {
        // Connection string to connect to the advising database
        private string connString = CISS311_Dropbox14.Properties.Settings.Default.connStringAdvisingDB;

        public AdvisorAndAdvisee()
        {
            InitializeComponent();
        }

        // Event handler for the form load event
        private void AdvisorAndAdvisee_Load(object sender, EventArgs e)
        {
            // Load advisor data into the ComboBox when the form loads
            LoadAdvisorComboBox();
        }

        // Method to load advisor data from the database into the ComboBox
        private void LoadAdvisorComboBox()
        {
            // Establish a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                // SQL query to select all advisors
                string query = "SELECT * FROM Advisor"; // Ensure the table name and columns are correct
                // Data adapter to execute the query and fill the DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable advisorTable = new DataTable();
                adapter.Fill(advisorTable);

                // Set the display and value members for the ComboBox
                advisorComboBox.DisplayMember = "advisorName";
                advisorComboBox.ValueMember = "advisorId";
                advisorComboBox.DataSource = advisorTable;
            }
        }

        // Event handler for the Save button click event
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Establish a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                // SQL command to insert a new advisee into the database
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Advisee (adviseeName, advisorId) VALUES (@adviseeName, @advisorId)", conn))
                {
                    // Add parameters for the SQL command
                    cmd.Parameters.AddWithValue("@adviseeName", adviseeNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@advisorId", advisorComboBox.SelectedValue);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    // Show a message indicating the advisee was saved
                    MessageBox.Show("Advisee saved.");
                }
            }
        }

        // Event handler for the Close button click event
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
