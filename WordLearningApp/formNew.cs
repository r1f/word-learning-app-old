using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WordLearningApp
{
    public partial class formNew : Form
    {
        public string glossaryPath = formMain.glossaryName;
        public string[] glossary = File.ReadAllLines($"{formMain.glossaryName}");
        public formNew()
        {
            InitializeComponent();
            if (new FileInfo(glossaryPath).Length != 0)
            {
                numUpDown.Show();
                numUpDown.Minimum = 0;
                CheckGlossaryLength();

                var lineParts = glossary.First().Split('/');

                FillTextBoxes(lineParts);

                btnUpdate.Show();
            }
            else
            {
                btnUpdate.Hide();
                numUpDown.Hide();
                lblNumber.Hide();

                btnClear.Location = new Point(325, 290);
                btnClear.Size = new Size(228, 68);
                btnSave.Size = new Size(217, 68);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tBUntranslated.Text != "")
            {
                AddLineGlossary();
                ClearTextBoxes();
                CheckGlossaryLength();
            }
            else MessageBox.Show("Please enter untranslated word", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearTextBoxes()
        {
            tBUntranslated.Clear();
            tBTranslated.Clear();
            tBDefinition.Clear();
            tBContext.Clear();
            tBPartOfSpeech.Clear();
            numUpDown.ResetText();
        }
        private void FillTextBoxes(string[] line)
        {
            tBUntranslated.Text = line[0];
            tBTranslated.Text = line[1];
            tBDefinition.Text = line[2];
            tBContext.Text = line[3];
            tBPartOfSpeech.Text = line[4];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var lineParts = glossary.ElementAt(Convert.ToInt32(numUpDown.Value)).Split('/');
            FillTextBoxes(lineParts);
        }
        
        private void CheckGlossaryLength()
        {
            glossary = File.ReadAllLines($"{formMain.glossaryName}");
            numUpDown.Maximum = glossary.Length - 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditLineGlossary(Convert.ToInt32(numUpDown.Value));
            CheckGlossaryLength();
            ClearTextBoxes();
        }

        private void EditLineGlossary(int indexOfLine)
        {
            var line = $"{tBUntranslated.Text}/{tBTranslated.Text}/{tBDefinition.Text}/{tBContext.Text}/{tBPartOfSpeech.Text}";
            glossary[indexOfLine] = line; 
            File.WriteAllLines(glossaryPath, glossary);
        }

        private void AddLineGlossary()
        {
            var line = $"{tBUntranslated.Text}/{tBTranslated.Text}/{tBDefinition.Text}/{tBContext.Text}/{tBPartOfSpeech.Text}";
            File.AppendAllText(glossaryPath, line + Environment.NewLine);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
