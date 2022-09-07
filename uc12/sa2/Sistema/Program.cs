using System.IO;

namespace Sistema
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            List<PessoaFisica> listaPf = new List<PessoaFisica>();

            static void BarraCarregamento(string texto)
            {
                Console.Write(texto);
                Thread.Sleep(500);

                for (var contador = 0; contador < 10; contador++)
                {
                    Console.Write("$");
                    Thread.Sleep(500);
                }
            }

            Console.WriteLine(@$"
===================================================
!                                                 !
!                                                 !
!         Seja Bem Vindo ao nosso Sistema         !
!              de Cadastro de Pessoa              !
!                Física e Jurídica                !
!                                                 !
!                                                 !
===================================================
");

            // BarraCarregamento("Iniciando ");

            string? opcao;

            do
            {
                Console.WriteLine(@$"
===================================================
!          Escolha uma das opcões abaixo          !
===================================================
!                                                 !
!                  PESSOA FÍSICA                  !
!           1 - Cadastrar Pessoa Física           !
!           2 - Listar Pessoa Física              !
!           3 - Remover Pessoa Física             !
!                                                 !
!                 PESSOA JURÍDICA                 !
!           4 - Cadastrar Pessoa Jurídica         !
!           5 - Listar Pessoa Jurídica            !
!           6 - Remover Pessoa Jurídica           !
===================================================
!           0 - Sair                              !
===================================================
");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();

                        // Endereco endPf = new Endereco();

                        // Console.WriteLine("Digite seu Logradouro");
                        // endPf.logradouro = Console.ReadLine();

                        // Console.WriteLine("Digite o Número da sua residência caso exista, senão, pressione ENTER para pular");
                        // endPf.numero = int.Parse(Console.ReadLine());

                        // Console.WriteLine("Digite o Complemento da sua residência caso exista, senão, pressione ENTER para pular");
                        // endPf.complemento = Console.ReadLine();

                        // string? endComercial;

                        // do
                        // {
                        //     Console.WriteLine("Este endereço é comercial? (Sim = S ou Não = N)");

                        //     endComercial = Console.ReadLine().ToUpper();

                        //     if (endComercial == "S")
                        //     {
                        //         endPf.enderecoComercial = true;
                        //         break;
                        //     }
                        //     else if (endComercial == "N")
                        //     {
                        //         endPf.enderecoComercial = false;
                        //         break;
                        //     }
                        //     else
                        //     {
                        //         Console.ForegroundColor = ConsoleColor.DarkRed;
                        //         Console.WriteLine("A opção digitada não é válida, por favor, digite uma opção válida!");
                        //         Console.ResetColor();
                        //     }
                        // } while (endComercial != "S" || endComercial != "N");

                        // PessoaFisica pf = new PessoaFisica();

                        // pf.endereco = endPf;

                        // Console.WriteLine("Digite seu CPF (somente números)");
                        // pf.cpf = Console.ReadLine();

                        // Console.WriteLine("Digite seu nome");
                        // pf.nome = Console.ReadLine();

                        // Console.WriteLine("Digite seu salário");
                        // pf.salario = float.Parse(Console.ReadLine());

                        // bool dataValida = false;

                        // do
                        // {
                        //     Console.WriteLine("Digite a data de nascimento no formato [AAAA, MM, DD]");

                        //     try
                        //     {
                        //         DateTime dataNasc = DateTime.Parse(Console.ReadLine());

                        //         dataValida = pf.ValidarDataNascimento(dataNasc);

                        //         if (dataValida == true)
                        //         {
                        //             pf.dataNascimento = dataNasc;
                        //         }
                        //         else
                        //         {
                        //             Console.ForegroundColor = ConsoleColor.DarkRed;
                        //             Console.WriteLine("A data digitada não é válida, por favor, digite uma data válida!");
                        //             Console.ResetColor();
                        //         }
                        //     }
                        //     catch (System.Exception)
                        //     {
                        //         Console.ForegroundColor = ConsoleColor.DarkRed;
                        //         Console.WriteLine("A data digitada não é válida, por favor, digite uma data válida!");
                        //         Console.ResetColor();
                        //     }
                        // } while (dataValida == false);

                        // listaPf.Add(pf);

                        // Console.ForegroundColor = ConsoleColor.DarkGreen;
                        // Console.WriteLine("Cadastro realizado com sucesso.");

                        PessoaFisica pf = new PessoaFisica();

                        Console.WriteLine("Digite seu nome");
                        pf.nome = Console.ReadLine();

                        Console.WriteLine("Digite seu CPF (somente números)");
                        pf.cpf = Console.ReadLine();

                        // StreamWriter sw = new StreamWriter($"{pf.nome}.txt");
                        // sw.Write($"{pf.nome}");
                        // sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{pf.nome}.txt"))
                        {
                            sw.Write($"O nome da pessoa é {pf.nome}, e o CPF é {pf.cpf}");
                        }

                        break;
                    case "2":
                        Console.Clear();

                        // if (listaPf.Count > 0)
                        // {
                        //                             foreach (PessoaFisica cadaPessoa in listaPf)
                        //                             {
                        //                                 Console.Clear();
                        //                                 Console.WriteLine(@$"
                        // Nome: {cadaPessoa.nome}
                        // Endereço: {cadaPessoa.endereco?.logradouro}, {cadaPessoa.endereco?.numero} {cadaPessoa.endereco?.complemento}
                        // Data de nascimento: {cadaPessoa.dataNascimento}
                        // Taxa de imposto a ser paga é: {cadaPessoa.PagarImposto(cadaPessoa.salario).ToString("C")}
                        // ");

                        //                                 Console.WriteLine("Pressione ENTER para continuar");
                        //                                 Console.ReadLine();
                        //                             }
                        // }
                        // else
                        // {
                        //     Console.WriteLine("Lista vazia!");
                        // }

                        Console.WriteLine("Digite o nome da pessoa");
                        string? pessoa = Console.ReadLine();

                        using (StreamReader sr = new StreamReader($"{pessoa}.txt"))
                        {
                            string linha;

                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                        }

                        Console.WriteLine("Pressione ENTER para continuar");
                        Console.ReadLine();

                        break;
                    case "3":
                        Console.Clear();

                        Console.WriteLine("Digite o CPF para remover (somente números)");
                        string? cpfProcurado = Console.ReadLine();

                        PessoaFisica? pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

                        if (pessoaEncontrada != null)
                        {
                            listaPf.Remove(pessoaEncontrada);
                            Console.WriteLine("A pessoa física ligada ao CPF foi removida.");
                        }
                        else
                        {
                            Console.WriteLine("CPF não encontrado!");
                        }

                        break;
                    case "4":
                        Console.Clear();

                        novaPj.nome = "Nome PJ";
                        novaPj.cnpj = "00.000.000/0001-00";
                        novaPj.razaoSocial = "Razão Social Pj";

                        novoEndPj.logradouro = "Alameda Barão de Limeira";
                        novoEndPj.numero = 539;
                        novoEndPj.complemento = "SENAI Informática";
                        novoEndPj.enderecoComercial = true;

                        novaPj.endereco = novoEndPj;

                        novaPj.Inserir(novaPj);

                        break;
                    case "5":

                        List<PessoaJuridica> listaPj = novaPj.Ler();

                        foreach (PessoaJuridica cadaItem in listaPj)
                        {
                            Console.Clear();
                            Console.WriteLine($@"
                            Nome: {cadaItem.nome}
                            Razão Social: {cadaItem.nome}
                            CNPJ: {cadaItem.cnpj}
                            ");
                        }

                        Console.WriteLine("Pressione ENTER para continuar");
                        Console.ReadLine();

                        break;
                    case "6":

                        break;
                    case "0":
                        Console.WriteLine("Obrigado por utilizar o nosso sistema.");

                        break;
                    default:
                        Console.WriteLine("Opcão inválida, por favor digite uma das opções apresentadas.");

                        break;
                }
            } while (opcao != "0");

            Console.ResetColor();
        }
    }
}
