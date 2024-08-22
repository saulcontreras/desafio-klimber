namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        private string Nombre => "Cuadrado";
        public override string GetNombre(bool plural = false) => plural ? $"{Nombre}s" : Nombre;
        public override decimal CalcularArea() => _lado * _lado;
        public override decimal CalcularPerimetro() => _lado * 4;
    }
}
