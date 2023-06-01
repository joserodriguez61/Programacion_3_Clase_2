namespace Capa_Lógica.Archivo
{
    public class ValidacionesTxt
    {
        private int _cantidad_Maxima_Caracteres=8;

        /// <summary>
        /// Valida el tamaño del nombre de un archivo
        /// </summary>
        /// <param name="_nombreArchivo">Nombre del archivo</param>
        /// <returns>bool de acuerdo al resultado de la operación</returns>
        public bool Valide_Tamanno_Nombre_Archivo(string _nombreArchivo) {

            if (_nombreArchivo.Length>_cantidad_Maxima_Caracteres)
            {
                return false;
            }
            else { 
                return true;
            }        
        }
    }
}
