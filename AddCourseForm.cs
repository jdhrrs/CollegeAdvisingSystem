// Justin Harris 
// CISS 311 Advanced Agile Software Development 
// Dropbox14
// Aug, 6, 2024.

/*
 * This file defines the AddCourseForm, which allows users to add new courses to the database.
 * The form includes a ComboBox to select an instructor and a TextBox to enter the course name.
 * It also contains functionality to save the course data to the database and a close button to exit the form.
 */

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CISS311_Dropbox14
{
    public partial class AddCourseForm : Form
    {
        // Connection string to connect to the teaching database
        private string connString = CISS311_Dropbox14.Properties.Settings.Default.connStringTeachingDB;

        public AddCourseForm()
        {
            InitializeComponent();
        }

        // Event handler for the form load event
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Load instructor data into the ComboBox when the form loads
                LoadInstructorComboBox();
            }
            catch (Exception ex)
            {
                // Show an error message if there is an issue loading the instructors
                MessageBox.Show($"Error loading instructors: {ex.Message}");
            }
        }

        // Method to load instructor data from the database into the ComboBox
        private void LoadInstructorComboBox()
        {
            // Establish a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                // SQL query to select instructor ID and name
                string query = "SELECT instructorID, instructorName FROM dbo.Instructor";
                // Data adapter to execute the query and fill the DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable instructorTable = new DataTable();
                adapter.Fill(instructorTable);

                // Set the display and value members for the ComboBox
                instructorComboBox.DisplayMember = "instructorName";
                instructorComboBox.ValueMember = "instructorID";
                instructorComboBox.DataSource = instructorTable;
            }
        }

        // Event handler for the Save button click event
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Establish a connection to the database
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    // SQL command to insert a new course into the database
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Course (courseName, instructorID) VALUES (@courseName, @instructorID)", conn))
                    {
                        // Add parameters for the SQL command
                        cmd.Parameters.AddWithValue("@courseName", courseNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@instructorID", instructorComboBox.SelectedValue);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                        // Show a message indicating the course was saved
                        MessageBox.Show("Course saved.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if there is an issue saving the course
                MessageBox.Show($"Error saving course: {ex.Message}");
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
