using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Biblioteca
{
    class EstacionamentoBH
    {
        string[,] bancoDeDados = new string[10, 6];
        int idBancoDados = 0;

        public string MenuDeOpcoes()
        {
            Console.Clear();

            Console.WriteLine("1 - Adicionar um aluno e suas notas.");
            Console.WriteLine("2 - Listar alunos.");
            Console.WriteLine("3 - Exluir aluno.");
            Console.WriteLine("4 - Alterar nota e frequencia");
            Console.WriteLine("5 - Sair do sistema");
            Console.WriteLine("");
            Console.WriteLine("Digite a opção desejada");

            return Console.ReadLine();
        }

        public void CadastrarCarro()
        {

            Console.WriteLine("Digite o modelo do carro");
            var modeloCarro = Console.ReadLine();

            Console.WriteLine("Digite a placa do carro");
            var placaCarro = Console.ReadLine();

            Console.WriteLine("Data e Hora de entrada");
            var dataHoraEntrada = Console.ReadLine();

            var dataHoraSaida = "null";

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 0] != null)
                    continue;

                bancoDeDados[i, 0] = (idBancoDados++).ToString();
                bancoDeDados[i, 1] = modeloCarro;
                bancoDeDados[i, 2] = placaCarro;
                bancoDeDados[i, 3] = dataHoraEntrada;
                bancoDeDados[i, 4] = dataHoraSaida;
                bancoDeDados[i, 5] = "true";

                break;
            }
        }
        public void HoraDaSaida()
        {

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 5] != "false")
                {
                    Console.WriteLine($"Id:{bancoDeDados[i, 0]}\r\n" +
                        $"Aluno: {bancoDeDados[i, 1]}\r\n" +
                        $"Média: {bancoDeDados[i, 2]}\r\n" +
                        $"Frequencia: {bancoDeDados[i, 3]}%\r\n" +
                        $"Situação: {bancoDeDados[i, 5]} ");
                }

            }

            Console.WriteLine("Informe a placa do carro");
            var placaCarro = Console.ReadLine();

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {

                if (bancoDeDados[i, 2] != null && bancoDeDados[i, 2] == placaCarro)
                {
                    Console.WriteLine("Digite a data e hora de saida do veículo");
                    bancoDeDados[i, 4] = Console.ReadLine();
                }
            }
            Console.WriteLine("Banco de dados atualizado com sucesso!!");
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
        }
    }
}
