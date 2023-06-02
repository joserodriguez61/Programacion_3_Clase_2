
using Capa_Lógica.Archivo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas_Unitarias.ValidacionesTxT
{
    [TestClass]
    public class ValidacionesTxt_Test
    {
        [TestMethod]
        public void Valide_Tamanno_Nombre_Archivo_Cuando_Archivo_Valido() {

            //Arrange
            ValidacionesTxt validaciones = new ValidacionesTxt();
            bool respuestaEsperada = true;
            string nombreArchivo = "Prueba";

            //Act
            bool respuestaObtenida = validaciones.Valide_Tamanno_Nombre_Archivo(nombreArchivo);

            //Assert
            Assert.AreEqual(respuestaEsperada,respuestaObtenida);

        }
    }
}
