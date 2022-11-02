string entradaT, entradaP, entradaR;
bool sensorT, sensorP, sensorR, luzAdvertenciaW;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("--- Simulador de Luz de Advertência ---\n");
Console.WriteLine("[A]tivado, [D]esativado\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Sensor de temperatura...: ");
entradaT = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();
Console.ResetColor();

if (entradaT != "A" && entradaT != "D")
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Valor inválido.");
    Console.ResetColor();
    return;
}
Console.ForegroundColor = ConsoleColor.DarkRed;
sensorT = entradaT == "A";
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Sensor de pressão.......: ");
entradaP = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();
Console.ResetColor();

if (entradaP != "A" && entradaP != "D")
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Valor inválido.");
    Console.ResetColor();
    return;
}

Console.ForegroundColor = ConsoleColor.DarkRed;
sensorP = entradaP == "A";
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Sensor de rotação.......: ");
entradaR = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();
Console.ResetColor();

if (entradaR != "A" && entradaR != "D")
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Valor inválido.");
    Console.ResetColor();
    return;
}
sensorR = entradaR == "A";

luzAdvertenciaW = sensorT && (sensorP || !sensorR);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nA luz de advertência estará {(luzAdvertenciaW ? "ATIVADA" : "DESATIVADA")}.");
Console.ResetColor();
