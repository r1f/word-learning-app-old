using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WordLearningApp
{
    public partial class formMain : Form
    {
        public static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string glossaryPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\tempGlossary";
        public static string glossaryName;

        public formMain()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = $"{desktopPath}\\tempGlossary";
            openFileDialog.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                var fileInfo = new FileInfo(openFileDialog.FileName);
                lblGlossaryPath.Text = fileInfo.Name;

                glossaryName = openFileDialog.FileName;
            }
            else
            {
                lblGlossaryPath.Text = "";
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblGlossaryPath.Text = "";
            try
            {
                if (!Directory.Exists($"{desktopPath}\\tempGlossary"))
                {
                    Directory.CreateDirectory(($"{desktopPath}\\tempGlossary"));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something goes wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var fileName = Interaction.InputBox("Enter a glossary name", "New Glossary", "Name");

            if (fileName != "" && fileName != "Name")
            {
                File.Create($"{glossaryPath}\\{fileName}.txt").Close();

                lblGlossaryPath.Text = $"{fileName}.txt";

                glossaryName = $"{glossaryPath}\\{fileName}.txt";

                var formNew = new formNew();
                formNew.Show();
            }
            else
            {
                MessageBox.Show("Please enter a correct name of the glossary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var trainingMode = new formModeTraining();
                trainingMode.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Create or Open a glossary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var testMode = new formModeTest();
                testMode.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Create or Open a glossary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var formNew = new formNew();
                formNew.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Create or Open a glossary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSettings = new formSettings();
            formSettings.Show();
        }
    }
}
