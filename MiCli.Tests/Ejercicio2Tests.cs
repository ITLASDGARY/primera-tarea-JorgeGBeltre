using Xunit;

namespace MiCli.Tests;

public class Ejercicio2Tests
{
    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(10, 20, 30)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, 5, 0)]
    public void Sumar_DebeRetornarSumaCorrecta(int a, int b, int esperado)
    {
        // Act
        var resultado = Ejercicio2_Sumadora.Sumar(a, b);
        
        // Assert
        Assert.Equal(esperado, resultado);
    }
    
    [Fact]
    public void ObtenerResultado_DebeContenerTextoLaSumaEs()
    {
        // Act
        var resultado = Ejercicio2_Sumadora.ObtenerResultado();
        
        // Assert
        Assert.Contains("La suma es:", resultado);
    }
    
    [Fact]
    public void ObtenerResultado_DebeContenerUnNumero()
    {
        // Act
        var resultado = Ejercicio2_Sumadora.ObtenerResultado();
        
        // Assert
        Assert.Matches(@"La suma es: \d+", resultado);
    }
}
