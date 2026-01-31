namespace MiCli;

// TODO: Declara una constante e intenta cambiar su valor para ver el error
public class Ejercicio3_ErrorIntencional
{
    public static string UsarConstanteCorrectamente()
    {
        const int numero = 9;

        // TODO: Intenta cambiar su valor en la siguiente línea (esto causará un error)
       //numero =9;
        // TODO: Comenta la línea que causa el error
        // TODO: Retorna un mensaje con el valor de la constante
        return $"Mi constante {numero}"; //OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(UsarConstanteCorrectamente());
    }
}
