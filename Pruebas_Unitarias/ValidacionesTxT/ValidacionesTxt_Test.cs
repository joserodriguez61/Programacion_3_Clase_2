﻿
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
        [TestMethod]
        public void Valida_Tamanno_Nombre_Archivo_Cuando_Archivo_Invalido() {

            //Arrange
            ValidacionesTxt validaciones = new ValidacionesTxt();
            bool respuestaEsperada = false;
            string nombreArchivo = "EstoesunaPrueba";

            //Act
            bool respuestaObtenida = validaciones.Valide_Tamanno_Nombre_Archivo(nombreArchivo);

            //Assert 

            Assert.AreEqual(respuestaEsperada,respuestaObtenida);
        
        }

        [TestMethod]
        public void Valide_Primera_Letra_Nombre_Archivo_Cuando_Nombre_Valido() {

            //Arrange
            ValidacionesTxt validaciones = new ValidacionesTxt();
            bool respuestaEsperada = true;
            string nombreArchivo = "Manual";

            //Act
            bool respuestaObtenida = validaciones.Valide_Primera_Letra_Nombre_Archivo(nombreArchivo);

            //Assert
            Assert.AreEqual(respuestaEsperada,respuestaObtenida);

        
        }

    }
}
