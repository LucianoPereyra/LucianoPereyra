using System.ComponentModel.DataAnnotations;
using LucianoPereyra;

namespace PiramideCuadrada_LucianoPereyra.Test
{
    [TestClass]
    public sealed class PiramideCuadradaTest
    {
        [TestMethod]
        public void TestCalcularApotema()
        {
            //Arrange
            var piramide = new PiramideCuadrada(4, 3);
            var esperado = Math.Sqrt(3 * 3 + 2 * 2);

            //Act
            var apotema = piramide.Apotema;

            //Assert
            Assert.AreEqual(esperado, apotema, 0.01);
        }




        [TestMethod]
        public void TestCalcularArea()
        {
            //Arrange
            var piramide = new PiramideCuadrada(4, 3);
            var apotema = piramide.Apotema;
            var esperado = Math.Pow(4, 2) + 2 * (4 * apotema);

            //Act
            var area = piramide.CalcularArea();

            //Assert
            Assert.AreEqual(esperado, area, 0.01);
        }

        [TestMethod]
        public void TestCalcularVolumen()
        {
            //Arrange
            var piramide = new PiramideCuadrada(4, 3);
            var esperado = (Math.Pow(4, 2) * 3) / 3;
            //Act
            var volumen = piramide.CalcularVolumen();
            //Assert
            Assert.AreEqual(esperado, volumen, 0.01);
        }

        [TestMethod]

        public void TestInformarDatos()
        {
            //Arrange
            var piramide = new PiramideCuadrada(4, 3);

            //Act
            var datos = piramide.InformarDatos();

            //Assert
            Assert.IsTrue(datos.Contains("Lado de la base: 4"));
            Assert.IsTrue(datos.Contains("Altura: 3"));
        }

        [TestMethod]
        public void TestValidacion()
        {
            // Arrange
            var piramide = new PiramideCuadrada(4, 3);
            var context = new ValidationContext(piramide);

            // Act
            var resultados = new List<ValidationResult>();
            var esValido = Validator.TryValidateObject(piramide, context, resultados, true);

            // Assert
            Assert.IsTrue(esValido);
            Assert.AreEqual(0, resultados.Count);
        }

        [TestMethod]
        public void TestValidacionLadoBaseInvalido()
        {
            // Arrange
            var piramide = new PiramideCuadrada(-1, 3);
            var context = new ValidationContext(piramide);
            // Act
            var resultados = new List<ValidationResult>();
            var esValido = Validator.TryValidateObject(piramide, context, resultados, true);
            // Assert
            Assert.IsFalse(esValido);
            Assert.IsTrue(resultados.Any(r => r.MemberNames.Contains("LadoBase")));
        }

        [TestMethod]
        public void TestValidacionAlturaInvalida()
        {
            // Arrange
            var piramide = new PiramideCuadrada(4, 0);
            var context = new ValidationContext(piramide);
            // Act
            var resultados = new List<ValidationResult>();
            var esValido = Validator.TryValidateObject(piramide, context, resultados, true);
            // Assert
            Assert.IsFalse(esValido);
            Assert.IsTrue(resultados.Any(r => r.MemberNames.Contains("Altura")));
        }
    }
}
