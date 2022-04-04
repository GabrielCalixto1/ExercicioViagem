namespace exercicioViagem.AgenciaTurismo
{
    public class Carrinho
    {
        Cliente cliente = new Cliente();


        public double TotalCarrinho { get; set; }
        public string FormaDePagamento { get; set; }

        public void Comprar(string opcao)
        {
            bool prosseguir = true;
            do
            {
                if (opcao == "1")
                {
                    Console.WriteLine($"Ok {cliente.PrimeiroNome} para onde irá?");
                    Console.WriteLine("Digite a opção: \n1- Canadá \n2- Eua 3- Los Angeles");
                    var enfeite = Console.ReadLine();
                    Console.WriteLine("Qual classe irá? A ou B? ");
                    var classeVoo = Console.ReadLine();
                    // Simplificar perguntas para Passagem Aerea
                }
                else if (opcao == "2")
                {
                    Console.WriteLine($"Ok {cliente.PrimeiroNome} para onde irá?");
                    Console.WriteLine("Digite a opção: \n1- Canadá \n2- Eua 3- Los Angeles");
                    var enfeite = Console.ReadLine();
                    Console.WriteLine("Qual classe irá? A ou B? ");
                    var classeVoo = Console.ReadLine();
                    // Simplificar perguntas para Pacotes
                }
                else
                {
                    Console.WriteLine("Opção Inválida!! Deseja tentar novamente? ");
                    prosseguir = cliente.MarqueAOpcao();
                }
            } while (prosseguir);
        }


        public void FormaDePagamentoCliente()
        {

            bool continuar = false;
            do
            {

                Console.WriteLine("Como será o pagamento? \n1- Dinheiro \n2- Cartão de Crédito \n3- Cartão de Débito");
                string escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        {
                            FormaDePagamento = "VISTA";
                            Console.WriteLine("Pagamento em dinheiro escolhido.");
                            break;
                        }
                    case "2":
                        {
                            FormaDePagamento = "CREDITO";
                            Console.WriteLine("Pagamento com cartão de crédito escolhido.");
                            break;
                        }
                    case "3":
                        {
                            FormaDePagamento = "DEBITO";
                            Console.WriteLine("Pagamento com cartão de débito escolhido.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção invádida! Deseja tentar novamente?");

                            continuar = cliente.MarqueAOpcao();
                            break;
                        }
                }
            } while (continuar);
        }

        public double Desconto()
        {
            double TotalAtualizado = 0;
            if (TotalCarrinho >= 500 && TotalCarrinho <= 4999)
            {
                TotalAtualizado = TotalCarrinho - (TotalCarrinho * 0.05);

            }
            else if (TotalCarrinho >= 5000)
            {
                TotalAtualizado = TotalCarrinho - (TotalCarrinho * 0.10);
            }
            return TotalAtualizado;

        }
    }
}




