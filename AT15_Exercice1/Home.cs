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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        void Changer_Form(Form NewForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            NewForm.MdiParent = this;
            NewForm.Dock = DockStyle.Fill;
            NewForm.Show();
        }
        private void listeClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new listeClients());
        }

        private void listeComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new listeComptes());

        }

        private void listeMouvementParCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new listeMouvements());

        }
    }
}
