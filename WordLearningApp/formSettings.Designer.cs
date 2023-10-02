namespace WordLearningApp
{
    partial class formSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSettings));
            this.cBReverse = new System.Windows.Forms.CheckBox();
            this.cBHideDefinitionTM = new System.Windows.Forms.CheckBox();
            this.cBHideContextTM = new System.Windows.Forms.CheckBox();
            this.cBHidePartOfSpeechTM = new System.Windows.Forms.CheckBox();
            this.cBHideIncorrectTM = new System.Windows.Forms.CheckBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBReverse
            // 
            this.cBReverse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBReverse.AutoSize = true;
            this.cBReverse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBReverse.Location = new System.Drawing.Point(13, 10);
            this.cBReverse.Name = "cBReverse";
            this.cBReverse.Size = new System.Drawing.Size(72, 20);
            this.cBReverse.TabIndex = 0;
            this.cBReverse.Text = "Reverse";
            this.cBReverse.UseVisualStyleBackColor = true;
            // 
            // cBHideDefinitionTM
            // 
            this.cBHideDefinitionTM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBHideDefinitionTM.AutoSize = true;
            this.cBHideDefinitionTM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBHideDefinitionTM.Location = new System.Drawing.Point(13, 33);
            this.cBHideDefinitionTM.Name = "cBHideDefinitionTM";
            this.cBHideDefinitionTM.Size = new System.Drawing.Size(208, 20);
            this.cBHideDefinitionTM.TabIndex = 1;
            this.cBHideDefinitionTM.Text = "Hide Definition in Training Mode";
            this.cBHideDefinitionTM.UseVisualStyleBackColor = true;
            // 
            // cBHideContextTM
            // 
            this.cBHideContextTM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBHideContextTM.AutoSize = true;
            this.cBHideContextTM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBHideContextTM.Location = new System.Drawing.Point(13, 56);
            this.cBHideContextTM.Name = "cBHideContextTM";
            this.cBHideContextTM.Size = new System.Drawing.Size(200, 20);
            this.cBHideContextTM.TabIndex = 2;
            this.cBHideContextTM.Text = "Hide Context in Training Mode";
            this.cBHideContextTM.UseVisualStyleBackColor = true;
            // 
            // cBHidePartOfSpeechTM
            // 
            this.cBHidePartOfSpeechTM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBHidePartOfSpeechTM.AutoSize = true;
            this.cBHidePartOfSpeechTM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBHidePartOfSpeechTM.Location = new System.Drawing.Point(13, 79);
            this.cBHidePartOfSpeechTM.Name = "cBHidePartOfSpeechTM";
            this.cBHidePartOfSpeechTM.Size = new System.Drawing.Size(244, 20);
            this.cBHidePartOfSpeechTM.TabIndex = 3;
            this.cBHidePartOfSpeechTM.Text = "Hide Part Of Speech in Training Mode";
            this.cBHidePartOfSpeechTM.UseVisualStyleBackColor = true;
            // 
            // cBHideIncorrectTM
            // 
            this.cBHideIncorrectTM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBHideIncorrectTM.AutoSize = true;
            this.cBHideIncorrectTM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBHideIncorrectTM.Location = new System.Drawing.Point(13, 102);
            this.cBHideIncorrectTM.Name = "cBHideIncorrectTM";
            this.cBHideIncorrectTM.Size = new System.Drawing.Size(249, 20);
            this.cBHideIncorrectTM.TabIndex = 5;
            this.cBHideIncorrectTM.Text = "Hide Correct answers in Training Mode";
            this.cBHideIncorrectTM.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSaveSettings.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSaveSettings.Location = new System.Drawing.Point(13, 137);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(249, 35);
            this.btnSaveSettings.TabIndex = 6;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 193);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.cBHideIncorrectTM);
            this.Controls.Add(this.cBHidePartOfSpeechTM);
            this.Controls.Add(this.cBHideContextTM);
            this.Controls.Add(this.cBHideDefinitionTM);
            this.Controls.Add(this.cBReverse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formSettings";
            this.Text = "Word Learning";
            this.Load += new System.EventHandler(this.formSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox cBReverse;
        public System.Windows.Forms.CheckBox cBHideDefinitionTM;
        public System.Windows.Forms.CheckBox cBHideContextTM;
        public System.Windows.Forms.CheckBox cBHidePartOfSpeechTM;
        public System.Windows.Forms.CheckBox cBHideIncorrectTM;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}