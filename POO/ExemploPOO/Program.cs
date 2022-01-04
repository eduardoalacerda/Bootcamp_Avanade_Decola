using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.IO;
using System.Collections.Generic;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            var caminho = "I:\\RG Documentos\\Bootcamp Avanade Decola\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            var CaminhoArquivoTeste = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            var CaminhoArquivoTesteCopia = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-bkp.txt");

            var listaString = new List<string> { "Linha 1", "Linha 2", "linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5" , "Linha 6"};

            FileHelper helper = new FileHelper();
            // helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorios(caminho);
            // helper.CriarDiretorio(Path.Combine(caminho, "Pasta teste 3", "SubPastaTeste3"));
            // helper.CriarDiretorio(caminhoPathCombine);
            // helper.ApagarDiretorio(caminhoPathCombine, true);
            // helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            // helper.LerArquivoStream(caminhoArquivo);
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            // helper.CopiarArquivos(CaminhoArquivoTeste, CaminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(CaminhoArquivoTesteCopia);


            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Multiplicar(2, 2));

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // Diretor d = new Diretor();
            // d.Nome = "Leo";
            // d.Idade = 20;
            // d.Documento = 123456;
            // d.Salário = 1000;
            // d.Apresentar();


            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();


            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));

            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Documento = 123456;
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Leo";
            // p2.Idade = 20;
            // p2.Documento = 123456;
            // p2.Salário = 1000;
            // p2.Apresentar();

            // // Valores validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // // Valores invalidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}
