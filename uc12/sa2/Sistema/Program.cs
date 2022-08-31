using System.IO;

namespace Sistema
{
    public class Program
    {
        static void Main(string[] args)
        {
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

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;

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
                        Endereco endPf = new Endereco();

                        Console.WriteLine("Digite seu Logradouro");
                        endPf.logradouro = Console.ReadLine();

                        Console.WriteLine("Digite o Número da sua residência caso exista, senão, pressione ENTER para pular");
                        endPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o Complemento da sua residência caso exista, senão, pressione ENTER para pular");
                        endPf.complemento = Console.ReadLine();

                        Console.WriteLine("Este endereço é comercial? (Sim = S ou Não = N)");
                        string endComercial = Console.ReadLine().ToUpper();

                        do
                        {
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
                                Console.WriteLine("Informe se o seu endereço é comercial com Sim = S ou Não = N");
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

                        Console.WriteLine("Informe sua data de nascimento no formato [AAAA, MM, DD]");
                        pf.dataNascimento = DateTime.Parse(Console.ReadLine());

                        bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

                        if (idadeValida == true)
                        {
                            Console.WriteLine("Cadastro aprovado");
                            listaPf.Add(pf);
                            Console.WriteLine(pf.PagarImposto(pf.salario));
                        }
                        else
                        {
                            Console.WriteLine("Cadastro não aprovado");
                        }

                        break;
                    case "2":
                        foreach (var cadaItem in listaPf) {
                            Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}");
                        }

                        break;
                    case "3":
                        Console.WriteLine("Digite o CPF para remover (somente números)");
                        string cpfProcurado = Console.ReadLine();

                        PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

                        if (pessoaEncontrada != null) {
                            listaPf.Remove(pessoaEncontrada);
                            Console.WriteLine("A pessoa ligada ao CPF foi removida");
                        } else {
                            Console.WriteLine("CPF não encontrado");
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
