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

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 Forma Perímetro 20 Área 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnIngles()
        {
            var formas = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 Shape Perimeter 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnItaliano()
        {
            var formas = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto delle forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTALE:<br/>1 Forma Perimetro 20 Area 25", resumen);
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

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Cuadrados | Área 35 | Perímetro 36 <br/>TOTAL:<br/>3 Formas Perímetro 36 Área 35", resumen);
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

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35", resumen);
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

            Assert.AreEqual("<h1>Rapporto delle forme</h1>3 Quadrati | Area 35 | Perimetro 36 <br/>TOTALE:<br/>3 Forme Perimetro 36 Area 35", resumen);
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
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 Formas Perímetro 97,66 Área 91,65",
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
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 Shapes Perimeter 97,66 Area 91,65",
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
                "<h1>Rapporto delle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 Forme Perimetro 97,66 Area 91,65",
                resumen);
        }


        [TestCase]
        public void TestResumenListaConUnRectanguloEnCastellano()
        {
            var formas = new List<FormaGeometrica> { new Rectangulo(5, 20) };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Área 100 | Perímetro 50 <br/>TOTAL:<br/>1 Forma Perímetro 50 Área 100", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectanguloEnIngles()
        {
            var formas = new List<FormaGeometrica> { new Rectangulo(5, 20) };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Rectangle | Area 100 | Perimeter 50 <br/>TOTAL:<br/>1 Shape Perimeter 50 Area 100", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectanguloEnItaliano()
        {
            var formas = new List<FormaGeometrica> { new Rectangulo(5, 20) };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto delle forme</h1>1 Rettangolo | Area 100 | Perimetro 50 <br/>TOTALE:<br/>1 Forma Perimetro 50 Area 100", resumen);
        }


        [TestCase]
        public void TestResumenListaConMasRectangulosEnCastellano()
        {
            var formas = new List<FormaGeometrica> { 
                new Rectangulo(5, 20),
                new Rectangulo(25, 12),
                new Rectangulo(52, 90)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Rectángulos | Área 5080 | Perímetro 408 <br/>TOTAL:<br/>3 Formas Perímetro 408 Área 5080", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulosEnIngles()
        {
            var formas = new List<FormaGeometrica> {
                new Rectangulo(5, 20),
                new Rectangulo(25, 12),
                new Rectangulo(52, 90)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Rectangles | Area 5080 | Perimeter 408 <br/>TOTAL:<br/>3 Shapes Perimeter 408 Area 5080", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulosEnItaliano()
        {
            var formas = new List<FormaGeometrica> {
                new Rectangulo(5, 20),
                new Rectangulo(25, 12),
                new Rectangulo(52, 90)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto delle forme</h1>3 Rettangoli | Area 5080 | Perimetro 408 <br/>TOTALE:<br/>3 Forme Perimetro 408 Area 5080", resumen);
        }


        [TestCase]
        public void TestResumenListaConUnTrapecioEnCastellano()
        {
            var formas = new List<FormaGeometrica> { new Trapecio(15, 20, 40, 50, 80) };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Área 450 | Perímetro 190 <br/>TOTAL:<br/>1 Forma Perímetro 190 Área 450", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnIngles()
        {
            var formas = new List<FormaGeometrica> { new Trapecio(5, 20, 40, 50, 80) };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Trapezoid | Area 150 | Perimeter 190 <br/>TOTAL:<br/>1 Shape Perimeter 190 Area 150", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnItaliano()
        {
            var formas = new List<FormaGeometrica> { new Trapecio(5, 20, 40, 50, 80) };

            var resumen = FormaGeometricaService.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto delle forme</h1>1 Trapezio | Area 150 | Perimetro 190 <br/>TOTALE:<br/>1 Forma Perimetro 190 Area 150", resumen);
        }

    }
}
