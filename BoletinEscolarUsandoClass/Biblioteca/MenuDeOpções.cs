using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinEscolarUsandoClass.Biblioteca
{
    public class MenuDeOpções
    {
        string[,] bancoDeDados = new string[5, 6];
        int idBancoDados = 0;
        Boletim boletim = new Boletim();

        public string Menu()
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

        public void CadastrarNotaDoAluno()
        {

            Console.WriteLine("Digite o nome do Aluno");
            var nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a nota do primeiro trimestre");
            int nota1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do segundo trimestre");
            int nota2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do terceiro trimestre");
            int nota3 = Int32.Parse(Console.ReadLine());

            var media = boletim.NotasAlunos(nota1, nota2, nota3);

            Console.WriteLine("Informe o número de aulas");
            int aulas = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de faltas");
            int faltas = Int32.Parse(Console.ReadLine());

            var frequencia = boletim.Frequencia(aulas, faltas);

            var situacao = boletim.Situacao(media, frequencia);

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 0] != null)
                    continue;

                bancoDeDados[i, 0] = (idBancoDados++).ToString();
                bancoDeDados[i, 1] = nomeAluno;
                bancoDeDados[i, 2] = (media).ToString();
                bancoDeDados[i, 3] = (frequencia).ToString();
                bancoDeDados[i, 4] = "true";
                bancoDeDados[i, 5] = situacao;

                break;
            }
        }

        
        public void ExcuirRegistro()
        {

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 4] != "false" )
                {
                    Console.WriteLine($"Id:{bancoDeDados[i, 0]}\r\n" +
                        $"Aluno: {bancoDeDados[i, 1]}\r\n" +
                        $"Média: {bancoDeDados[i, 2]}\r\n" +
                        $"Frequencia: {bancoDeDados[i, 3]}%\r\n" +
                        $"Situação: {bancoDeDados[i, 5]} ");
                }
                
            }

            Console.WriteLine("Informe o ID que será excuido");
            var idInformado = Console.ReadLine();

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {

                if (bancoDeDados[i, 0] != null && bancoDeDados[i, 0] == idInformado)
                {
                    bancoDeDados[i, 4] = "false";
                }
            }
            Console.WriteLine("Banco de dados atualizado com sucesso!!");
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
        }

        public void MostrarAlunos(string alunosAtivos = "false")
        {
            Console.Clear();
            Console.WriteLine("ALUNOS CADASTRADOS");
            Console.WriteLine("");

            if (alunosAtivos == "true")
            {
                Console.WriteLine("Alunos Ativos:");
            }

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 4] != alunosAtivos)
                {
                    Console.WriteLine($"Id:{bancoDeDados[i, 0]} - Aluno: {bancoDeDados[i, 1]}\r\n" +
                        $"Média: {bancoDeDados[i, 2]}\r\n" +
                        $"Frequencia: {bancoDeDados[i, 3]}%\r\n" +
                        $"Situação: {bancoDeDados[i, 5]} ");
                }
                

            }
            Console.WriteLine("Pressione qualquer tecla para pocesseguir");
            Console.ReadKey();
        }

        public void AlterarNotas()
        {
            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 4] != "false")
                {
                    Console.WriteLine($"Id:{bancoDeDados[i, 0]}\r\n" +
                        $"Aluno: {bancoDeDados[i, 1]}\r\n" +
                        $"Média: {bancoDeDados[i, 2]}\r\n" +
                        $"Frequencia: {bancoDeDados[i, 3]}%\r\n" +
                        $"Situação: {bancoDeDados[i, 5]} ");
                }

            }

            Console.WriteLine("Digite o ID que você deseja alterar");
            var idInformado = Console.ReadLine();

            Console.WriteLine("Digite a nota do primeiro trimestre");
            int nota1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do segundo trimestre");
            int nota2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do terceiro trimestre");
            int nota3 = Int32.Parse(Console.ReadLine());

            var media = boletim.NotasAlunos(nota1, nota2, nota3);

            Console.WriteLine("Informe o número de aulas");
            int aulas = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de faltas");
            int faltas = Int32.Parse(Console.ReadLine());

            var frequencia = boletim.Frequencia(aulas, faltas);

            for (int i = 0; i < bancoDeDados.GetLength(0); i++)
            {
                if (bancoDeDados[i, 0] == idInformado)
                {
                    bancoDeDados[i, 2] = (media).ToString();
                    bancoDeDados[i, 3] = (frequencia).ToString();
                }
            }
        }
    }
}
