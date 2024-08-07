// Justin Harris 
// CISS 311 Advanced Agile Software Development 
// Dropbox14
// Aug 6, 2024.

/*
 * This file defines the entry point of the application. It configures the application to use visual styles,
 * sets the text rendering to be compatible, and runs the MainForm.
 */

using System;
using System.Windows.Forms;

namespace CISS311_Dropbox14
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();
            // Set text rendering to be compatible with the current settings
            Application.SetCompatibleTextRenderingDefault(false);
            // Run the MainForm of the application
            Application.Run(new MainForm());
        }
    }
}
