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

            // Operacao ope = Calculadora.Subtrair;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            
            // op.Invoke(10, 10);
            
            // ope.Invoke(10, 10);
            // op(10, 10);

            // const double pi = 3.14;
            // System.Console.WriteLine(pi);

            // pi = 0;

            // Data data = new Data();
            // data.SetMes(0);

            // data.Mes = 20;
            // System.Console.WriteLine(data.Mes);

            // data.ApresentarMes();

            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Aluno p1 = new Aluno("Leonardo", "Buta", "Teste");
            // p1.Apresentar();
        }
    }
}
