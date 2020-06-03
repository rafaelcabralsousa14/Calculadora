using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraGeral calculo = new CalculadoraGeral();
            
            int i;
            bool decisao;
            for(i = 1; i != 12 ; i += 1){
                int[] número;
                número = new int[i];
                Console.WriteLine("Quer adicionar outro número? [Responder com true ou false]");
                decisao = bool.Parse(Console.ReadLine());
                if(decisao == true){
                    Console.WriteLine("Digite um número");
                    string v = Console.ReadLine();
                }
                else{
                    break;
                }
            }
            calculo.querSoma = true;
            if(calculo.querSoma == true){
                calculo.soma =   
            }
    
        }
    }
}
       