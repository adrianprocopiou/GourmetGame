namespace GourmetGame.WindowsForms
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
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.radioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.radioButtonPortuguese = new System.Windows.Forms.RadioButton();
            this.labelIntroduction = new System.Windows.Forms.Label();
            this.groupBoxIntroduction = new System.Windows.Forms.GroupBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxLanguage.SuspendLayout();
            this.groupBoxIntroduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLanguage
            // 
            this.groupBoxLanguage.Controls.Add(this.radioButtonEnglish);
            this.groupBoxLanguage.Controls.Add(this.radioButtonPortuguese);
            resources.ApplyResources(this.groupBoxLanguage, "groupBoxLanguage");
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.TabStop = false;
            // 
            // radioButtonEnglish
            // 
            resources.ApplyResources(this.radioButtonEnglish, "radioButtonEnglish");
            this.radioButtonEnglish.Name = "radioButtonEnglish";
            this.radioButtonEnglish.UseVisualStyleBackColor = true;
            // 
            // radioButtonPortuguese
            // 
            resources.ApplyResources(this.radioButtonPortuguese, "radioButtonPortuguese");
            this.radioButtonPortuguese.Checked = true;
            this.radioButtonPortuguese.Name = "radioButtonPortuguese";
            this.radioButtonPortuguese.TabStop = true;
            this.radioButtonPortuguese.UseVisualStyleBackColor = true;
            // 
            // labelIntroduction
            // 
            resources.ApplyResources(this.labelIntroduction, "labelIntroduction");
            this.labelIntroduction.Name = "labelIntroduction";
            // 
            // groupBoxIntroduction
            // 
            this.groupBoxIntroduction.Controls.Add(this.labelIntroduction);
            resources.ApplyResources(this.groupBoxIntroduction, "groupBoxIntroduction");
            this.groupBoxIntroduction.Name = "groupBoxIntroduction";
            this.groupBoxIntroduction.TabStop = false;
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxIntroduction);
            this.Controls.Add(this.groupBoxLanguage);
            this.Name = "MainForm";
            this.groupBoxLanguage.ResumeLayout(false);
            this.groupBoxLanguage.PerformLayout();
            this.groupBoxIntroduction.ResumeLayout(false);
            this.groupBoxIntroduction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.RadioButton radioButtonEnglish;
        private System.Windows.Forms.RadioButton radioButtonPortuguese;
        private System.Windows.Forms.Label labelIntroduction;
        private System.Windows.Forms.GroupBox groupBoxIntroduction;
        private System.Windows.Forms.Button buttonOk;
    }
}

