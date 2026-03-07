


using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var num = ConsoleExtension.GetInt("Ingrese el número a descomponer:");

        FactorOperations.DecomposeNumber(num);
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));// validamos que la respuesta del usuario sea igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula 

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("F mi loco ");

