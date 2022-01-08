namespace ImcApp.Models
{
    public class CalculadoraImc
    {
        public static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura)
            => peso / (estatura * estatura);

        public enum EstadoNutricional
        {
            PesoBajo,
            PesoNormal,
            SobrePeso,
            Obesidad,
            ObesidadExtrema
        }
        public static EstadoNutricional SituacionNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return EstadoNutricional.PesoBajo;
            }
            else if (imc < 25.0m)
            {
                return EstadoNutricional.PesoNormal;
            }
            else if (imc < 30.0m)
            {
                return EstadoNutricional.SobrePeso;
            }
            else if (imc < 40.0m)
            {
                return EstadoNutricional.Obesidad;
            }
            else
            {
            return EstadoNutricional.ObesidadExtrema;
            }
        }
    }
}
