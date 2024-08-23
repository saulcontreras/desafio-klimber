namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _altura;
        private readonly decimal _baseA;
        private readonly decimal _baseB;
        private readonly decimal _ladoA;
        private readonly decimal _ladoB;

        public Trapecio(decimal altura, decimal baseA, decimal baseB, decimal ladoA, decimal ladoB)
        {
            _altura = altura;
            _baseA = baseA;
            _baseB = baseB;
            _ladoA = ladoA;
            _ladoB = ladoB;
        }

        private string Nombre => "Trapecio";
        public override string GetNombre(bool plural = false) => plural ? $"{Nombre}s" : Nombre;
        public override decimal CalcularArea() => ((_baseA + _baseB) * _altura) / 2;
        public override decimal CalcularPerimetro() => _baseA + _baseB + _ladoA + _ladoB;
    }
}
