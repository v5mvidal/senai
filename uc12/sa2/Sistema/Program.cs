using System.IO;

namespace Sistema
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
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

            Console.Write("iniciando ");
            Thread.Sleep(500);

            for (var contador = 0; contador < 10; contador++)
            {
                Console.Write("#");
                Thread.Sleep(500);
            }

            Console.Clear();

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
                        break;
                    case "2":
                        break;
                    case "0":
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
