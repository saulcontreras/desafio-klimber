using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;

namespace DevelopmentChallenge.Data.Services
{
    public static class FormaGeometricaService
    {
        private static readonly ResourceManager resourceManager =
            new ResourceManager("DevelopmentChallenge.Data.Resources.FormaGeometrica", typeof(FormaGeometrica).Assembly);

        public static string Imprimir(List<FormaGeometrica> formas, Idiomas idioma)
        {
            var culture = ObtenerCulture(idioma);

            if (formas == null || !formas.Any())
            {
                return $"<h1>{resourceManager.GetString("ListaVacia", culture)}</h1>";
            }

            var reporte = $"<h1>{resourceManager.GetString("Reporte", culture)}</h1>";
            foreach (var forma in formas.GroupBy(f => f.GetNombre()))
            {
                var cantidad = forma.Count();
                var nombre = forma.FirstOrDefault().GetNombre(cantidad > 1);
                var nombreForma = resourceManager.GetString(nombre, culture);
                var area = forma.Sum(f => f.CalcularArea());
                var perimetro = forma.Sum(f => f.CalcularPerimetro());
                reporte += $"{cantidad} {nombreForma} | {resourceManager.GetString("Area", culture)} {area:#.##} | {resourceManager.GetString("Perimetro", culture)} {perimetro:#.##} <br/>";
            }

            var totalFormas = formas.Count;
            var totalArea = formas.Sum(f => f.CalcularArea());
            var totalPerimetro = formas.Sum(f => f.CalcularPerimetro());
            reporte += $"{resourceManager.GetString("Total", culture)}<br/>{totalFormas} {(totalFormas > 1 ? resourceManager.GetString("Formas", culture) : resourceManager.GetString("Forma", culture))} {resourceManager.GetString("Perimetro", culture)} {totalPerimetro:#.##} {resourceManager.GetString("Area", culture)} {totalArea:#.##}";

            return reporte;
        }

        private static CultureInfo ObtenerCulture(Idiomas idioma)
        {
            switch (idioma)
            {
                case Idiomas.Castellano:
                    return new CultureInfo("es");
                case Idiomas.Ingles:
                    return new CultureInfo("en");
                case Idiomas.Italiano:
                    return new CultureInfo("it");
                default:
                    return CultureInfo.InvariantCulture;
            }
        }
    }
}