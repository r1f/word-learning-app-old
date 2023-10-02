namespace WordLearningApp
{
    partial class formModeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formModeTest));
            this.tBUntranslated = new System.Windows.Forms.TextBox();
            this.tBTranslate = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCorrectCounter = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.lblIncorrectCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBUntranslated
            // 
            this.tBUntranslated.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBUntranslated.Font = new System.Drawing.Font("Arial", 14F);
            this.tBUntranslated.Location = new System.Drawing.Point(100, 107);
            this.tBUntranslated.Margin = new System.Windows.Forms.Padding(10);
            this.tBUntranslated.MaxLength = 300;
            this.tBUntranslated.Multiline = true;
            this.tBUntranslated.Name = "tBUntranslated";
            this.tBUntranslated.ReadOnly = true;
            this.tBUntranslated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBUntranslated.Size = new System.Drawing.Size(250, 140);
            this.tBUntranslated.TabIndex = 0;
            // 
            // tBTranslate
            // 
            this.tBTranslate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBTranslate.Font = new System.Drawing.Font("Arial", 18F);
            this.tBTranslate.Location = new System.Drawing.Point(400, 107);
            this.tBTranslate.Margin = new System.Windows.Forms.Padding(10);
            this.tBTranslate.MaxLength = 100;
            this.tBTranslate.Name = "tBTranslate";
            this.tBTranslate.Size = new System.Drawing.Size(250, 35);
            this.tBTranslate.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.Location = new System.Drawing.Point(262, 294);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(228, 68);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCorrectCounter
            // 
            this.lblCorrectCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorrectCounter.AutoSize = true;
            this.lblCorrectCounter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCorrectCounter.Location = new System.Drawing.Point(350, 257);
            this.lblCorrectCounter.Margin = new System.Windows.Forms.Padding(5);
            this.lblCorrectCounter.Name = "lblCorrectCounter";
            this.lblCorrectCounter.Size = new System.Drawing.Size(0, 18);
            this.lblCorrectCounter.TabIndex = 9;
            // 
            // lblSlash
            // 
            this.lblSlash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSlash.AutoSize = true;
            this.lblSlash.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSlash.Location = new System.Drawing.Point(375, 257);
            this.lblSlash.Margin = new System.Windows.Forms.Padding(5);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(12, 18);
            this.lblSlash.TabIndex = 10;
            this.lblSlash.Text = "/";
            // 
            // lblIncorrectCounter
            // 
            this.lblIncorrectCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIncorrectCounter.AutoSize = true;
            this.lblIncorrectCounter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIncorrectCounter.Location = new System.Drawing.Point(390, 257);
            this.lblIncorrectCounter.Margin = new System.Windows.Forms.Padding(5);
            this.lblIncorrectCounter.Name = "lblIncorrectCounter";
            this.lblIncorrectCounter.Size = new System.Drawing.Size(0, 18);
            this.lblIncorrectCounter.TabIndex = 11;
            // 
            // formModeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblIncorrectCounter);
            this.Controls.Add(this.lblSlash);
            this.Controls.Add(this.lblCorrectCounter);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tBTranslate);
            this.Controls.Add(this.tBUntranslated);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formModeTest";
            this.Text = "Word Learning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBUntranslated;
        private System.Windows.Forms.TextBox tBTranslate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCorrectCounter;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.Label lblIncorrectCounter;

        public static string[] glossary;
    }
}