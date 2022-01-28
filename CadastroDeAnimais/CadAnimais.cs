using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAnimais
{
    class CadAnimais
    {
        public static int Menu()
        {
            string operacao;
            var menuOp = new MenuOp();
            var menuOp2 = new MenuOp();
            bool validador = false;
            menuOp.MostrarMenu(); //Apresenta o menu
            decimal opcao;
            do
            {
                Console.WriteLine("Opção: "); //Valida as opções
                operacao = Console.ReadLine();
                if (operacao == "1")
                {
                    validador = true;
                }
                else if (operacao == "2")
                {
                    validador = true;
                }
                else if (operacao == "3")
                {
                    validador = true;
                }
                else if (operacao == "4")
                {
                    validador = true;
                }
                else if (operacao == "5")
                {
                    validador = true;
                }
                else if (operacao == "6")
                {
                    validador = true;
                }
                else if (operacao == "7")
                {
                    validador = true;
                }
                else
                {
                    Console.WriteLine("Opção invalida! Tente novamente!");
                    validador = false;
                }
            } while (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" && operacao != "6" && operacao != "7");
            return Convert.ToInt32(operacao); //Validação
        }
        public static void Main()
        {
            FuncoesAnimais funcG = new FuncoesAnimais();
            List<Animal> lista = new List<Animal>();
            decimal peso, idade, isNumero;
            double isNumero2;
            string entrada, entrada2, operacao2, racaAnimal = "";
            bool valida, valido;
            var versao = new Menu(); //Pega o menu
            int id = 0;
            versao.ApresentarHora(); //Mostra o dia e horas
            int opcao = 1;
            while (opcao != 7) 
            {
                opcao = Convert.ToInt32(Menu());
                Animal animal = new Animal();
                switch (opcao)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("-----------------Cadastro de Animais---------------");
                            Console.WriteLine("Digite as informações básicas do animal:");
                            do
                            {
                                Console.WriteLine("Idade: ");
                                entrada = Console.ReadLine();
                                valido = decimal.TryParse(entrada, out isNumero);
                                if (!valido || isNumero <= 0 || isNumero >= 40)
                                {
                                    Console.WriteLine("Idade não pode ser 0 ou maior que 40");
                                }
                            } while (!valido || isNumero <= 0 || isNumero >= 100);
                            idade = isNumero;
                            do
                            {
                                Console.WriteLine("Peso: ");
                                entrada2 = Console.ReadLine();
                                valido = decimal.TryParse(entrada2, out isNumero);
                                if (!valido || isNumero <= 0 || isNumero >= 155)
                                {
                                    Console.WriteLine("Peso não pode ser 0 ou maior que 155 ");
                                }
                            }
                            while (!valido || isNumero <= 0 || isNumero >= 155);
                            peso = isNumero;
                            {
                                bool validador2 = false;
                                //Raposa raposa = new Raposa();
                                do
                                {
                                    Console.WriteLine("Agora escolha qual tipo de animal ira ser cadastrado:" +
                                       "\n1 - Gato" +
                                       "\n2 - Cachorro" +
                                       "\n3 - Raposa");
                                    Console.WriteLine("Opção: ");
                                    operacao2 = Console.ReadLine();
                                    if (operacao2 == "1")  /* Quando eu escrevi isso somente Deus e eu sabíamos o que eu estava fazendo. Agora só Deus sabe */
                                    {
                                        Console.Write("Raça: ");
                                        string raca = Console.ReadLine();

                                        Console.WriteLine("Tipo de animal cadastrado com sucesso");
                                        validador2 = true;
                                        lista.Add(new Gato(idade, peso, raca));

                                    }
                                    else if (operacao2 == "2")
                                    {
                                        Console.WriteLine("Nome: ");
                                        string nome = Console.ReadLine();

                                        Console.WriteLine("Tipo de animal cadastrado com sucesso");
                                        validador2 = true;
                                        lista.Add(new Cachorro(idade, peso, nome));

                                    }
                                    else if (operacao2 == "3")
                                    {
                                        Console.WriteLine("Tipo de animal cadastrado com sucesso");
                                        validador2 = true;
                                        lista.Add(new Raposa(idade, peso));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opção invalida! Tente Novamente!");
                                        validador2 = false;
                                    }

                                } while (operacao2 != "1" && operacao2 != "2" && operacao2 != "3" && operacao2 != "4");
                            }
                            valida = true;
                        }
                        while (!valida);
                        Console.WriteLine("Voltando para o menu. Clique em qualquer tecla.");
                        Console.ReadKey();
                        break;

                    case 2: //Excluir
                        Console.WriteLine("---------------------- Excluir Animais -----------------------");
                        Console.WriteLine("Qual grupo de animal você quer excluir");
                        Console.WriteLine("\n1 - Gato" +
                            "\n2 - Cachorro" +
                            "\n3 - Raposa");

                        Console.WriteLine("Opção: "); //Opção para escolher qual tipo de animal sera excluido
                        operacao2 = Console.ReadLine();
                        if (operacao2 == "1")
                        {
                            lista.RemoveAll(x => x is Gato);
                        }
                        break;
                        if (operacao2 == "2")
                        {
                            lista.RemoveAll(x => x is Cachorro);
                        }
                        if (operacao2 == "3")
                        {
                            lista.RemoveAll(x => x is Raposa);
                        }
                        else
                        {
                            Console.WriteLine("Operação invalida. Tente novamente!");

                        } while (operacao2 != "1" && operacao2 != "2" && operacao2 != "3") ;

                    case 3: //Listar gato
                        if (lista.Count > 0)
                        {
                            Console.WriteLine("-------------------- Listar Gato --------------------");
                            foreach (var a in lista.FindAll(x => x is Gato)) //Metodo para ele ver achar todos os gatos cadastrados
                            {
                                Console.WriteLine(a.ToString());
                                Console.WriteLine("--------------------------------------------------------------\n");
                            }
                        }     
                        else
                        {
                            Console.WriteLine("Não há gatos cadastrados");
                        }
                        Console.WriteLine("Voltando para o menu. Pressione em qualquer tecla.");
                        Console.ReadKey();
                        break;
                    case 4: //Listar cachorro
                        if (lista.Count > 0)
                        {
                            Console.WriteLine("-------------------- Listar Cachorro --------------------");
                            foreach (var a in lista.FindAll(x => x is Cachorro))
                            {
                                Console.WriteLine(a.ToString());
                                Console.WriteLine("--------------------------------------------------------------\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há cachorros cadastrados");
                        }
                        Console.WriteLine("Voltando para o menu. Pressione em qualquer tecla.");
                        Console.ReadKey();
                        break ;
                    case 5:
                        if (lista.Count > 0)
                        {
                            Console.WriteLine("----------------------Listar Raposas--------------------");
                            foreach (var a in lista.FindAll(x => x is Raposa))
                            {
                                Console.WriteLine(a.ToString());
                                Console.WriteLine("-------------------------------------------------------------\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há raposas cadastradas");
                        }
                        Console.WriteLine("Voltando para o menu. Precione em qualquer tecla");
                        Console.ReadKey();
                        break;

                    case 6:
                        if (lista.Count > 0)
                        {
                            Console.WriteLine("-------------------- Listar todos os animais --------------------");
                            foreach (var a in lista)
                            {
                                Console.WriteLine(a.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há animais registrados.");
                        }
                        Console.WriteLine("Voltando para o menu. Pressione em qualquer tecla.");
                        Console.ReadKey();
                        break;

                    case 7: //fechamento do programa
                        Console.WriteLine("Obrigado por usar o programa.");
                        break;
                }
            }
        }
    }
}