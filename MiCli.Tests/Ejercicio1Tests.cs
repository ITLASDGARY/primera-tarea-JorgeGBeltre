using Xunit;

namespace MiCli.Tests;

public class Ejercicio1Tests
{
    [Fact]
    public void ObtenerPresentacion_DebeRetornarTresLineas()
    {
        // Act
        var resultado = Ejercicio1_Presentacion.ObtenerPresentacion();
        var lineas = resultado.Split('\n');
        
        // Assert
        Assert.Equal(3, lineas.Length);
    }
    
    [Fact]
    public void ObtenerPresentacion_DebeContenerInformacionPersonal()
    {
        // Act
        var resultado = Ejercicio1_Presentacion.ObtenerPresentacion();
        
        // Assert
        Assert.NotEmpty(resultado);
        Assert.Contains("\n", resultado); // Debe tener al menos un salto de línea
    }
}
