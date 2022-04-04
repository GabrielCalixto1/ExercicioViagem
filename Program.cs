/*Desafio de hoje:


voo (que deverá ter numero, horário, destino e origem) 
e a escala (formada pela duração, local e horário de chegada) 


Portanto as vendas poderão conter uma ou várias passagens aéreas 
assim como um ou vários pacotes de turismo, 
além da forma de pagamento (dinheiro ou cartão de débito/crédito), 
dos dados do cliente (nome, cpf e nascimento) e do valor total. 
Considere também dados comuns para armazenamento de dados dos funcionários.

⦁	Garanta que os valores monetários não aceitem valores negativos;


*/
namespace exercicioViagem.AgenciaTurismo;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seja bem vindo à Agência de Turismo DoDev");
        var cliente = new Cliente();
        cliente.PegarDadosDoCliente();
        Console.WriteLine("O que deseja comprar?\n1- Passagens Aéreas \n2- Pacotes de Viagem");
        
    }
}