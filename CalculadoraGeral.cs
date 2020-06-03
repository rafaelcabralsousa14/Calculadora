namespace Calculadora
{
    public class CalculadoraGeral
    {
        public string soma;
        public bool querSoma;
        public string divisão;
        public bool querDivisão;
        public string multiplicação;
        public bool querMultiplicar;
        public string subtração;
        public bool querSubtração;

    
        public string Somar(){
            string total = soma;
            if(querSoma == true){
                return total;
            }else{
                return ""; 
            }
        }
        public string Dividir(){
            string total = divisão;
            if(querDivisão == true){
                return total;
            }else{
                return ""; 
            }
        }
        public string Multiplicar(){
            string total = multiplicação;
            if(querMultiplicar == true){
                return total;
            }else{
                return ""; 
            }
        }

        public string Subtrair(){
            string total = subtração;
            if(querSubtração == true){
                return total;
            }else{
                return ""; 
            }
        }

    }
}