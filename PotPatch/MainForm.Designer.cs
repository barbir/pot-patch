namespace PotPatch
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.untranslated = new System.Windows.Forms.GroupBox();
            this.openUntranslated = new System.Windows.Forms.Button();
            this.untranslatedPath = new System.Windows.Forms.TextBox();
            this.translated = new System.Windows.Forms.GroupBox();
            this.openTranslated = new System.Windows.Forms.Button();
            this.translatedPath = new System.Windows.Forms.TextBox();
            this.patchAndSave = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.untranslated.SuspendLayout();
            this.translated.SuspendLayout();
            this.SuspendLayout();
            // 
            // untranslated
            // 
            this.untranslated.Controls.Add(this.openUntranslated);
            this.untranslated.Controls.Add(this.untranslatedPath);
            this.untranslated.Location = new System.Drawing.Point(12, 12);
            this.untranslated.Name = "untranslated";
            this.untranslated.Size = new System.Drawing.Size(420, 46);
            this.untranslated.TabIndex = 0;
            this.untranslated.TabStop = false;
            this.untranslated.Text = "New .pot (untranslated)";
            // 
            // openUntranslated
            // 
            this.openUntranslated.Location = new System.Drawing.Point(387, 20);
            this.openUntranslated.Name = "openUntranslated";
            this.openUntranslated.Size = new System.Drawing.Size(27, 20);
            this.openUntranslated.TabIndex = 1;
            this.openUntranslated.Text = "...";
            this.openUntranslated.UseVisualStyleBackColor = true;
            this.openUntranslated.Click += new System.EventHandler(this.openUntranslated_Click);
            // 
            // untranslatedPath
            // 
            this.untranslatedPath.Location = new System.Drawing.Point(6, 19);
            this.untranslatedPath.Name = "untranslatedPath";
            this.untranslatedPath.Size = new System.Drawing.Size(375, 20);
            this.untranslatedPath.TabIndex = 0;
            // 
            // translated
            // 
            this.translated.Controls.Add(this.openTranslated);
            this.translated.Controls.Add(this.translatedPath);
            this.translated.Location = new System.Drawing.Point(12, 64);
            this.translated.Name = "translated";
            this.translated.Size = new System.Drawing.Size(420, 46);
            this.translated.TabIndex = 1;
            this.translated.TabStop = false;
            this.translated.Text = "Existing .pot (translated)";
            // 
            // openTranslated
            // 
            this.openTranslated.Location = new System.Drawing.Point(387, 20);
            this.openTranslated.Name = "openTranslated";
            this.openTranslated.Size = new System.Drawing.Size(27, 20);
            this.openTranslated.TabIndex = 1;
            this.openTranslated.Text = "...";
            this.openTranslated.UseVisualStyleBackColor = true;
            this.openTranslated.Click += new System.EventHandler(this.openTranslated_Click);
            // 
            // translatedPath
            // 
            this.translatedPath.Location = new System.Drawing.Point(6, 19);
            this.translatedPath.Name = "translatedPath";
            this.translatedPath.Size = new System.Drawing.Size(375, 20);
            this.translatedPath.TabIndex = 0;
            // 
            // patchAndSave
            // 
            this.patchAndSave.Location = new System.Drawing.Point(12, 116);
            this.patchAndSave.Name = "patchAndSave";
            this.patchAndSave.Size = new System.Drawing.Size(420, 39);
            this.patchAndSave.TabIndex = 2;
            this.patchAndSave.Text = "Patch && Save";
            this.patchAndSave.UseVisualStyleBackColor = true;
            this.patchAndSave.Click += new System.EventHandler(this.patchAndSave_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "*.pot";
            this.openFile.Filter = ".pot files|*.pot|All files|*.*";
            // 
            // saveFile
            // 
            this.saveFile.FileName = "new.pot";
            this.saveFile.Filter = "*.pot files|*.pot";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 167);
            this.Controls.Add(this.patchAndSave);
            this.Controls.Add(this.translated);
            this.Controls.Add(this.untranslated);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = ".pot Patch";
            this.untranslated.ResumeLayout(false);
            this.untranslated.PerformLayout();
            this.translated.ResumeLayout(false);
            this.translated.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox untranslated;
        private System.Windows.Forms.Button openUntranslated;
        private System.Windows.Forms.TextBox untranslatedPath;
        private System.Windows.Forms.GroupBox translated;
        private System.Windows.Forms.Button openTranslated;
        private System.Windows.Forms.TextBox translatedPath;
        private System.Windows.Forms.Button patchAndSave;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

