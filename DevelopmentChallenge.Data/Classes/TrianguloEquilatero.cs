using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        private string Nombre => "Triangulo";
        public override string GetNombre(bool plural = false) => plural ? $"{Nombre}s" : Nombre;
        public override decimal CalcularArea() => (decimal)Math.Sqrt(3) / 4 * _lado * _lado;
        public override decimal CalcularPerimetro() => _lado * 3;
    }
}
