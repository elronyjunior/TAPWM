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
    public partial class FrmMensalista : Form
    {
        public FrmMensalista()
        {
            InitializeComponent();
        }

        private void Instanciar_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.Matricula=Convert.ToInt32(txtMatricula.Text);
            objMensalista.DataEntradaEmpresa=Convert.ToDateTime(txtDataEntradaEmpresa.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);

            MessageBox.Show("Nome:" + objMensalista.NomeEmpregado+"\nMatricula:"+objMensalista.Matricula
                +"\nData de entrada na Empresa:"+objMensalista.DataEntradaEmpresa+"\nTempo trabalho:"+objMensalista.TempoTrabalho()
                +"\nSalario Final:"+objMensalista.SalarioBruto().ToString("N2")
                );

            //static
            MessageBox.Show("Empresa: " + Mensalista.empresa);
        }

        private void InstanciarComParametro(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(220347,"Ronaldo",Convert.ToDateTime("12/09/2022"),12000);
            MessageBox.Show("Nome:" + objMensalista.NomeEmpregado + "\nMatricula:" + objMensalista.Matricula
                + "\nData de entrada na Empresa:" + objMensalista.DataEntradaEmpresa + "\nTempo trabalho:" + objMensalista.TempoTrabalho()
                + "\nSalario Final:" + objMensalista.SalarioBruto().ToString("N2")
                );
        }

    }
}
