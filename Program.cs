﻿/*Desafio de hoje:

Seu cliente é uma agência de turismo que vende pacotes de viagem 
ou somente passagens aéreas. 
Os pacotes possuem, além da data de ida, 
a data da volta e o valor do pacote, uma série de serviços 
que ficam a critério do cliente contratar, 

como: almoço (que possui valor), jantar (que possui valor), 
café da manhã (que possui valor) e passeios locais (que possuem valor, 
local do passeio e horário). 
Já a passagem aérea contém a empresa aérea, classe, poltrona, valor, 
horário de embarque, data da passagem, 

voo (que deverá ter numero, horário, destino e origem) 
e a escala (formada pela duração, local e horário de chegada) 
e qualquer outro atributo que julgar necessário. 

Portanto as vendas poderão conter uma ou várias passagens aéreas 
assim como um ou vários pacotes de turismo, 
além da forma de pagamento (dinheiro ou cartão de débito/crédito), 
dos dados do cliente (nome, cpf e nascimento) e do valor total. 
Considere também dados comuns para armazenamento de dados dos funcionários.

⦁	Garanta que os valores monetários não aceitem valores negativos;
⦁	A Passagem deve possuir um método getResumo(), 
que irá exibir somente nome do cliente, poltrona e valor;
⦁	Para o atributo forma de pagamento garanta que seja 
armazenado somente “VISTA” ou “CRÉDITO” ou “DÉBITO”.
⦁	Para o atributo nome do cliente, crie um método para retornar 
somente o primeiro nome.

⦁	Crie um método aplicar desconto() que deverá atualizar o atributo
 total com 5% de desconto se o valor do total estiver entre 500 e 5000, se 
 o total for maior que 5000 atualize o total considerando 10% de desconto. 
 O método deve retornar: “Total atualizado, 
 foi considerado o valor de desconto: <valor do desconto>”.*/
namespace exercicioViagem.AgenciaTurismo;
public class Program
{
    static void Main(string[] args)
    {
        string nome;
        bool continuar = true;
        Console.WriteLine("Seja bem vindo à Agência de Turismo DoDev");
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
        var cliente = new Cliente(nome,cpf,dataNasc);
        Console.WriteLine(cliente.PrimeiroNome(nome));
        cliente.MarqueAOpcao();

    }
}