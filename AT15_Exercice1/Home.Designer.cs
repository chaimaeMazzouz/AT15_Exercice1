namespace AT15_Exercice1
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouvementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeComptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMouvementParCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVirementsParCompteDébiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVirementsParCompteCréditeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.mouvementToolStripMenuItem,
            this.virementToolStripMenuItem,
            this.impressionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // mouvementToolStripMenuItem
            // 
            this.mouvementToolStripMenuItem.Name = "mouvementToolStripMenuItem";
            this.mouvementToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.mouvementToolStripMenuItem.Text = "Mouvement";
            // 
            // virementToolStripMenuItem
            // 
            this.virementToolStripMenuItem.Name = "virementToolStripMenuItem";
            this.virementToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.virementToolStripMenuItem.Text = "Virement";
            // 
            // impressionToolStripMenuItem
            // 
            this.impressionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeClientsToolStripMenuItem,
            this.listeComptesToolStripMenuItem,
            this.listeMouvementParCompteToolStripMenuItem,
            this.listeVirementsParCompteDébiteurToolStripMenuItem,
            this.listeVirementsParCompteCréditeurToolStripMenuItem});
            this.impressionToolStripMenuItem.Name = "impressionToolStripMenuItem";
            this.impressionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.impressionToolStripMenuItem.Text = "Impression";
            // 
            // listeClientsToolStripMenuItem
            // 
            this.listeClientsToolStripMenuItem.Name = "listeClientsToolStripMenuItem";
            this.listeClientsToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.listeClientsToolStripMenuItem.Text = "Liste Clients";
            this.listeClientsToolStripMenuItem.Click += new System.EventHandler(this.listeClientsToolStripMenuItem_Click);
            // 
            // listeComptesToolStripMenuItem
            // 
            this.listeComptesToolStripMenuItem.Name = "listeComptesToolStripMenuItem";
            this.listeComptesToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.listeComptesToolStripMenuItem.Text = "Liste Comptes";
            this.listeComptesToolStripMenuItem.Click += new System.EventHandler(this.listeComptesToolStripMenuItem_Click);
            // 
            // listeMouvementParCompteToolStripMenuItem
            // 
            this.listeMouvementParCompteToolStripMenuItem.Name = "listeMouvementParCompteToolStripMenuItem";
            this.listeMouvementParCompteToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.listeMouvementParCompteToolStripMenuItem.Text = "Liste Mouvements par compte";
            this.listeMouvementParCompteToolStripMenuItem.Click += new System.EventHandler(this.listeMouvementParCompteToolStripMenuItem_Click);
            // 
            // listeVirementsParCompteDébiteurToolStripMenuItem
            // 
            this.listeVirementsParCompteDébiteurToolStripMenuItem.Name = "listeVirementsParCompteDébiteurToolStripMenuItem";
            this.listeVirementsParCompteDébiteurToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.listeVirementsParCompteDébiteurToolStripMenuItem.Text = "Liste Virements par compte Débiteur";
            this.listeVirementsParCompteDébiteurToolStripMenuItem.Click += new System.EventHandler(this.listeVirementsParCompteDébiteurToolStripMenuItem_Click);
            // 
            // listeVirementsParCompteCréditeurToolStripMenuItem
            // 
            this.listeVirementsParCompteCréditeurToolStripMenuItem.Name = "listeVirementsParCompteCréditeurToolStripMenuItem";
            this.listeVirementsParCompteCréditeurToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.listeVirementsParCompteCréditeurToolStripMenuItem.Text = "Liste Virements par compte Créditeur";
            this.listeVirementsParCompteCréditeurToolStripMenuItem.Click += new System.EventHandler(this.listeVirementsParCompteCréditeurToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 415);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Gestion Bancaire";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouvementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeComptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMouvementParCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeVirementsParCompteDébiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeVirementsParCompteCréditeurToolStripMenuItem;
    }
}

