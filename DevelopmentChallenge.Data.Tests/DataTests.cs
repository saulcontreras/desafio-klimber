using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVaciaEnCastellano()
        {
            Assert.AreEqual("<h1>¡Lista vacía de formas!</h1>",
                FormaGeometricaService.Imprimir(new List<FormaGeometrica>(), Idiomas.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometricaService.Imprimir(new List<FormaGeometrica>(), Idiomas.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaEnItaliano()
        {
            Assert.AreEqual("<h1>Lista vuota di forme!</h1>",
                FormaGeometricaService.Imprimir(new List<FormaGeometrica>(), Idiomas.Italiano));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnCastellano()
        {
            var formas = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 forma Perímetro 20 Área 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnIngles()
        {
            var formas = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shape Perimeter 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnItaliano()
        {
            var formas = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto delle forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTALE:<br/>1 forma Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Cuadrados | Área 35 | Perímetro 36 <br/>TOTAL:<br/>3 formas Perímetro 36 Área 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto delle forme</h1>3 Quadrati | Area 35 | Perimetro 36 <br/>TOTALE:<br/>3 forme Perimetro 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 97,66 Área 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto delle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 forme Perimetro 97,66 Area 91,65",
                resumen);
        }

    }
}
