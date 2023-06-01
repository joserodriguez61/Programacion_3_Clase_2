
using Capa_Model.Archivo;

string nombreArchivo;
string ubicacion;
string texto;

Console.WriteLine("Digite el nombre del archivo");
try
{
	nombreArchivo = Console.ReadLine();
}
catch (Exception)
{
	nombreArchivo = "Pruebas.txt";
}
Console.WriteLine("Digite la ubicación del archivo");

try
{
    ubicacion = Console.ReadLine();
}
catch (Exception)
{
    ubicacion = "C:\\Users";
}

Console.WriteLine("Digite el texto del archivo");

try
{
	texto = Console.ReadLine();
}
catch (Exception)
{

    texto = "Hola Mundo en Txt";
}

ArchivoTxt archivo = new ArchivoTxt(texto,ubicacion,texto);