namespace AT15_Exercice1
{
    partial class listeClients
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
            this.crystalReportViewerClient = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportClient1 = new AT15_Exercice1.CrystalReportClient();
            this.SuspendLayout();
            // 
            // crystalReportViewerClient
            // 
            this.crystalReportViewerClient.ActiveViewIndex = 0;
            this.crystalReportViewerClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerClient.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerClient.Name = "crystalReportViewerClient";
            this.crystalReportViewerClient.ReportSource = this.CrystalReportClient1;
            this.crystalReportViewerClient.Size = new System.Drawing.Size(779, 436);
            this.crystalReportViewerClient.TabIndex = 0;
            // 
            // listeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 436);
            this.Controls.Add(this.crystalReportViewerClient);
            this.Name = "listeClients";
            this.Text = "listeClients";
            this.Load += new System.EventHandler(this.listeClients_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerClient;
        private CrystalReportClient CrystalReportClient1;
    }
}