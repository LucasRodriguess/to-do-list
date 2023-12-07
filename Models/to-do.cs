using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        private string? _maisUmaTarefa;
        public string maisUmaTarefa
        {
            get { return _maisUmaTarefa; }
            set
            {
                if (value.ToLower() == "sim" || value.ToLower() == "nao")
                {
                    _maisUmaTarefa = value.ToLower();
                }
                else
                {
                    throw new ArgumentException("A resposta deve ser 'sim' ou 'nao - sem acento'.");
                }
            }
        }
        public string[]? novaTarefa;
        public int identificadorTarefa = 0;
        public string? descricaoTarefa;
        public DateTime dataCriacaoTarefa;
        private string? _tarefaFeita;
        public string TarefaFeita
        {
            get { return _tarefaFeita; }
            set
            {
                if (value.ToLower() == "sim" || value.ToLower() == "nao")
                {
                    _tarefaFeita = value.ToLower();
                }
                else
                {
                    throw new ArgumentException("A resposta deve ser 'sim' ou 'nao - sem acento'.");
                }
            }
    }

        public void CriandoNovaTarefa()
        {
            Console.WriteLine("Informe uma descrição para a tarefa");
            descricaoTarefa = Console.ReadLine();

            Console.WriteLine("A tarefa será marcada como feita? (sim ou nao - sem acentuação)");
            TarefaFeita = Console.ReadLine();

            dataCriacaoTarefa = DateTime.Now;

            novaTarefa = new string[] {$"{identificadorTarefa++},{descricaoTarefa},{TarefaFeita},{dataCriacaoTarefa}"};

            MaisUmaTarefa();
        }

        public void MaisUmaTarefa()
        {
            Console.WriteLine("Deseja inserir mais uma tarefa?");
            maisUmaTarefa = Console.ReadLine();

            switch(maisUmaTarefa)
            {
                case "sim":
                    CriandoNovaTarefa();
                break;

                case "nao":
                    Console.WriteLine("Volte sempre!");
                break;
            }
        }
    }
}