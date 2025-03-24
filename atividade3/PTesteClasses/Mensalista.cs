using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasses
{
    internal class Mensalista : Empregado
    {
        public double SalarioMensal { get; set; }
        
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
        public Mensalista()
        {
            System.Windows.Forms.MessageBox.Show("aqui é um Mensalista");
        }
        public Mensalista(int matricula,string nome,DateTime data, double salario)
        {
            this.NomeEmpregado = nome;
            this.Matricula = matricula;
            this.SalarioMensal = salario;
            this.DataEntradaEmpresa = data;
        }
    }
}
