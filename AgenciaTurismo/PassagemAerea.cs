namespace exercicioViagem.AgenciaTurismo
{
    public class PassagemAerea
    {
        public string EmpresaAera {get; set;}
        public string Classe {get; set;}
        public string Poltrona {get; set;}
        public string ValorPassagem {get; set;}
        public DateTime DiaDaViagem {get; set;}
        public DateTime HorarioDaViagem {get; set;}

        public void GetResumo()
        {
            var cliente = new Cliente();
            Console.WriteLine($"Resumo passagem: \nNome: {cliente.PrimeiroNome} \nPoltrona: {Poltrona}, Valor: {ValorPassagem}");
          
        }
        
    }
}