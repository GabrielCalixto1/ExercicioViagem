namespace exercicioViagem.AgenciaTurismo
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataDeNasc { get; set; }

public Cliente(string nome, string cpf, DateTime dataDeNasc)
{
    Nome = nome;
    CPF = cpf;
    DataDeNasc = dataDeNasc;

}
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
    }
}
