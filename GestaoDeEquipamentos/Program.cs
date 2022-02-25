using System;

namespace GestaoDeEquipamentos
{
    internal class Program
    {

        static string[] nomeEquipamentos = new string[1000];
        static decimal[] preçoEquipamentos = new decimal[1000];
        static int[] numeroSerieEquipamentos = new int[1000];
        static string[] dataFabricacaoEquipamentos = new string[1000];
        static string[] fabricanteEquipamentos = new string[1000];

        static int contador = 0;
        static string opcaoMenuEquipamentos;

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Digete 1 para equipamentos , 2 para chamadas e S para sair:");
                string opcaoParaMenu = Console.ReadLine();

                if (opcaoParaMenu == "1")
                {
                    menuEquipamentos();
                }
                else if (opcaoParaMenu == "2")
                {
                    menuChamados();
                }
                else if (opcaoParaMenu == "s")
                {
                    break;
                }
                else if (opcaoParaMenu != "1" && opcaoParaMenu != "2" && opcaoParaMenu != "s")
                {
                    Console.WriteLine("Digite corretamente, opção invalida.");
                    continue;
                }
            }



        }

        static void menuEquipamentos()
        {
            Console.WriteLine("Menu de Equipamentos: ");
            Console.WriteLine("Digite 1 para adicionar equipamentos: ");
            Console.WriteLine("Digite 2 para editar equipamentos: ");
            Console.WriteLine("Digite 3 para vizualizar equipamentos");
            Console.WriteLine("Digite 4 para excluir equipamento");
            opcaoMenuEquipamentos = Console.ReadLine();

            if (opcaoMenuEquipamentos == "1")
            {
                adicionarEquipamento(ref nomeEquipamentos, ref preçoEquipamentos,
                ref numeroSerieEquipamentos, ref dataFabricacaoEquipamentos,
                ref fabricanteEquipamentos, ref contador);

            }
            else if (opcaoMenuEquipamentos == "2")
            {

            }
            else if (opcaoMenuEquipamentos == "3")
            {
                vizualizarEquipamento(ref nomeEquipamentos, ref preçoEquipamentos,
                ref numeroSerieEquipamentos, ref dataFabricacaoEquipamentos,
                ref fabricanteEquipamentos, ref contador);

            }






        }

        static void menuChamados()
        {
            Console.WriteLine("Menu de Chamadas: ");
            Console.WriteLine("Digite 1 para registrar chamadas: ");
            Console.WriteLine("Digite 2 para editar as chamadas: ");
            Console.WriteLine("Digite 3 para vizualizar as chamadas: ");
            Console.WriteLine("Digite 4 para excluir as chamadas: ");
        }

        static void adicionarEquipamento(ref string[] nomeEquipamentos, ref decimal[] preçoEquipamentos,
          ref int[] numeroSerieEquipamentos, ref string[] dataFabricacaoEquipamentos,
          ref string[] fabricanteEquipamentos, ref int contador)
        {

            string nome;

            while (true)
            {
                Console.WriteLine("Insira o nome do equipamento: ");
                nome = Console.ReadLine();

                if (nome.Length < 6)
                {
                    Console.WriteLine("Nome invalido, deve conter no minimo 6 caractere:");
                    continue;
                }
                nomeEquipamentos[contador] = nome;

                break;

            }


            Console.WriteLine("Informe o preço do equipamento :");
            preçoEquipamentos[contador] = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o numero de série do equipamento:");
            numeroSerieEquipamentos[contador] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a data de fabricação do equipamento:");
            dataFabricacaoEquipamentos[contador] = Console.ReadLine();

            Console.WriteLine("Informe o fabricante do equipamento:");
            fabricanteEquipamentos[contador] = Console.ReadLine();


            // vizualizar todos os equipamentos registrados

            static void vizualizarEquipamento (ref string[] nomeEquipamentos, ref decimal[] preçoEquipamentos,
            ref int[] numeroSerieEquipamentos, ref string[] dataFabricacaoEquipamentos,
            ref string[] fabricanteEquipamentos, ref int contador)
            {
                Console.WriteLine("Nome: " + nomeEquipamentos[contador] + "- Numero de série: "
                                + numeroSerieEquipamentos[contador] + "- Fabricante: " + fabricanteEquipamentos[contador]);
            }










        }






    }
}
