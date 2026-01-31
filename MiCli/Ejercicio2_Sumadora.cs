namespace MiCli;

// TODO: Declara dos variables int con valores fijos, súmalas y muestra el resultado
public class Ejercicio2_Sumadora
{
    public static int Sumar(int a, int b)
    {
        int resultado = a + b;
        return a+b; //OJO: reemplaza este texto con el resultado de la suma
        throw new NotImplementedException();
    }
    
    public static string ObtenerResultado()
    {
        int a = 8;
        int b = 10;

        int resultado = Sumar (a, b);

        return $"La suma es: {resultado}"; //OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(ObtenerResultado());
    }
}
