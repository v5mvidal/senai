using System.IO;

namespace Sistema
{
    public class Program
    {
        static void Main(string[] args)
        {
            static void BarraCarregamento(string texto)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;

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

            BarraCarregamento("Iniciando ");

            string? opcao;

            do
            {
                Console.WriteLine(@$"
===================================================
!          Escolha uma das opcões abaixo          !
===================================================
!              1 - Pessoa Física                  !
!              2 - Pessoa Jurídica                !
!                                                 !
!              0 - Sair                           !
!                                                 !
===================================================
");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Endereco endPf = new Endereco();

                        endPf.logradouro = "Rua Niteroi";
                        endPf.numero = 180;
                        endPf.complemento = "Escola SENAI Paulo Skaf";
                        endPf.enderecoComercial = false;

                        PessoaFisica Lucas = new PessoaFisica();
                        Lucas.cpf = "238.444.420-49";
                        Lucas.dataNascimento = new DateTime(2004, 08, 21);
                        Lucas.endereco = endPf;
                        Lucas.nome = "Lucas Rodriguez Sinni";

                        Console.WriteLine(@$"Nome: {Lucas.nome}
CPF: {Lucas.cpf}
Nascido em {Lucas.dataNascimento.ToString("dd/MM/yyyy")}
Endereço: {endPf.logradouro}, {endPf.numero}");

                        Console.WriteLine();
                        break;
                    case "2":
                        Endereco endPj = new Endereco();

                        endPj.logradouro = "Rua Niteroi";
                        endPj.numero = 180;
                        endPj.complemento = "Escola SENAI Paulo Skaf";
                        endPj.enderecoComercial = true;

                        PessoaJuridica pj = new PessoaJuridica();
                        pj.cnpj = "48.729.118/0001-81";
                        pj.endereco = endPj;
                        pj.razaoSocial = "Pessoa Jurídica";
                        pj.nome = "Jequiti";

                        Console.WriteLine(pj.cnpj);
                        break;
                    case "0":
                        Console.WriteLine("Obrigado por utilizar o nosso sistema");
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
