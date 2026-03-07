


using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var num = ConsoleExtension.GetInt("Ingrese el número a descomponer:");

        FactorOperations.DecomposeNumber(num);
    do
    {
        answer = FactorOperations.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("F mi loco ");

