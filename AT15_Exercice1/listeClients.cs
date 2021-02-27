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
    public partial class listeClients : Form
    {
        CrystalReportClient Cr_client = new CrystalReportClient();
        public listeClients()
        {
            InitializeComponent();
        }

        private void listeClients_Load(object sender, EventArgs e)
        {
            crystalReportViewerClient.ReportSource = Cr_client;
            crystalReportViewerClient.PrintReport();
        }
    }
}
