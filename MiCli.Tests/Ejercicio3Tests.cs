using Xunit;

namespace MiCli.Tests;

public class Ejercicio3Tests
{
    [Fact]
    public void UsarConstanteCorrectamente_DebeRetornarMensajeConValor()
    {
        // Act
        var resultado = Ejercicio3_ErrorIntencional.UsarConstanteCorrectamente();
        
        // Assert
        Assert.NotEmpty(resultado);
        Assert.Contains("constante", resultado, StringComparison.OrdinalIgnoreCase);
    }
    
    [Fact]
    public void UsarConstanteCorrectamente_DebeContenerUnNumero()
    {
        // Act
        var resultado = Ejercicio3_ErrorIntencional.UsarConstanteCorrectamente();
        
        // Assert
        Assert.Matches(@"\d+", resultado); // Debe contener al menos un número
    }
}
