namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal _base;
        private readonly decimal _altura;

        public Rectangulo(decimal ladoBase, decimal ladoAltura)
        {
            _base = ladoBase;
            _altura = ladoAltura;
        }

        private string Nombre => "Rectangulo";
        public override string GetNombre(bool plural = false) => plural ? $"{Nombre}s" : Nombre;
        public override decimal CalcularArea() => _base * _altura;
        public override decimal CalcularPerimetro() => 2 * (_base + _altura);
    }
}
