namespace exercicioViagem.AgenciaTurismo
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataDeNasc { get; set; }
        
        public bool MarqueAOpcao()
        {
            bool continuar = true;

            do
            {

                Console.WriteLine("'S' para SIM e 'N' para NÃO");
                var nome = Console.ReadLine();
                if (nome == "S" || nome == "s")
                {
                    return continuar;
                }
                else if (nome == "N" || nome == "n")
                {
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Opção Inválida!! Insira novamente");
                }
            } while (continuar);

            return continuar;
        }

        public string PrimeiroNome(string nome)
        {
            var nomeCompleto = Nome;
            var nomeDividido = nomeCompleto.Split(' ');
            var primeiroNome = nomeDividido[0];
            return primeiroNome;

        }
        public void PegarDadosDoCliente()
        {
            string nome;
            bool continuar = true;
            do
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
                int nomeLetras = nome.Length;

                if (nomeLetras < 5)
                {
                    Console.WriteLine("Nome inválido!!");

                }
                else if (nomeLetras > 55)
                {
                    Console.WriteLine("Nome inválido!!");
                }
                else
                {
                    continuar = false;
                }
            } while (continuar);

            Console.WriteLine("Digite seu CPF :");
            var cpf = Console.ReadLine();
            Console.WriteLine("Digite sua data de nascimento: Ex: MM/DD/AA ");
            var dataNasc = DateTime.Parse(Console.ReadLine());
            Nome = nome;
            CPF = cpf;
            DataDeNasc = dataNasc;
        }


    }
}
