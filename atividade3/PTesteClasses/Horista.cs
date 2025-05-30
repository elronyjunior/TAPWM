﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasses
{
    internal class Horista : Empregado
    {
        //código criado usando prop tab, porém não permite fazer validação de entrada ou saida
        public double SalarioHora { get; set; }
        public double NumeroHora { get; set; }
        public int DiasFalta { get; set; }
        public override double SalarioBruto()
        {
            return SalarioHora * NumeroHora;
        }
        public override int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (Convert.ToInt32(span.Days - DiasFalta));
        }
    }
}
