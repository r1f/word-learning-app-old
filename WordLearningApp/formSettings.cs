using System;
using System.Windows.Forms;

namespace WordLearningApp
{
    public partial class formSettings : Form
    {
        public formSettings()
        {
            InitializeComponent();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.cBReverse = cBReverse.Checked;
            Properties.Settings.Default.cBHideDefinitionTM = cBHideDefinitionTM.Checked;
            Properties.Settings.Default.cBHideContextTM = cBHideContextTM.Checked;
            Properties.Settings.Default.cBHidePartOfSpeechTM = cBHidePartOfSpeechTM.Checked;
            Properties.Settings.Default.cBHideIncorrectTM = cBHideIncorrectTM.Checked;
            Properties.Settings.Default.Save();
            Close();
        }

        private void formSettings_Load(object sender, EventArgs e)
        {
            cBReverse.Checked = Properties.Settings.Default.cBReverse;
            cBHideDefinitionTM.Checked = Properties.Settings.Default.cBHideDefinitionTM;
            cBHideContextTM.Checked = Properties.Settings.Default.cBHideContextTM;
            cBHidePartOfSpeechTM.Checked = Properties.Settings.Default.cBHidePartOfSpeechTM;
            cBHideIncorrectTM.Checked = Properties.Settings.Default.cBHideIncorrectTM;
        }
    }
}
