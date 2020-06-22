namespace Aula22Static
{
    public class Conversor
    {
        private static float CotacaoDolar = 5.23f;
        public static float RealParaDolar(float ValorRS){
            return ValorRS / CotacaoDolar;

        }
        public static float DolarParaReal(float ValorUS){
            return CotacaoDolar * ValorUS;
        }
    }
}