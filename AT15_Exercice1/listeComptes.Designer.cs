namespace AT15_Exercice1
{
    partial class listeComptes
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
            this.crystalReportViewerCompte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportCompte1 = new AT15_Exercice1.CrystalReportCompte();
            this.SuspendLayout();
            // 
            // crystalReportViewerCompte
            // 
            this.crystalReportViewerCompte.ActiveViewIndex = 0;
            this.crystalReportViewerCompte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerCompte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerCompte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerCompte.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerCompte.Name = "crystalReportViewerCompte";
            this.crystalReportViewerCompte.ReportSource = this.CrystalReportCompte1;
            this.crystalReportViewerCompte.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerCompte.TabIndex = 0;
            // 
            // listeComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerCompte);
            this.Name = "listeComptes";
            this.Text = "listeComptes";
            this.Load += new System.EventHandler(this.listeComptes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerCompte;
        private CrystalReportCompte CrystalReportCompte1;
    }
}