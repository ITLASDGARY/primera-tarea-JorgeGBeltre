namespace MiCli;

// TODO: Crea un programa que imprima tu Nombre, Carrera y Hobby favorito en líneas separadas
public class Ejercicio1_Presentacion
{
    public static string ObtenerPresentacion()
    {
        
        string nombre ="Jorge";
        string Carrera ="computer";
        string Hobby ="basket";

        return $"{nombre}\n{Carrera}\n{Hobby}";
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(ObtenerPresentacion());
    }
}
