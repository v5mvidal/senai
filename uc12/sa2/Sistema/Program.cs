using System.IO;

namespace Sistema
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Endereco and = new Endereco();
            and.logradouro = "Rua X";
            and.numero = 100;
            and.complemento = "Qualquer coisa";
            and.enderecoComercial = false;

            PessoaFisica pf = new PessoaFisica();
            pf.endereco = and;
            pf.nome = "Fulano de Tal";
            pf.cpf = "123.456.789-99";
            pf.dataNascimento = new DateTime(1994, 05, 19);

            SaveFile(pf.nome);

            PessoaJuridica pj = new PessoaJuridica();
            pj.endereco = and;
            pj.razaoSocial = "Fulano Ltda";
            pj.cnpj = "12.345.678/0001-99";

            SaveFile(pj.razaoSocial);

            // Interpolação
            Console.WriteLine($"O {pf.nome} mora na Rua: {pf.endereco.logradouro} número {pf.endereco.numero}");
            // Concatenação
            Console.WriteLine("O " + pf.nome + " mora na Rua: " + pf.endereco.logradouro + " número " + pf.endereco.numero);

            bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

            Console.WriteLine(idadeValida);

            if (idadeValida == true) {
                System.Console.WriteLine("Cadastro Aprovado");
            } else {
                Console.WriteLine("Cadastro Reprovado");
            }
        }

        /*
         * Função para salvar o arquivo com os
         * nomes das pessoas física e jurídica
         * conforme solicitado na UC12
         * SA2 - Atividade Online 2
         */
        static void SaveFile(string fileName) {
            string directoryName = Directory.GetCurrentDirectory();
            string fileNameWithExtension = fileName + ".txt";
            string destinationFile = directoryName + Path.DirectorySeparatorChar + fileNameWithExtension;

            var stream = new StreamWriter(destinationFile);
            stream.Write("Arquivo criado!");
            stream.Close();
        }
    }
}
