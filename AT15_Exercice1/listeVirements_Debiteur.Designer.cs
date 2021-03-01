namespace AT15_Exercice1
{
    partial class listeVirements_Debiteur
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
            this.crystalReportViewerVrDeb = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportVrDeb1 = new AT15_Exercice1.CrystalReportVrDeb();
            this.SuspendLayout();
            // 
            // crystalReportViewerVrDeb
            // 
            this.crystalReportViewerVrDeb.ActiveViewIndex = 0;
            this.crystalReportViewerVrDeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerVrDeb.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerVrDeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerVrDeb.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerVrDeb.Name = "crystalReportViewerVrDeb";
            this.crystalReportViewerVrDeb.ReportSource = this.CrystalReportVrDeb1;
            this.crystalReportViewerVrDeb.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerVrDeb.TabIndex = 0;
            // 
            // listeVirements_Debiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerVrDeb);
            this.Name = "listeVirements_Debiteur";
            this.Text = "listeVirements_Debiteur";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerVrDeb;
        private CrystalReportVrDeb CrystalReportVrDeb1;
    }
}