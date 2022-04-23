// See https://aka.ms/new-console-template for more information

using TextAnalyzer.Extensions;

// Configuration
ConsoleKeyInfo cki;

while (true)
{
    Console.Clear();

    // Title
    Console.WriteLine("Prueba SIESA --- Analizador de texto");
    Console.WriteLine("====================================");
    
    // Read text
    Console.WriteLine();
    Console.WriteLine("Escribe cualquier texto:");
    var text = Console.ReadLine();

    // Analyze the text and show the result
    Console.WriteLine($"{Environment.NewLine}Resultado:");
    var wordNumber = text.WordNumber();
    Console.WriteLine($"1. Número de palabras: {wordNumber}");
    Console.WriteLine($"2. Primera letra en mayúscula: {text.Capitalize()}");
    Console.WriteLine($"3. ¿Es un texto palíndromo? {(text.IsPalindrome() ? "SI" : "NO")}");
    
    var wordFrecuency = text.WordFrequency();
    if (wordFrecuency != null && wordNumber > 0)
    {
        Console.WriteLine("4. Porcentaje de ocurrencias de palabras:");
        foreach (var item in wordFrecuency)
        {
            var percentage = (int)Math.Round((double)(100 * item.Value) / wordNumber);
            Console.WriteLine($"- {item.Key}: {item.Value} ({percentage}%)");
        }
    }

    Console.WriteLine($"{Environment.NewLine}Presiona la tecla F1 para salir o la tecla Enter para continuar:");
    cki = Console.ReadKey(true);
    if (cki.Key == ConsoleKey.F1)
    {
        Environment.Exit(0);
    }
} 