using Aula_1705_Camadas.Controllers;
using Aula_1705_Camadas.Models;
using System;
using System.Collections.Generic;

namespace Aula_1705_Camadas.Views
{
    class AtividadeView
    {
        //corrigir ID
        //Buscar Atividade, Editar, excluir
        //Solicitar confirmação na hora de editar
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }

        private AtividadesController atividadeController;

        public AtividadeView()
        {
            atividadeController = new AtividadesController();
        }

        enum MinhasOpcoes
        {
            CriarAtividade = 1,
            ListarAtividade = 2,
            BuscarAtividade = 3,
            EditarAtividade = 4,
            ExcluirAtividade = 5,
            BuscarPorNome = 6,
            AtividadeAtiva = 7,
            Sair = 9,
        }

        public void ExibirMenu()
        {
            MinhasOpcoes opcao = MinhasOpcoes.Sair;
            do
            {

                Console.WriteLine("=======================");

                Console.WriteLine("= Escolha uma opcao: = ");
                Console.WriteLine("= 1) Criar Atividade = ");
                Console.WriteLine("= 2) Listar Atividades = ");
                Console.WriteLine("= 3) Exibir Atividade = ");
                Console.WriteLine("= 4) Buscar Atividade = ");
                Console.WriteLine("= 5) Excluir Atividade = ");
                Console.WriteLine("= 6) Buscar Atividade por Nome = ");
                Console.WriteLine("= 7) Listar Atividades (Ativos/Inativos) = ");
                Console.WriteLine("= 9) Sair = ");

                Console.WriteLine("=======================");

                opcao = (MinhasOpcoes) int.Parse(Console.ReadLine());
                //return opcao;

                switch (opcao)
                {
                    case MinhasOpcoes.CriarAtividade:
                        CriarAtividade();
                        break;
                    case MinhasOpcoes.ListarAtividade:
                        ListarAtividade();
                        break;
                    case MinhasOpcoes.BuscarAtividade:
                        BuscarAtividade();
                        break;
                    case MinhasOpcoes.EditarAtividade:
                        EditarAtividade();
                        break;
                    case MinhasOpcoes.ExcluirAtividade:
                        ExcluirAtividade();
                        break;
                    case MinhasOpcoes.BuscarPorNome:
                        BuscarPorNome();
                        break;
                    case MinhasOpcoes.AtividadeAtiva:
                        BuscarPorStatus ();
                        break;


                    default:
                        Console.WriteLine("Opção Invalida! Digite qualquer tecla para sair.");
                        break;
               }
            } while (opcao != MinhasOpcoes.Sair);
        }

        private void ExcluirAtividade()
        {
            ListarAtividade();

            Console.WriteLine("Digite o id da atividade a ser editada");
            int id = int.Parse(Console.ReadLine());

            //AtividadesController atividadeController = new AtividadesController();
            atividadeController.Excluir(id);
        }

        private void EditarAtividade()
        {
            ListarAtividade();

            Console.WriteLine("Digite o id da atividade a ser editada");
            int id = int.Parse(Console.ReadLine());

            Atividade atividadeAtualizada = ObterDadosAtividade();

           // AtividadesController atividadeController = new AtividadesController();
            atividadeController.Editar(id, atividadeAtualizada);

        }

        private void BuscarAtividade()
        {
            //AtividadesController atividadeController = new AtividadesController();

            Console.Write("Digite o id a aitividade: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividade = atividadeController.BuscarPorID(id);

            if(atividade != null)
            {
                ExibirDetalhesAtividades(atividade);
            } else
            {
                Console.WriteLine("Atividade não encontrada");

            }
            Console.ReadKey();
        }

        private void ListarAtividade()
        {
           // AtividadesController atividadeControl = new AtividadesController();
            foreach (Atividade atividade in atividadeController.Listar())
            {
                ExibirDetalhesAtividades(atividade);
            }

            Console.WriteLine("Fim da Lista");
            Console.ReadKey();
        }

        private static void ExibirDetalhesAtividades(Atividade atividade)
        {
            Console.WriteLine("---");
            Console.WriteLine("Id: " + atividade.AtividadeID);
            Console.WriteLine("Nome: " + atividade.Nome);
            Console.WriteLine("Ativo: " + atividade.Ativo);
            Console.WriteLine("---");
        }

        public void CriarAtividade()
        {
            Atividade atividade = ObterDadosAtividade();

            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Salvar(atividade);
        }

        private static Atividade ObterDadosAtividade()
        {
            Atividade atividade = new Atividade();
            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            Console.WriteLine("Ativo? (s/n): ");

            atividade.Ativo = Console.ReadLine() == "s" ? true : false; //if e else: operador ternario
            return atividade;
        }

        private void BuscarPorNome()
        {

            Console.Write("Digite o nome da atividade: ");

            List<Atividade> lista = atividadeController.BuscarPorNome(Console.ReadLine());

            if (lista.Count > 0)
            {
                foreach (Atividade a in lista)
                {
                    ExibirDetalhesAtividades(a);
                }
            } else
            {
                Console.WriteLine("Nada encontrado! ");
            }
            Console.ReadKey();
        }

        private void BuscarPorStatus()
        {

            Console.Write("Digite o status que deseja buscar(Ativo = a, Inativo = i): ");
            string op = Console.ReadLine();

    
        }


    }
}
