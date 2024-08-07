// Justin Harris 
// CISS 311 Advanced Agile Software Development 
// Dropbox14
// Aug 6, 2024.

/*
 * This file defines the MainForm, which contains buttons to open various forms such as 
 * AdvisorAndAdvisee, AddCourseForm, UpdateAdviseeNameForm, ChangeAdvisor, and UpdateAdvisorForm.
 * The MainForm includes a label to display the title "Advising System".
 */

using System;
using System.Windows.Forms;

namespace CISS311_Dropbox14
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addAdviseeButton_Click(object sender, EventArgs e)
        {
            AdvisorAndAdvisee addAdviseeForm = new AdvisorAndAdvisee();
            addAdviseeForm.ShowDialog();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog();
        }

        private void advisorAndAdviseeButton_Click(object sender, EventArgs e)
        {
            AdvisorAndAdvisee advisorAndAdviseeForm = new AdvisorAndAdvisee();
            advisorAndAdviseeForm.ShowDialog();
        }

        private void updateAdviseeButton_Click(object sender, EventArgs e)
        {
            UpdateAdviseeName updateAdviseeName = new UpdateAdviseeName();
            updateAdviseeName.ShowDialog();
        }

        private void changeAdvisorButton_Click(object sender, EventArgs e)
        {
            ChangeAdvisor changeAdvisor = new ChangeAdvisor();
            changeAdvisor.ShowDialog();
        }

        private void updateAdvisorButton_Click(object sender, EventArgs e)
        {
            UpdateAdvisor updateAdvisorForm = new UpdateAdvisor();
            updateAdvisorForm.ShowDialog();
        }

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {
            DeleteCourse deleteCourseForm = new DeleteCourse();
            deleteCourseForm.ShowDialog();
        }

        // Event handler for the Close button click event
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            // Code to handle form load event, if any
        }
    }
}
