using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WordLearningApp
{
    public partial class formModeTest : Form
    {
        public List<int> order = new List<int>();
        public int index = 0;
        public string[] lineParts;

        public List<string> incorrectAnswers = new List<string>();

        public int unTranslatedIndex = 0;
        public int translatedIndex = 1;

        public formModeTest()
        {
            InitializeComponent();
            SetSettings();

            glossary = System.IO.File.ReadAllLines($"{formMain.glossaryName}");

            lblIncorrectCounter.Text = glossary.Length.ToString();
            lblCorrectCounter.Text = "1";
            
            Order();
            Test(unTranslatedIndex);
        }

        private void Test(int unTranslatedIndex)
        {
            var line = glossary.ElementAt(order[index]);
            lineParts = line.Split('/');
            tBUntranslated.Text = lineParts[unTranslatedIndex];
            if (index < glossary.Length) index++;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                IsCorrect(translatedIndex);
                tBTranslate.Clear();
                Test(unTranslatedIndex);
            }
            catch (Exception)
            {
                var message = String.Join(Environment.NewLine, incorrectAnswers);
                MessageBox.Show(message, "Result",MessageBoxButtons.OK);
                Close();
            }
        }

        private bool IsCorrect(int translatedIndex)
        {
            int.TryParse(lblCorrectCounter.Text, out var count);
            if (count < glossary.Length) count++;
            lblCorrectCounter.Text = count.ToString();
            if (tBTranslate.Text == lineParts[translatedIndex])
            {
                return true;
            }
            else
            {
                incorrectAnswers.Add($"Should be: {lineParts[translatedIndex]}\nYour answer: {tBTranslate.Text}\n");
                return false;
            }
        }

        private List<int> Order()
        {
            var rnd = new Random();
            order = Enumerable.Range(0, glossary.Length).OrderBy(x => rnd.Next()).Take(glossary.Length).ToList();
            return order;
        }

        private void SetSettings()
        {
            if (Properties.Settings.Default.cBReverse) Reverse();
        }

        private void Reverse()
        {
            unTranslatedIndex = 1;
            translatedIndex = 0;
        }
    }
}
