using System;

namespace GestaoDeEquipamentos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //equipamentos
            string[] nomeequipamentos = new string[1000];
            decimal[] precoAquisicao = new decimal[1000];
            int[] numeroDeSerie = new int[1000];
            string[] dataDeFabricação = new string[1000];
            string[] fabricante = new string[1000];
            int[] id = new int[1000];
            int numeroDeRegistro = 0;

            //chamadas
            string[] nomeDoChamado = new string[1000];
            string[] descricaoDoChamado = new string[1000];
            string[] dataAberturaChamado = new string[1000];
            string[] equipamentoChamado = new string[1000];
            int [] idChamados = new int [1000];
            int [] diasEmAberto = new int [1000];   
            int numeroChamados = 0;


            //menu principal  *******************


            while (true)
            {
                Console.WriteLine("Digite 1 para equipamentos\nDigite 2 para chamados\nDigite s para sair");

                string opcaomenu = Console.ReadLine();

                if (opcaomenu == "1")
                {
                    MenuEquipamentos(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id, ref equipamentoChamado);
                }
                else if (opcaomenu == "2")
                {
                    MenuChamados(ref nomeDoChamado, ref descricaoDoChamado, ref dataAberturaChamado,
            ref equipamentoChamado, ref numeroChamados, ref nomeequipamentos, ref  precoAquisicao, ref  numeroDeSerie,
            ref  dataDeFabricação, ref  fabricante, ref  numeroDeRegistro, ref  id);
                }
                else if (opcaomenu == "s")
                {
                    break;
                }
                else if (opcaomenu != "1" && opcaomenu != "2" && opcaomenu != "s")
                {
                    Console.Clear();
                    Console.WriteLine("Comando invalido\nDigite novamente");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

            }

        }
        //menu equipamentos *******************
        static void MenuEquipamentos(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id , ref string[] equipamentoChamado)
        {
            Console.WriteLine("Menu equipamentos");
            Console.WriteLine("Digite 1 para adicionar equipamento");
            Console.WriteLine("Digite 2 para editar equipamento");
            Console.WriteLine("Digite 3 para visualiza equipamento");
            Console.WriteLine("Digite 4 para excluir o equipamento");
            string opcaoEquipamentos = Console.ReadLine();


            if (opcaoEquipamentos == "1")
            {
                adicionarEquipamento(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id);

            }
            else if (opcaoEquipamentos == "2")
            {
                editarEquipamento(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id);
            }
            else if (opcaoEquipamentos == "3")
            {
                vizualizarEquipamentos(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id);
            }
            else if (opcaoEquipamentos == "4")
            {
                excluirEquipamentos(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id, ref equipamentoChamado);
            }
        }
        
        
        //menu chamados ************
        
        static void MenuChamados(ref string[] nomeDoChamado, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado,
            ref string[] equipamentoChamado, ref int numeroChamados, ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id)
        {
            Console.WriteLine("Menu chamados");
            Console.WriteLine("Digite 1 para adicionar chamados");
            Console.WriteLine("Digite 2 para editar chamados");
            Console.WriteLine("Digite 3 para visualizar chamados");
            Console.WriteLine("Digite 4 para excluir chamados");
            string opcaoChamadas = Console.ReadLine();

            if (opcaoChamadas == "1")
            {
                adicionarChamado(ref nomeDoChamado, ref  descricaoDoChamado, ref  dataAberturaChamado,
            ref  equipamentoChamado, ref numeroChamados, ref nomeequipamentos , ref  precoAquisicao, ref  numeroDeSerie,
            ref  dataDeFabricação, ref  fabricante, ref  numeroDeRegistro, ref  id);
            }
            else if (opcaoChamadas == "2")
            {
                editarChamado(ref nomeDoChamado, ref descricaoDoChamado, ref dataAberturaChamado,
            ref equipamentoChamado, ref numeroChamados);
            }
            else if (opcaoChamadas == "3")
            {
                vizualizarChamado(ref nomeDoChamado, ref descricaoDoChamado, ref dataAberturaChamado,
            ref equipamentoChamado, ref numeroChamados);
            }
            else if (opcaoChamadas == "4")
            {
                excluirChamado(ref nomeDoChamado, ref descricaoDoChamado, ref dataAberturaChamado,
            ref equipamentoChamado, ref numeroChamados);
            }



        }

        // menu dos equipamentos ****************
        static void adicionarEquipamento(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id)
        {
            string nome;
            while (true)
            {
                Console.WriteLine("Digite o nome do equipamento: ");
                nome = Console.ReadLine();

                if (nome.Length < 6)
                {
                    Console.WriteLine("Numero de caracteres menor que 6");
                    continue;
                }

                nomeequipamentos[numeroDeRegistro] = nome;

                break;

            }

            id[numeroDeRegistro] = numeroDeRegistro;

            Console.WriteLine("Digite o preço de aquisição:");
            precoAquisicao[numeroDeRegistro] = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o numero de série:");
            numeroDeSerie[numeroDeRegistro] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a data de fabricação (d/m/a):");
            dataDeFabricação[numeroDeRegistro] = Console.ReadLine();

            Console.WriteLine("Digite o nome do fabricante:");
            fabricante[numeroDeRegistro] = Console.ReadLine();


            numeroDeRegistro++;

        }

        static void editarEquipamento(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id)
        {
            //mostrar os equipamentos 
            vizualizarEquipamentos(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id);

            Console.WriteLine("Digite o ID do equipamento que queira editar: ");
            int numeroDeEdicao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite 1 para editar o nome:");
            Console.WriteLine("Digite 2 para editar o preço:");
            Console.WriteLine("Digite 3 para editar o numero de série:");
            Console.WriteLine("Digite 4 para editar o data de fabricação:");
            Console.WriteLine("Digite 5 para editar o fabricante:");
            string opcao = Console.ReadLine();

            while (true)
            {
                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
                {
                    Console.WriteLine("Opção invalida:");
                    Console.WriteLine("Digite 1 para editar o nome:");
                    Console.WriteLine("Digite 2 para editar o preço:");
                    Console.WriteLine("Digite 3 para editar o numero de série:");
                    Console.WriteLine("Digite 4 para editar o data de fabricação:");
                    Console.WriteLine("Digite 5 para editar o fabricante:");
                    opcao = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            if (opcao == "1")
            {
                Console.WriteLine("Digite o nome:");
                nomeequipamentos[numeroDeRegistro] = Console.ReadLine();
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Digite o preço:");
                precoAquisicao[numeroDeRegistro] = Convert.ToDecimal(Console.ReadLine());
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Digite o numero de série:");
                numeroDeSerie[numeroDeRegistro] = Convert.ToInt32(Console.ReadLine());
            }
            else if (opcao == "4")
            {
                Console.WriteLine("Digite a data de fabricação:");
                dataDeFabricação[numeroDeRegistro] = Console.ReadLine();
            }
            else if (opcao == "5")
            {
                Console.WriteLine("Digite o fabricante:");
                fabricante[numeroDeRegistro] = Console.ReadLine();
            }
        }

        static void vizualizarEquipamentos(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id)
        {
            if (numeroDeRegistro == 0)
            {
                Console.WriteLine("Sem equipamentos registrados");
            }

            else
            {
                for (int i = 0; i < numeroDeRegistro; i++)
                {
                    Console.WriteLine("ID: " + id[i] + "- Nome: " + nomeequipamentos[i] + "- Numero de série: " +
                        numeroDeSerie[i] + "- Fabricante: " + fabricante[i]);
                }
            }
        }

        static void excluirEquipamentos(ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id, ref string[] equipamentoChamado)
        {
            //mostrar os equipamentos 
            vizualizarEquipamentos(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id);

            Console.WriteLine("Digite o ID do equipamento que queira excluir: ");
            int idDeExclusao = Convert.ToInt32(Console.ReadLine());

            if (nomeequipamentos[idDeExclusao] == equipamentoChamado[idDeExclusao])
            {
                Console.WriteLine("Não pode ser excluido, esta com chamado aberto!! ");
            }
            else
            {
                for (int i = idDeExclusao; i < numeroDeRegistro; i++)
                {
                    nomeequipamentos[i] = nomeequipamentos[i + 1];
                    precoAquisicao[i] = precoAquisicao[i + 1];
                    numeroDeSerie[i] = numeroDeSerie[i + 1];
                    dataDeFabricação[i] = dataDeFabricação[i + 1];
                    fabricante[i] = fabricante[i + 1];

                }
                numeroDeRegistro--;
                Console.WriteLine("Equipamento excluido com sucesso !!");
            }


        }



        // Menu criação chamados *******************
        static void adicionarChamado(ref string[] nomeDoChamado, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado,
            ref string[] equipamentoChamado, ref int numeroChamados, ref string [] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id)
        {
            vizualizarEquipamentos(ref  nomeequipamentos, ref precoAquisicao, ref  numeroDeSerie,
            ref  dataDeFabricação, ref  fabricante, ref  numeroDeRegistro, ref  id); 

            Console.WriteLine("Digite o titulo do chamado: ");
            nomeDoChamado[numeroChamados] = Console.ReadLine();

            Console.WriteLine("Digite a descrição do chamado:");
            descricaoDoChamado[numeroChamados] = Console.ReadLine();

            Console.WriteLine("Digite ID do equipamento a ser feito o chamdo:");
            int posicaoId = Convert.ToInt32(Console.ReadLine());    
            equipamentoChamado[numeroChamados] = nomeequipamentos[posicaoId];

            Console.WriteLine("Digite a data de abertura (d/m/a):");
            equipamentoChamado[numeroChamados] = Console.ReadLine();

            numeroChamados++;

        }

        static void editarChamado(ref string[] nomeDoChamado, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado,
            ref string[] equipamentoChamado, ref int numeroDeRegistro)
        {

        }

        static void vizualizarChamado(ref string[] nomeDoChamado, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado,
            ref string[] equipamentoChamado, ref int numeroDeRegistro)
        {

        }

        static void excluirChamado(ref string[] nomeDoChamado, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado,
            ref string[] equipamentoChamado, ref int numeroDeRegistro)
        {

        }




    }
}















