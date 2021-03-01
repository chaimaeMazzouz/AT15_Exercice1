namespace AT15_Exercice1
{
    partial class listeMouvements
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
            this.crystalReportViewerMouvement = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportMouvement1 = new AT15_Exercice1.CrystalReportMouvement();
            this.SuspendLayout();
            // 
            // crystalReportViewerMouvement
            // 
            this.crystalReportViewerMouvement.ActiveViewIndex = 0;
            this.crystalReportViewerMouvement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerMouvement.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerMouvement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerMouvement.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerMouvement.Name = "crystalReportViewerMouvement";
            this.crystalReportViewerMouvement.ReportSource = this.CrystalReportMouvement1;
            this.crystalReportViewerMouvement.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerMouvement.TabIndex = 0;
            // 
            // listeMouvements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerMouvement);
            this.Name = "listeMouvements";
            this.Text = "listeMouvements";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerMouvement;
        private CrystalReportMouvement CrystalReportMouvement1;
    }
}