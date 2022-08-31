using System.IO;

namespace Sistema
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;

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

                        Endereco endPf = new Endereco();

                        Console.WriteLine("Digite seu Logradouro");
                        endPf.logradouro = Console.ReadLine();

                        Console.WriteLine("Digite o Número da sua residência caso exista, senão, pressione ENTER para pular");
                        endPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o Complemento da sua residência caso exista, senão, pressione ENTER para pular");
                        endPf.complemento = Console.ReadLine();

                        string? endComercial;

                        do
                        {
                            Console.WriteLine("Este endereço é comercial? (Sim = S ou Não = N)");

                            endComercial = Console.ReadLine().ToUpper();

                            if (endComercial == "S")
                            {
                                endPf.enderecoComercial = true;
                                break;
                            }
                            else if (endComercial == "N")
                            {
                                endPf.enderecoComercial = false;
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("A opção digitada não é válida, por favor, digite uma opção válida!");
                                Console.ResetColor();
                            }
                        } while (endComercial != "S" || endComercial != "N");

                        PessoaFisica pf = new PessoaFisica();

                        pf.endereco = endPf;

                        Console.WriteLine("Digite seu CPF (somente números)");
                        pf.cpf = Console.ReadLine();

                        Console.WriteLine("Digite seu nome");
                        pf.nome = Console.ReadLine();

                        Console.WriteLine("Digite seu salário");
                        pf.salario = float.Parse(Console.ReadLine());

                        bool dataValida = false;

                        do
                        {
                            Console.WriteLine("Digite a data de nascimento no formato [AAAA, MM, DD]");

                            try
                            {
                                DateTime dataNasc = DateTime.Parse(Console.ReadLine());

                                dataValida = pf.ValidarDataNascimento(dataNasc);

                                if (dataValida == true)
                                {
                                    pf.dataNascimento = dataNasc;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("A data digitada não é válida, por favor, digite uma data válida!");
                                    Console.ResetColor();
                                }
                            }
                            catch (System.Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("A data digitada não é válida, por favor, digite uma data válida!");
                                Console.ResetColor();
                            }
                        } while (dataValida == false);

                        listaPf.Add(pf);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Cadastro realizado com sucesso.");

                        break;
                    case "2":
                        Console.Clear();

                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {cadaPessoa.nome}
Endereço: {cadaPessoa.endereco?.logradouro}, {cadaPessoa.endereco?.numero} {cadaPessoa.endereco?.complemento}
Data de nascimento: {cadaPessoa.dataNascimento}
Taxa de imposto a ser paga é: {cadaPessoa.PagarImposto(cadaPessoa.salario).ToString("C")}
");

                                Console.WriteLine("Pressione ENTER para continuar");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lista vazia!");
                        }

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

                        break;
                    case "5":

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

        /*
         * Função para salvar o arquivo com os
         * nomes das pessoas física e jurídica
         * conforme solicitado na UC12
         * SA2 - Atividade Online 2
         */
        static void SaveFile(string fileName)
        {
            string directoryName = Directory.GetCurrentDirectory();
            string fileNameWithExtension = fileName + ".txt";
            string destinationFile = directoryName + Path.DirectorySeparatorChar + fileNameWithExtension;

            try
            {
                var stream = new StreamWriter(destinationFile);
                stream.Write("Arquivo criado!");
                stream.Close();
            }
            catch (System.Exception e)
            {
                Console.WriteLine($"Houve erro ao salvar o arquivo: {fileNameWithExtension}", e.Message);
            }
        }
    }
}
