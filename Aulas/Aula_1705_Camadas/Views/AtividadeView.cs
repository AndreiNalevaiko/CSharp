using Aula_1705_Camadas.Controllers;
using Aula_1705_Camadas.Models;
using System;

namespace Aula_1705_Camadas.Views
{
    class AtividadeView
    {
        //corrigir ID
        //Buscar Atividade, Editar, excluir
        //Solicitar confirmação na hora de editar
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }

        public void ExibirMenu()
        {
            int opcao = 9;
            do
            {
                Console.WriteLine("=======================");

                Console.WriteLine("= Escolha uma opcao: = ");
                Console.WriteLine("= 1) Criar Atividade = ");
                Console.WriteLine("= 2) Listar Atividades = ");
                Console.WriteLine("= 3) Exibir Atividade = ");
                Console.WriteLine("= 4) Buscar Atividade = ");
                Console.WriteLine("= 5) Excluir Atividade = ");
                Console.WriteLine("= 9) Sair = ");

                Console.WriteLine("=======================");

                opcao = int.Parse(Console.ReadLine());
                //return opcao;

                switch (opcao)
                {
                    case 1:
                        CriarAtividade();
                        break;
                    case 2:
                        ListarAtividade();
                        break;
                    case 3:
                        BuscarAtividade();
                        break;
                    case 4:
                        EditarAtividade();
                        break;
                    case 5:
                        ExcluirAtividade();
                        break;

                    default:
                        break;
               }
            } while (opcao != 9);
        }

        private void ExcluirAtividade()
        {
            ListarAtividade();

            Console.WriteLine("Digite o id da atividade a ser editada");
            int id = int.Parse(Console.ReadLine());

            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Excluir(id);
        }

        private void EditarAtividade()
        {
            ListarAtividade();

            Console.WriteLine("Digite o id da atividade a ser editada");
            int id = int.Parse(Console.ReadLine());

            Atividade atividadeAtualizada = ObterDadosAtividade();

            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Editar(id, atividadeAtualizada);

        }

        private void BuscarAtividade()
        {
            AtividadesController atividadeController = new AtividadesController();

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
            AtividadesController atividadeControl = new AtividadesController();
            foreach (Atividade atividade in atividadeControl.Listar())
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
            atividade.Ativo = true;
            return atividade;
        }
    }
}
