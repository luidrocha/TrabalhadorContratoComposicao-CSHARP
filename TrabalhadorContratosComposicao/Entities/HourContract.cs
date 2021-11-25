using System;



namespace TrabalhadorContratosComposicao.Entities
{
    class HourContract
    {
        public DateTime Data { get; set; }
        public double valPorHora { get; set; }

        public int totalHoras { get; set; }



        public HourContract()
        {

        }

        public HourContract(DateTime data, double valPorHora, int totalHoras)
        {
            Data = data;
            this.valPorHora = valPorHora;
            this.totalHoras = totalHoras;
        }


        public double TotalContrato()
        {


            return valPorHora * totalHoras;


        }

        

        }


    }

