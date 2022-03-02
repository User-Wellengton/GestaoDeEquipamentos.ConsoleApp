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
            int[] idChamados = new int[1000];

            int numeroChamados = 0;


            //menu principal  *******************


            while (true)
            {
                Console.WriteLine("Digite 1 para equipamentos\nDigite 2 para chamados\nDigite s para sair");

                string opcaomenu = Console.ReadLine();

                if (opcaomenu == "1")
                {
                    MenuEquipamentos(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id, ref equipamentoChamado, ref numeroChamados);
                }
                else if (opcaomenu == "2")
                {
                    MenuChamados(ref nomeDoChamado, ref descricaoDoChamado, ref dataAberturaChamado,
            ref equipamentoChamado, ref numeroChamados, ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id, ref idChamados);
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
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id, ref string[] equipamentoChamado,
            ref int numeroChamados)
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
                excluirEquipamentos(ref  nomeequipamentos, ref  precoAquisicao, ref  numeroDeSerie,
            ref  dataDeFabricação, ref  fabricante, ref  numeroDeRegistro, ref  id, ref  equipamentoChamado,
            ref  numeroChamados);
            }

        }

        //menu chamados ************

        static void MenuChamados(ref string[] nomeDoChamado, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado,
            ref string[] equipamentoChamado, ref int numeroChamados, ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id, ref int[] idChamados)
        {
            Console.WriteLine("Menu chamados");
            Console.WriteLine("Digite 1 para adicionar chamados");
            Console.WriteLine("Digite 2 para editar chamados");
            Console.WriteLine("Digite 3 para visualizar chamados");
            Console.WriteLine("Digite 4 para excluir chamados");
            string opcaoChamadas = Console.ReadLine();

            if (opcaoChamadas == "1")
            {
                adicionarChamado(ref nomeDoChamado, ref descricaoDoChamado, ref dataAberturaChamado,
            ref equipamentoChamado, ref numeroChamados, ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id, ref idChamados);
            }
            else if (opcaoChamadas == "2")
            {
                editarChamado(ref nomeDoChamado, ref descricaoDoChamado, ref dataAberturaChamado,
            ref equipamentoChamado, ref numeroChamados, ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id, ref idChamados);
            }
            else if (opcaoChamadas == "3")
            {
                vizualizarChamado(ref nomeDoChamado, ref descricaoDoChamado, ref dataAberturaChamado,
                ref equipamentoChamado, ref numeroDeRegistro, ref nomeequipamentos,
            ref idChamados, ref numeroChamados);
            }
            else if (opcaoChamadas == "4")
            {
                excluirChamado(ref nomeDoChamado, ref descricaoDoChamado, ref dataAberturaChamado,
                ref equipamentoChamado, ref numeroDeRegistro, ref nomeequipamentos,
            ref idChamados, ref numeroChamados);
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
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id, ref string[] equipamentoChamado,
            ref int numeroChamados)
        {
            //mostrar os equipamentos 
            vizualizarEquipamentos(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id);

            Console.WriteLine("Digite o ID do equipamento que queira excluir: ");
            int idDeExclusao = Convert.ToInt32(Console.ReadLine());


            int quantiaDeGiros = 0;
            bool podeExcluir = true;
            if (numeroDeRegistro == 0)
            {
                Console.WriteLine("Sem nenhum equipamentos registrado!");
            }
            else
            {
                if (numeroDeRegistro > numeroChamados)
                {
                    quantiaDeGiros = numeroDeRegistro;
                }
                else
                {
                    quantiaDeGiros = numeroChamados;
                }
                for (int i = 0; i < quantiaDeGiros; i++)
                {
                    if (equipamentoChamado[i] == nomeequipamentos[idDeExclusao])
                    {
                        podeExcluir = false;
                    }
                }
                if (podeExcluir == false)
                {
                    Console.WriteLine("equipamento atrelado a um chamado");
                }


                if (podeExcluir == true)
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
        }



        // Menu criação chamados *******************
        static void adicionarChamado(ref string[] nomeDoChamado, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado,
            ref string[] equipamentoChamado, ref int numeroChamados, ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id, ref int[] idChamados)
        {
            vizualizarEquipamentos(ref nomeequipamentos, ref precoAquisicao, ref numeroDeSerie,
            ref dataDeFabricação, ref fabricante, ref numeroDeRegistro, ref id);

            Console.WriteLine("Digite o titulo do chamado: ");
            nomeDoChamado[numeroChamados] = Console.ReadLine();

            Console.WriteLine("Digite a descrição do chamado:");
            descricaoDoChamado[numeroChamados] = Console.ReadLine();

            Console.WriteLine("Digite ID do equipamento a ser feito o chamdo:");
            int posicaoId = Convert.ToInt32(Console.ReadLine());
            equipamentoChamado[numeroChamados] = nomeequipamentos[posicaoId];

            Console.WriteLine("Digite a data de abertura (d/m/a):");
            dataAberturaChamado[numeroChamados] = Console.ReadLine();

            idChamados[numeroChamados] = numeroChamados;

            numeroChamados++;

        }

        // editar chamados ***********
        static void editarChamado(ref string[] nomeDoChamado, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado,
            ref string[] equipamentoChamado, ref int numeroChamados, ref string[] nomeequipamentos, ref decimal[] precoAquisicao, ref int[] numeroDeSerie,
            ref string[] dataDeFabricação, ref string[] fabricante, ref int numeroDeRegistro, ref int[] id, ref int[] idChamados)
        {
            vizualizarChamado(ref nomeDoChamado, ref descricaoDoChamado, ref dataAberturaChamado,
                ref equipamentoChamado, ref numeroDeRegistro, ref nomeequipamentos,
            ref idChamados, ref numeroChamados);

            Console.WriteLine("Digite o ID do chamado que queira editar: ");
            int numeroDeEdicao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite 1 para editar o titulo do chamado:");
            Console.WriteLine("Digite 2 para editar a descrição do chamado:");
            Console.WriteLine("Digite 3 para editar o equipamento do chamado:");
            Console.WriteLine("Digite 4 para editar a data de abertura do chamado:");

            string opcao = Console.ReadLine();

            while (true)
            {
                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
                {
                    Console.WriteLine("Opção invalida:");
                    Console.WriteLine("Digite 1 para editar o titulo do chamado:");
                    Console.WriteLine("Digite 2 para editar a descrição do chamado:");
                    Console.WriteLine("Digite 3 para editar o equipamento do chamado:");
                    Console.WriteLine("Digite 4 para editar a data de abertura do chamado:");

                    opcao = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            if (opcao == "1")
            {
                Console.WriteLine("Digite o novo titulo do chamado:");
                nomeDoChamado[numeroDeEdicao] = Console.ReadLine();
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Digite a nova descrição do chamado:");
                descricaoDoChamado[numeroDeEdicao] = Console.ReadLine();
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Digite o ID do novo equipamento do chamado:");
                int idSeletivo = Convert.ToInt32(Console.ReadLine());
                equipamentoChamado[numeroDeEdicao] = nomeequipamentos[idSeletivo];
            }
            else if (opcao == "4")
            {
                Console.WriteLine("Digite a nova data de abertura do chamado:");
                dataAberturaChamado[numeroDeEdicao] = Console.ReadLine();
            }



        }

        //vizualizar chamados ***********
        static void vizualizarChamado(ref string[] nomeDoChamado, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado,
                ref string[] equipamentoChamado, ref int numeroDeRegistro, ref string[] nomeequipamentos,
            ref int[] idChamados, ref int numeroChamados)
        {
            if (numeroChamados == 0)
            {
                Console.WriteLine("Sem chamadas registradas");
            }
            else
            {
                for (int i = 0; i < numeroChamados; i++)
                {
                    Console.WriteLine("ID chamados" + idChamados[i] + "- Título chamado:" + nomeDoChamado[i] +
                        "- Equipamento: " + equipamentoChamado[i] + "- Data de abertura" +
                        dataAberturaChamado[i]);


                    DateTime hoje = DateTime.Now;
                    string strDataAbertoChamado = dataAberturaChamado[i];
                    string[] dataSeparada = strDataAbertoChamado.Split("/");
                    int dia = int.Parse(dataSeparada[0]);    //0   1   2
                    int mes = int.Parse(dataSeparada[1]);   // 02 /03 /2022
                    int ano = int.Parse(dataSeparada[2]);
                    DateTime criacaoDoChamado = new DateTime(ano, mes, dia);
                    int diasAberto = (hoje - criacaoDoChamado).Days;
                    Console.Write("Dias em aberto......: ");
                    Console.WriteLine(diasAberto + " dias...");
                    Console.WriteLine();

                }
            }

        }

        //excluir chamados ***************
        static void excluirChamado(ref string[] nomeDoChamado, ref string[] descricaoDoChamado, ref string[] dataAberturaChamado,
                ref string[] equipamentoChamado, ref int numeroDeRegistro, ref string[] nomeequipamentos,
            ref int[] idChamados, ref int numeroChamados)
        {
            vizualizarChamado(ref nomeDoChamado, ref descricaoDoChamado, ref dataAberturaChamado,
                ref equipamentoChamado, ref numeroDeRegistro, ref nomeequipamentos,
            ref idChamados, ref numeroChamados);

            Console.WriteLine("Digite o ID do chamado que queira excluir: ");
            int idDeExclusao = Convert.ToInt32(Console.ReadLine());

            if (numeroChamados == 0)
            {
                Console.WriteLine("Não pode ser excluido, esta com chamado aberto!! ");
            }
            else
            {
                for (int i = idDeExclusao; i < numeroChamados; i++)
                {
                    nomeDoChamado[i] = nomeDoChamado[i + 1];
                    descricaoDoChamado[i] = descricaoDoChamado[i + 1];
                    dataAberturaChamado[i] = dataAberturaChamado[i + 1];
                    equipamentoChamado[i] = equipamentoChamado[i + 1];

                }
                numeroDeRegistro--;
                Console.WriteLine("Chamado excluido com sucesso !!");

            }






        }


    }

}
















