using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var opcao = MenuInicial();
            while (opcao != "3")
            {
                switch (opcao)
                {
                    case "1": { ApresentarCarro(); } break;
                    case "2": { MenuAdicionarCarro(); } break;
                }
                opcao = MenuInicial();
            }
            
        }

        public static void MenuAdicionarCarro()
        {
            List<Carros> meusCarros = new List<Carros>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o modelo do carro");
                var modelo = Console.ReadLine();
                Console.WriteLine("Digite o ano do carro");
                int ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a placa do carro");
                var placa = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de Cvs");
                int cavalos = int.Parse(Console.ReadLine());

                meusCarros.Add(new Carros()
                {
                    Modelo = modelo,
                    Ano = ano,
                    Placa = placa,
                    Cv = cavalos
                });
                break;
            }
        }

        public static void ApresentarCarro()
        {
            List<Carros> meusCarros = new List<Carros>();
            foreach (Carros item in meusCarros)
            {
                Console.WriteLine($"Modelo: {item.Modelo} Ano: {item.Ano} Placa: {item.Placa} Cvs: {item.Placa}");
                
            }
            Console.ReadKey();
        }

        public static string MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Digite a opção desejada");
            Console.WriteLine("1 - Listar Carros");
            Console.WriteLine("2 - Adicionar um veiculo");
            Console.WriteLine("3 - Sair");

            return Console.ReadLine();
        }
    }
}
