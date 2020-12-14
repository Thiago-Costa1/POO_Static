namespace Poo_static
{
    public static class Conversor
    {   
        
        private static float cotacaoEuro = 6.23f;
        private static float cotacaoDolar = 5.10f;

        private static float cotacaoReal = 1.0f;
        public static float valorUsuario;

        public static float ConverterDolarParaReal()
        {
            return valorUsuario * cotacaoDolar;
        }

        public static float ConverterRealParaDolar()
        {

            return valorUsuario / cotacaoDolar;
        }

        public static float ConverterEuroParaReal()
        {
            return valorUsuario * cotacaoEuro;
        }

        public static float ConverterRealParaEuro()
        {
            return valorUsuario / cotacaoEuro;
        }
    }
}