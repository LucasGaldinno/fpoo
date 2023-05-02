using System;

namespace CA_Estruturas
{
    class Program
    {
        public struct Data
        {
            public int dia, mes, ano;

            public Data(int objDia, int objMes, int objAno)
            {
                this.dia = objDia;
                this.mes = objMes;
                this.ano = objAno;
            }
        }

        //Struct sem construtor
        public struct Horario
        {
            public int hora, minuto, segundo;
        }

        //Struct com construtor e encapsulamento
        public struct Horario2
        {
            private int hora2, minuto2, segundo2;

            public Horario2(int h, int m, int s)
            {
                this.hora2 = h % 24;
                this.minuto2 = m % 60;
                this.segundo2 = s % 60;
            }

            public int Hora2() => this.hora2;

            public int Minuto2() => this.minuto2;

            public int Segundo2() => this.segundo2;
        }

        static void Main(string[] args)
        {
            Data objDataHoje = new Data(28, 01, 2021);

            Console.WriteLine("\nData de hoje: " + 
                                objDataHoje.dia + "/" + 
                                objDataHoje.mes + "/" + 
                                objDataHoje.ano);

            Data objDataOntem = objDataHoje;
            objDataOntem.dia--;

            Console.WriteLine("\nData de ontem: " + 
                                objDataOntem.dia + "/" + 
                                objDataOntem.mes + "/" + 
                                objDataOntem.ano);

            Data objDataAmanha = objDataHoje;
            objDataAmanha.dia++;

            Console.WriteLine("\nData de amanha: " + 
                                objDataAmanha.dia + "/" + 
                                objDataAmanha.mes + "/" + 
                                objDataAmanha.ano);

            //objDataHoje.dia = DateTime.Now.Day;

            Horario agora;
            agora.hora = DateTime.Now.Hour;
            agora.minuto = DateTime.Now.Minute;
            agora.segundo = DateTime.Now.Second;

            System.Console.WriteLine("Horário: {0}:{1}:{2}", agora.hora, agora.minuto, agora.segundo);

            Horario2 agora2 = new Horario2(11, 38, 00);
            System.Console.WriteLine("Agora são: {0}:{1}:{2}", agora2.Hora2(), agora2.Minuto2(), agora2.Segundo2());
        }
    }
}
