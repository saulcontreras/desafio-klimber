namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        public abstract string GetNombre(bool plural = false);
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}