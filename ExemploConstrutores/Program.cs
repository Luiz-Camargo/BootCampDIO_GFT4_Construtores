using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {

        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();
            
            // Operacao op = Calculadora.Somar;
            // op(10,10);

            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            // op.Invoke(10,10);

            // Operacao op2 = new Operacao(Calculadora.Subtrair);
            // op2.Invoke(50,25);
            
            // const double pi = 3.14;
 
            // Console.WriteLine(pi);

            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instancia";

            // Log log2 = Log.GetInstance();
            // Console.WriteLine(log2.PropriedadeLog);


            // Pessoa p1 = new Pessoa("Luiz Henrique", "Alberto de Camargo");
            // p1.Apresentar();

            // Aluno a1 = new Aluno("Luiz Henrique", "Alberto de Camargo", "Programação Orientada a Objetos");
            // a1.Apresentar();

            // Data data = new Data();
            // data.SetMes(20);

            // data.Mes = 12;
            // Console.WriteLine(data.Mes);

            // data.ApresentarMes();
        }
    }
}