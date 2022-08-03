namespace Sistema
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.nome = "Manoel Vidal";
            pessoa.endereco = "Rua X";
            pessoa.enderecoComercial = false;

            Console.WriteLine(pessoa.nome);
            Console.WriteLine(pessoa.endereco);
            Console.WriteLine(pessoa.enderecoComercial);

            PessoaFisica pf = new PessoaFisica();

            pf.cpf = "498.104.490-97";
            pf.dataNascimento = new DateTime(2000, 02, 29);

            Console.WriteLine(pf.cpf);
            Console.WriteLine(pf.dataNascimento);

            PessoaJuridica pj = new PessoaJuridica();

            pj.cnpj = "68.446.883/0001-00";
            pj.razaoSocial = "X Ltda";

            Console.WriteLine(pj.cnpj);
            Console.WriteLine(pj.razaoSocial);
        }
    }
}
