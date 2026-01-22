[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/WNQVHEOU)
[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=22337634)
# Ejercicios de C# con Tests

Este proyecto contiene 3 ejercicios básicos de C# con tests unitarios usando xUnit.

## Estructura del Proyecto

- **MiCli/** - Proyecto principal con los ejercicios
- **MiCli.Tests/** - Proyecto de tests unitarios

## Ejercicios

### Ejercicio 1: Presentación
Crea un programa que imprima tu Nombre, Carrera y Hobby favorito en líneas separadas.

**Archivo:** `Ejercicio1_Presentacion.cs`

**Tests:** `Ejercicio1Tests.cs`

### Ejercicio 2: La Sumadora
Declara dos variables `int` con valores fijos, súmalas y muestra el resultado en pantalla con el texto: *"La suma es: X"*.

**Archivo:** `Ejercicio2_Sumadora.cs`

**Tests:** `Ejercicio2Tests.cs`

### Ejercicio 3: Error Intencional
Intenta declarar una constante, y luego intenta cambiar su valor en la siguiente línea. Lee el error que te da Visual Studio.

**Archivo:** `Ejercicio3_ErrorIntencional.cs`

**Tests:** `Ejercicio3Tests.cs`

## Cómo Ejecutar

### Ejecutar el programa principal:
```bash
cd MiCli
dotnet run
```
 
### Ejecutar los tests:
```bash
cd MiCli.Tests
dotnet test
```

### Ejecutar tests con detalles:
```bash
cd MiCli.Tests
dotnet test --logger "console;verbosity=detailed"
```

## Instrucciones para Estudiantes

1. Completa la implementación de cada ejercicio en los archivos correspondientes
2. Busca los comentarios `// TODO:` que te guiarán en lo que debes hacer
3. Ejecuta los tests para verificar que tu implementación es correcta
4. Los tests pasarán de rojo (fallidos) a verde (exitosos) cuando completes correctamente cada ejercicio

## Nota sobre el Ejercicio 3

En el Ejercicio 3, intencionalmente causarás un error de compilación al intentar modificar una constante. Esto es parte del aprendizaje. Una vez que veas el error, deberás comentar la línea problemática para que el programa compile correctamente.
