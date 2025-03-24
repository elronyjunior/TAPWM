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
    public partial class FrmHorista : Form
    {
        public FrmHorista()
        {
            InitializeComponent();
        }

        private void InstanciarHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();
            objHorista.NomeEmpregado=txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora= Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToInt32(txtHora.Text);
            objHorista.DataEntradaEmpresa=Convert.ToDateTime(txtEntradaEmpresa.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFalta.Text);
            MessageBox.Show("Nome: " + objHorista.NomeEmpregado + "\n" +
                "Matricula: " + objHorista.Matricula + "\n" +
                "Tempo trabalho: " + objHorista.TempoTrabalho() + "\n" +
                "Salario: " + objHorista.SalarioBruto().ToString("N2"));
        }
    }
}
