
using System.ComponentModel.DataAnnotations;
using LucianoPereyra;
using UtilidadesTP_1_LucianoPereyra;

Console.WriteLine("PIRÁMIDES");

do
{
    var ladoBase = ExtensionesConsola.PedirEntero("Ingrese el lado de la base de la pirámide: ");
    var altura = ExtensionesConsola.PedirEntero("Ingrese la altura de la pirámide: ");

    var p = new PiramideCuadrada(ladoBase, altura);
    var context = new ValidationContext(p);
    var errores = new List<ValidationResult>();
    bool valido = Validator.TryValidateObject(p, context, errores, true);

    if (!valido)
    {
        foreach (var error in errores)
        {
            Console.WriteLine(error.ErrorMessage);
        }
      
    }
    else
    {
        Console.WriteLine(p.InformarDatos());
        ExtensionesConsola.PresioneParaContinuar();
    }

} while (ExtensionesConsola.PedirSiNo("¿Desea ingresar otra pirámide?"));

Console.WriteLine("Gracias por usar el programa.");
