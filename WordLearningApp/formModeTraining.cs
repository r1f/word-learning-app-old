using System;
using System.Linq;
using System.Windows.Forms;

namespace WordLearningApp
{
    public partial class formModeTraining : Form
    {
        public static string[] glossary;
        public string[] lineParts;

        public int unTranslatedIndex = 0;
        public int translatedIndex = 1;
        public int definitionIndex = 2;
        public int contextIndex = 3;
        public int partOfSpeechIndex = 4;

        public formModeTraining()
        {
            InitializeComponent();
            SetSettings();
            glossary = System.IO.File.ReadAllLines($"{formMain.glossaryName}");
            Training(unTranslatedIndex);
        }

        private void Training(int unTranslatedIndex)
        {
            Random random = new Random();
            var index = random.Next(glossary.Length);
            var line = glossary.ElementAt(index);
            lineParts = line.Split('/');

            tBUntranslated.Text = lineParts[unTranslatedIndex];
            lblDefinition.Text = lineParts[definitionIndex];
            lblContext.Text = lineParts[contextIndex];
            lblPartOfSpeech.Text = lineParts[partOfSpeechIndex];
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            IsCorrect(unTranslatedIndex, translatedIndex);
            tBTranslate.Clear();
            Training(unTranslatedIndex);
        }

        private bool IsCorrect(int unTranslatedIndex, int translatedIndex)
        {
            int.TryParse(lblScore.Text, out var score);
            if (tBTranslate.Text == lineParts[translatedIndex])
            {
                score += 5;
                lblScore.Text = score.ToString();
                lblScore.ForeColor = System.Drawing.Color.Green;
                lblIncorrect.Text = "";
                return true;
            }
            else
            {
                lblIncorrect.Text = $"{lineParts[translatedIndex]}";
                lblIncorrect.ForeColor = System.Drawing.Color.Red;
                score -= 5;
                lblScore.Text = score.ToString();
                lblScore.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }

        private void SetSettings()
        {
            if (Properties.Settings.Default.cBReverse) Reverse();

            if (Properties.Settings.Default.cBHideDefinitionTM) HideLabelPair(lblDefinitionName, lblDefinition);
            else ShowLabelPair(lblDefinitionName, lblDefinition);

            if (Properties.Settings.Default.cBHideContextTM) HideLabelPair(lblContextName, lblContext);
            else ShowLabelPair(lblContextName, lblContext);

            if (Properties.Settings.Default.cBHidePartOfSpeechTM) HideLabelPair(lblPartOfSpeechName, lblPartOfSpeech);
            else ShowLabelPair(lblPartOfSpeechName, lblPartOfSpeech);

            if (Properties.Settings.Default.cBHideIncorrectTM) lblIncorrect.Hide();
            else lblIncorrect.Show();
        }

        private void Reverse()
        {
            unTranslatedIndex = 1;
            translatedIndex = 0;
        }

        private void HideLabelPair(Label labelName, Label changingLabel)
        {
            labelName.Hide();
            changingLabel.Hide();
        }

        private void ShowLabelPair(Label labelName, Label changingLabel)
        {
            labelName.Show();
            changingLabel.Show();
        }
    }
}
