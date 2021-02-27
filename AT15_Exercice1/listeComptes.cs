using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT15_Exercice1
{
    public partial class listeComptes : Form
    {
        CrystalReportCompte Cr_Compte = new CrystalReportCompte();
        public listeComptes()
        {
            InitializeComponent();
        }

        private void listeComptes_Load(object sender, EventArgs e)
        {
            crystalReportViewerCompte.ReportSource = Cr_Compte;
            crystalReportViewerCompte.PrintReport();
        }
    }
}
