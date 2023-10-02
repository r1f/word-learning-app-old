namespace WordLearningApp
{
    partial class formModeTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formModeTraining));
            this.tBUntranslated = new System.Windows.Forms.TextBox();
            this.tBTranslate = new System.Windows.Forms.TextBox();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.lblContext = new System.Windows.Forms.Label();
            this.lblPartOfSpeech = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblDefinitionName = new System.Windows.Forms.Label();
            this.lblContextName = new System.Windows.Forms.Label();
            this.lblPartOfSpeechName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBUntranslated
            // 
            this.tBUntranslated.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBUntranslated.Font = new System.Drawing.Font("Arial", 14F);
            this.tBUntranslated.Location = new System.Drawing.Point(160, 107);
            this.tBUntranslated.Margin = new System.Windows.Forms.Padding(10);
            this.tBUntranslated.MaxLength = 300;
            this.tBUntranslated.Multiline = true;
            this.tBUntranslated.Name = "tBUntranslated";
            this.tBUntranslated.ReadOnly = true;
            this.tBUntranslated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBUntranslated.Size = new System.Drawing.Size(250, 76);
            this.tBUntranslated.TabIndex = 0;
            // 
            // tBTranslate
            // 
            this.tBTranslate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBTranslate.Font = new System.Drawing.Font("Arial", 18F);
            this.tBTranslate.Location = new System.Drawing.Point(450, 107);
            this.tBTranslate.Margin = new System.Windows.Forms.Padding(10);
            this.tBTranslate.MaxLength = 100;
            this.tBTranslate.Name = "tBTranslate";
            this.tBTranslate.Size = new System.Drawing.Size(250, 35);
            this.tBTranslate.TabIndex = 1;
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIncorrect.Location = new System.Drawing.Point(450, 148);
            this.lblIncorrect.Margin = new System.Windows.Forms.Padding(10);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(0, 18);
            this.lblIncorrect.TabIndex = 4;
            // 
            // lblDefinition
            // 
            this.lblDefinition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDefinition.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDefinition.Location = new System.Drawing.Point(123, 200);
            this.lblDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(0, 18);
            this.lblDefinition.TabIndex = 5;
            // 
            // lblContext
            // 
            this.lblContext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContext.AutoSize = true;
            this.lblContext.Font = new System.Drawing.Font("Arial", 12F);
            this.lblContext.Location = new System.Drawing.Point(110, 243);
            this.lblContext.Margin = new System.Windows.Forms.Padding(0);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(0, 18);
            this.lblContext.TabIndex = 6;
            // 
            // lblPartOfSpeech
            // 
            this.lblPartOfSpeech.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPartOfSpeech.AutoSize = true;
            this.lblPartOfSpeech.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPartOfSpeech.Location = new System.Drawing.Point(161, 286);
            this.lblPartOfSpeech.Margin = new System.Windows.Forms.Padding(0);
            this.lblPartOfSpeech.Name = "lblPartOfSpeech";
            this.lblPartOfSpeech.Size = new System.Drawing.Size(0, 18);
            this.lblPartOfSpeech.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.Location = new System.Drawing.Point(312, 344);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(228, 68);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(415, 303);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 18);
            this.lblScore.TabIndex = 12;
            // 
            // lblDefinitionName
            // 
            this.lblDefinitionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDefinitionName.AutoSize = true;
            this.lblDefinitionName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDefinitionName.Location = new System.Drawing.Point(45, 200);
            this.lblDefinitionName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.lblDefinitionName.Name = "lblDefinitionName";
            this.lblDefinitionName.Size = new System.Drawing.Size(78, 18);
            this.lblDefinitionName.TabIndex = 13;
            this.lblDefinitionName.Text = "Definition:";
            // 
            // lblContextName
            // 
            this.lblContextName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContextName.AutoSize = true;
            this.lblContextName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContextName.Location = new System.Drawing.Point(45, 243);
            this.lblContextName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.lblContextName.Name = "lblContextName";
            this.lblContextName.Size = new System.Drawing.Size(65, 18);
            this.lblContextName.TabIndex = 14;
            this.lblContextName.Text = "Context:";
            // 
            // lblPartOfSpeechName
            // 
            this.lblPartOfSpeechName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPartOfSpeechName.AutoSize = true;
            this.lblPartOfSpeechName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPartOfSpeechName.Location = new System.Drawing.Point(45, 286);
            this.lblPartOfSpeechName.Margin = new System.Windows.Forms.Padding(0);
            this.lblPartOfSpeechName.Name = "lblPartOfSpeechName";
            this.lblPartOfSpeechName.Size = new System.Drawing.Size(116, 18);
            this.lblPartOfSpeechName.TabIndex = 15;
            this.lblPartOfSpeechName.Text = "Part of Speech:";
            // 
            // formModeTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lblPartOfSpeechName);
            this.Controls.Add(this.lblContextName);
            this.Controls.Add(this.lblDefinitionName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblPartOfSpeech);
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.tBTranslate);
            this.Controls.Add(this.tBUntranslated);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formModeTraining";
            this.Text = "Word Learning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBUntranslated;
        private System.Windows.Forms.TextBox tBTranslate;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.Label lblPartOfSpeech;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblDefinitionName;
        private System.Windows.Forms.Label lblContextName;
        private System.Windows.Forms.Label lblPartOfSpeechName;
    }
}