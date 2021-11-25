using System;
using System.Collections.Generic;
using TrabalhadorContratosComposicao.Entities.Enums;
using TrabalhadorContratosComposicao.Entities;

namespace TrabalhadorContratosComposicao.Entities
{
    class Worker
    {
        public string Nome { get; set; }
        public Department Departamento { get; set; }
        public WorkLevel Nivel { get; set; }
        public double SalarioBase { get; set; }
        public List<HourContract> Contratos { get; set; } = new List<HourContract>();


        public Worker()
        {

        }

        public Worker(string nome, Department departamento, WorkLevel nivel, double salarioBase)
        {
            Nome = nome;
            Departamento = departamento;
            Nivel = nivel;
            SalarioBase = salarioBase;
        }

        public void AdContrato(HourContract contrato)
        {

            Contratos.Add(contrato);


        }

        public void RemoveContrato(HourContract contrato)
        {
            Contratos.Remove(contrato);
        }


        public double TotalReceber(int mes, int ano)

        {
            double sum = SalarioBase;

            foreach (HourContract contrato in Contratos)
            {

                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    sum += contrato.TotalContrato();
                }
            }

            return sum;
        }


    }

}
