ConsoleColor cor = ConsoleColor.DarkGreen; // variável do tipo cor com valor da cor

Console.ForegroundColor = cor;
Thread.Sleep(1000); // Congela computador por determinada quantidade de tempo
Console.WriteLine("Preparar...");
Console.ReadKey();

cor = ConsoleColor.DarkYellow; // mudou-se o valor da variável
Console.ForegroundColor = cor;
Thread.Sleep(1000);
Console.WriteLine("Apontar...");
Console.ReadKey();

cor = ConsoleColor.DarkRed;
Console.ForegroundColor = cor;
Thread.Sleep(1000);
Console.WriteLine("FOGO!");

Console.ResetColor(); // Reseta cor

/*
    Comandos para deixar suas credenciais para subir arquivo do github 

    git config --global user.name "SEU NOME"
    git config --global user.email "SEU EMAIL"

    ~ Rode os comandos no terminal ~
*/

// Continue estudando programação e coisas complexas por que é muito legal.