// Justin Harris 
// CISS 311 Advanced Agile Software Development 
// Dropbox14
// Aug 6, 2024.

/*
 * This file defines the DeleteCourse form, which allows users to delete a course from the database.
 * The form includes a text box for entering the Course ID, labels to display the course title and instructor name,
 * a button to find the course details, a button to delete the course, and a button to close the form.
 * The form interacts with the TeachingDB database.
 */

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CISS311_Dropbox14
{
    public partial class DeleteCourse : Form
    {
        public DeleteCourse()
        {
            InitializeComponent();
        }

        // Event handler for the form load event
        private void DeleteCourse_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        // Event handler for the Find button click event
        private void findButton_Click(object sender, EventArgs e)
        {
            // Validate that the Course ID entered is an integer
            if (!int.TryParse(courseIdTextBox.Text, out int courseId))
            {
                MessageBox.Show("Please enter a valid integer Course ID.");
                return;
            }

            // Create and open a connection to the TeachingDB database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStringTeachingDB))
            {
                try
                {
                    // Define the SQL query to select the course name and instructor ID
                    string query = "SELECT courseName, instructorID FROM Course WHERE courseID = @courseID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@courseID", courseId);

                    // Open the connection and execute the query
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Check if a course was found
                    if (reader.Read())
                    {
                        // Display the course details and enable the delete button
                        courseTitleValueLabel.Text = reader["courseName"].ToString();
                        instructorNameValueLabel.Text = reader["instructorID"].ToString();
                        deleteButton.Enabled = true;
                    }
                    else
                    {
                        // Show a message if the course was not found and clear the form
                        MessageBox.Show("Course not found.");
                        courseTitleValueLabel.Text = string.Empty;
                        instructorNameValueLabel.Text = string.Empty;
                        deleteButton.Enabled = false;
                    }

                    // Close the reader
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs
                    MessageBox.Show("An error occurred while finding the course: " + ex.Message);
                }
            }
        }

        // Event handler for the Delete button click event
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Validate that the Course ID entered is an integer
            if (!int.TryParse(courseIdTextBox.Text, out int courseId))
            {
                MessageBox.Show("Please enter a valid integer Course ID.");
                return;
            }

            // Create and open a connection to the TeachingDB database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStringTeachingDB))
            {
                try
                {
                    // Define the SQL query to delete the course
                    string query = "DELETE FROM Course WHERE courseID = @courseID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@courseID", courseId);

                    // Open the connection and execute the query
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course deleted successfully.");

                    // Clear the form
                    courseIdTextBox.Text = string.Empty;
                    courseTitleValueLabel.Text = string.Empty;
                    instructorNameValueLabel.Text = string.Empty;
                    deleteButton.Enabled = false;
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs
                    MessageBox.Show("An error occurred while deleting the course: " + ex.Message);
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

