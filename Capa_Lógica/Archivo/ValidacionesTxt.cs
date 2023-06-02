namespace Capa_Lógica.Archivo
{
    public class ValidacionesTxt
    {
        private int _cantidad_Maxima_Caracteres=8;
        private string _letraNombre = "M";

        /// <summary>
        /// Valida el tamaño del nombre de un archivo
        /// </summary>
        /// <param name="_nombreArchivo">Nombre del archivo</param>
        /// <returns>bool de acuerdo al resultado de la operación</returns>
        public bool Valide_Tamanno_Nombre_Archivo(string _nombreArchivo)
        {
            /*
            if (_nombreArchivo.Length>_cantidad_Maxima_Caracteres)
            {
                return false;
            }
            else { 
                return true;
            }   */
            /*
            if (_nombreArchivo.Length > _cantidad_Maxima_Caracteres)
            {
                return false;
            }

            return true;*/

            return _nombreArchivo.Length> _cantidad_Maxima_Caracteres? false: true;

        }


        public bool Valide_Primera_Letra_Nombre_Archivo(string _nombreArchivo) {

             string primeraLetra = _nombreArchivo[0].ToString();
            //string primeraLetra = _nombreArchivo.Substring(0,1);
            /*
            if (primeraLetra == _letraNombre)
            {
                return true;
            }
            else { 
                return false;
            }*/
            /*
            if (primeraLetra == _letraNombre)
            {
                return true;
            }

            return false;*/
            return primeraLetra == _letraNombre ? true : false;
        }

    }
}
