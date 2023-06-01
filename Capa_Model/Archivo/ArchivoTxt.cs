
namespace Capa_Model.Archivo
{
    public class ArchivoTxt
    {
        public string NombreArchivo { get; set; }
        public string Ubicacion { get; set; }
        public string Texto { get; set; }
        public ArchivoTxt(string _nombre,string _ubicacion,string _texto)
        {
            this.NombreArchivo = _nombre;
            this.Ubicacion = _ubicacion;
            this.Texto = _texto;
        }
    }
}
