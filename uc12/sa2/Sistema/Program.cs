namespace Sistema
{
    public class Program
    {
        static void Main(string[] args)
        {
            Endereco and = new Endereco();
            and.logradouro = "Rua X";
            and.numero = 100;
            and.complemento = "Qualquer coisa";
            and.enderecoComercial = false;

            PessoaFisica pf = new PessoaFisica();
            pf.endereco = and;
            pf.nome = "Fulano de Tal";
            pf.cpf = "12345678999";
            pf.dataNascimento = new DateTime(1994, 05, 19);

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
    }
}
