using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteClasses
{
    public partial class Escolha : Form
    {
        public Escolha()
        {
            InitializeComponent();
        }

        private void btnMensalista_Click(object sender, EventArgs e)
        {
            //estamos criando um objeto frmMensalista e mostrando a tela dele
            FrmMensalista frmMensalista = new FrmMensalista();
            frmMensalista.Show();
        }

        private void btnHorista_Click(object sender, EventArgs e)
        {
            FrmHorista frmHorista = new FrmHorista();
            frmHorista.Show();
        }
    }
}
