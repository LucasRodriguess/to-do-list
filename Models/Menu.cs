using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace to_do_list.Models
{
    public class ExibirMenu
    {
        private int OpcaoCriarTarefa = 1;
        private int OpcaoEditarTarefa = 2;
        private int OpcaoExcluirTarefa = 3;
        private int OpcaoListarTarefas = 4;
        public void OpcoesDoMenu()
        {
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine($"{OpcaoCriarTarefa} - para Criar uma Nova Tarefa");
            Console.WriteLine($"{OpcaoEditarTarefa} - para Editar uma Tarefa");
            Console.WriteLine($"{OpcaoExcluirTarefa} - para Excluir uma Tarefa");
            Console.WriteLine($"{OpcaoListarTarefas} - para Listar Todas as Tarefas");
        } 
    }

    public class OpcaoEscolhida
    {
        public int OpcaoDoUsuario = Convert.ToInt32(Console.ReadLine());
        CriarNovaTarefa a3 = new CriarNovaTarefa();

        public void ValidadorOpcao()
        {
            switch (OpcaoDoUsuario)
            {
                case 1:
                Console.WriteLine("OPÇÃO DE CRIAÇÃO DE UMA NOVA TAREFA, ESCOLHIDA");
                a3.CriandoNovaTarefa();
                break;

                case 2:
                Console.WriteLine("Opção escolhida: 2");
                break;

                case 3:
                Console.WriteLine("Opção escolhida: 3");
                break;
                
                case 4:
                Console.WriteLine("Opção escolhida: 4");
                break;
                
                case 5:
                Console.WriteLine("Opção escolhida: 5");
                break;

                default:
                Console.WriteLine("Opção Inválida");
                break;
            }
        }
    }

    class CriarNovaTarefa
    {
        public string[] NovaTarefa = new string[4];

        public void CriandoNovaTarefa()
        {
            Console.WriteLine("Ta dando certo");
        }
    }
}