namespace WordLearningApp
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGlossary = new System.Windows.Forms.Label();
            this.lblGlossaryPath = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(271, 26);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.editToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.fileToolStripMenuItem.Text = "Glossary";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingToolStripMenuItem,
            this.testToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.trainingToolStripMenuItem.Text = "Training";
            this.trainingToolStripMenuItem.Click += new System.EventHandler(this.trainingToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // lblGlossary
            // 
            this.lblGlossary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGlossary.AutoSize = true;
            this.lblGlossary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGlossary.Location = new System.Drawing.Point(12, 39);
            this.lblGlossary.Name = "lblGlossary";
            this.lblGlossary.Size = new System.Drawing.Size(73, 18);
            this.lblGlossary.TabIndex = 4;
            this.lblGlossary.Text = "Glossary:";
            // 
            // lblGlossaryPath
            // 
            this.lblGlossaryPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGlossaryPath.AutoSize = true;
            this.lblGlossaryPath.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGlossaryPath.Location = new System.Drawing.Point(91, 39);
            this.lblGlossaryPath.Name = "lblGlossaryPath";
            this.lblGlossaryPath.Size = new System.Drawing.Size(0, 18);
            this.lblGlossaryPath.TabIndex = 5;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 94);
            this.Controls.Add(this.lblGlossaryPath);
            this.Controls.Add(this.lblGlossary);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "formMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Learning";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
/*
        private void FormModifyTest()
        {
            this.Size = new System.Drawing.Size(816, 489);
            // 
            // btnConfirm
            // 
            var btnConfirm = new System.Windows.Forms.Button();
            this.Controls.Add(btnConfirm);
            btnConfirm.Size = new System.Drawing.Size(216, 48);
            btnConfirm.Location = new System.Drawing.Point(256, 336);
            btnConfirm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnConfirm.Name = "btnConfirm";
            btnConfirm.TabIndex = 8;
            btnConfirm.Text = "Confirm";
            //btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tBUntranslated
            // 
            var tBUntranslated = new System.Windows.Forms.TextBox();
            this.Controls.Add(tBUntranslated);
            tBUntranslated.Font = new System.Drawing.Font("Calibri", 16F);
            tBUntranslated.Location = new System.Drawing.Point(91, 102);
            tBUntranslated.MaxLength = 100;
            tBUntranslated.Name = "tBUntranslated";
            tBUntranslated.Size = new System.Drawing.Size(250, 34);
            tBUntranslated.TabIndex = 0;
            // 
            // tBTranslate
            // 
            var tBTranslate = new System.Windows.Forms.TextBox();
            this.Controls.Add(tBTranslate);
            tBTranslate.Font = new System.Drawing.Font("Calibri", 16F);
            tBTranslate.Location = new System.Drawing.Point(413, 102);
            tBTranslate.MaxLength = 100;
            tBTranslate.Name = "tBTranslate";
            tBTranslate.Size = new System.Drawing.Size(250, 34);
            tBTranslate.TabIndex = 1;
            // 
            // lblCorrectCounter
            // 
            var lblCorrectCounter = new System.Windows.Forms.Label();
            this.Controls.Add(lblCorrectCounter);
            lblCorrectCounter.AutoSize = true;
            lblCorrectCounter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblCorrectCounter.Location = new System.Drawing.Point(281, 263);
            lblCorrectCounter.Name = "lblCorrectCounter";
            lblCorrectCounter.Size = new System.Drawing.Size(0, 19);
            lblCorrectCounter.TabIndex = 9;
            // 
            // lblSlash
            // 
            var lblSlash = new System.Windows.Forms.Label();
            //this.Controls.Add(this.lblSlash);
            lblSlash.AutoSize = true;
            lblSlash.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblSlash.Name = "lblSlash";
            lblSlash.Location = new System.Drawing.Point(347, 263);
            lblSlash.Size = new System.Drawing.Size(15, 19);
            lblSlash.TabIndex = 10;
            lblSlash.Text = "/";
            // 
            // lblIncorrectCounter
            // 
            var lblIncorrectCounter = new System.Windows.Forms.Label();
            this.Controls.Add(lblIncorrectCounter);
            lblIncorrectCounter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblIncorrectCounter.Location = new System.Drawing.Point(383, 263);
            lblIncorrectCounter.AutoSize = true;
            lblIncorrectCounter.Name = "lblIncorrectCounter";
            lblIncorrectCounter.Size = new System.Drawing.Size(0, 19);
            lblIncorrectCounter.TabIndex = 11;
        }
*/
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Label lblGlossary;
        private System.Windows.Forms.Label lblGlossaryPath;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

