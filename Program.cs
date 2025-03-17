Console.WriteLine("----- BEM-VINDO AO GAME FIZZ BUZZ -----");
Console.WriteLine("Digite um número para começar o jogo ou digite '0' para encerrar o jogo.");

while (true)
{
    Console.WriteLine("\nEscolha dificuldade:");
    Console.WriteLine("(1 - Fácil)");
    Console.WriteLine("(2 - Intermediário)");
    Console.WriteLine("(0 - Sair do Jogo)");
    Console.Write("Sua Escolha: ");

    if (!int.TryParse(Console.ReadLine(), out int difficulty))
    {
        Console.WriteLine("Entrada inválida! Digite um número inteiro.");
        continue;
    }

    if (difficulty == 0)
    {
        Console.WriteLine("...Saindo do Jogo!");
        break;
    }
    else if (difficulty == 1)
    {
        easyMode();
    }
    else if (difficulty == 2)
    {
        mediumMode();
    }
    else
    {
        Console.WriteLine("Opção inválida! Escolha 1, 2 ou 0.");
    }
}

void easyMode()
{
    while (true)
    {
        Console.Write("Digite um número (0 para sair): ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Entrada inválida! Digite um número inteiro.");
            continue;
        }

        if (number == 0)
        {
            Console.WriteLine("...Voltando ao menu principal!");
            break;
        }

        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("Fizz Buzz");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(number);
        }
    }
}

void mediumMode()
{
    Random rand = new Random();

    while (true)
    {
        int randomNumber = rand.Next(1, 100);
        Console.WriteLine("\n0 - Para sair");
        Console.WriteLine($"Qual a resposta para o número {randomNumber}?");
        Console.WriteLine("(Digite Fizz, Buzz, FizzBuzz ou o próprio número)");
        Console.Write("Sua Resposta: ");

        string response = Console.ReadLine().Trim().ToLower();

        if (response == "0")
        {
            Console.WriteLine("...Voltando ao menu principal...");
            break;
        }

        string correctAnswer;
        if (randomNumber % 3 == 0 && randomNumber % 5 == 0)
        {
            correctAnswer = "fizzbuzz";
        }
        else if (randomNumber % 3 == 0)
        {
            correctAnswer = "fizz";
        }
        else if (randomNumber % 5 == 0)
        {
            correctAnswer = "buzz";
        }
        else
        {
            correctAnswer = randomNumber.ToString();
        }

        if (response == correctAnswer)
        {
            Console.WriteLine("Resposta Correta!");
        }
        else
        {
            Console.WriteLine($"Resposta errada! A resposta correta era: {correctAnswer}");
        }
    }
}
