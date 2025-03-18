using System.IO.IsolatedStorage;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("----- BEM-VINDO AO GAME FIZZ BUZZ -----");
Console.WriteLine("Digite um número para começar o jogo ou digite '0' para encerrar o jogo.");

while (true)
{
    Console.ResetColor();
    Console.WriteLine("\nEscolha dificuldade:");
    Console.WriteLine("1 - Jogar Modo Livre:");
    Console.WriteLine("2 - Intermediário");
    Console.WriteLine("3 - Difícil");
    Console.WriteLine("0 - Sair do Jogo");
    Console.Write("Sua Escolha: ");

    if (!int.TryParse(Console.ReadLine(), out int difficulty))
    {
        Console.ForegroundColor = ConsoleColor.Red;
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
    else if (difficulty == 3)
    {
        hardMode();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Opção inválida! Escolha 1, 2 ou 0.");
    }
}

void easyMode()
{
    while (true)
    {
        Console.ResetColor();
        Console.Write("Digite um número (0 para sair): ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.ForegroundColor = ConsoleColor.Red;
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
    int score = 0;
    int goal = 0;

    Console.WriteLine("\nModo Intermediário: Apenas permitido metas acima de 50 pontos!");
    Console.WriteLine("Digite 0 para voltar ao menu principal");

    while (true)
    {
        Console.Write("Digite a meta de pontos que deseja alcançar: ");

        string isValid = Console.ReadLine();

       

        if (!int.TryParse(isValid, out goal))
        {

            Console.WriteLine("\nEntrada inválida! Digite um número inteiro.");
            continue;
        }

        if (goal == 0)
        {
            Console.WriteLine("...Voltando ao menu principal...");
            return;
        }

        if (goal <= 50)
        {
            Console.WriteLine("\nApenas permitido meta acima de 50 pontos! ");
            continue;
        }

        break;
    }

    Console.WriteLine($"\nSua meta é atingir {goal} pontos!");

    while (true)
    {
        Console.WriteLine($"Pontuação Atual: {score} pontos\n");
        int randomNumber = rand.Next(1, 100);
        Console.WriteLine($"Qual a resposta para o número {randomNumber}?");
        Console.WriteLine("Digite: Fizz, Buzz, FizzBuzz ou o próprio número");
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
            Console.WriteLine("\nResposta Correta! +5 Pontos");
            score += 5;
        }
        else
        {
            Console.WriteLine($"\nResposta errada! A resposta correta era: {correctAnswer}\n-3 Pontos");
            score -= 3;
        }

        if (score >= goal)
        {
            Console.WriteLine($"Parabéns! Você atingiu a meta de {goal} pontos!");
            break;
        }

    }
    Console.WriteLine($"Sua pontuação final foi: {score} pontos");
}
/*
Implementar modo dificil do jogo, sem modo livre, apenas com meta acima de 50 pontos, pensar na pontuação de perda e ganhos de forma que fique mais dificil
Implementar o modo impossivel, sem modo livre, apenas com meta acima de 200 pontos, colocar pontuação de forma impossivel para que o usuario ganhe
Implementar o modo educação, onde o usuário vai entender mais da lógica do jogo, onde iremos dizer oque errou e dizer a lógica por tras do game, de modo que ele posso praticar e aprender e ir para outros modos mais dificeis do game


void impossibleMode()
{

}

void educationMode()
{

}
*/

void hardMode()
{
    Random rand = new Random();
    int score = 0;
    int goal;

    Console.WriteLine("\nModo Difícil: Apenas permitido metas acima de 50 pontos!");
    Console.WriteLine("Digite 0 para voltar ao menu principal");

    while (true)
    {
        Console.Write("Digite a meta de pontos que deseja alcançar: ");

        bool isValid = int.TryParse(Console.ReadLine(), out goal);

        if (!isValid)
        {
            Console.WriteLine("\nEntrada inválida! Digite um número inteiro.");
            continue;
        }

        if (goal > 50)
        {
           break;
        }

        Console.WriteLine("\nApenas permitido meta acima de 50 pontos! ");
    }
    Console.WriteLine($"\nSua meta é atingir {goal} pontos!");


    while (true)
    {
        Console.WriteLine($"Pontuação atual: {score} pontos\n");
        int randomNumber = rand.Next(1,100);
        Console.WriteLine($"Qual a resposta para o número {randomNumber}?");
        Console.WriteLine("Digite: Fizz, Buzz, FizzBuzz ou o próprio número: ");
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
            Console.WriteLine("\nResposta Correta! + 3 Pontos");
            score += 3;
        }
        else 
        {
            Console.WriteLine($"\nResposta Incorreta! A resposta era: {correctAnswer}\n-9 Pontos");
            score -= 9;
        }

        if (score >= goal)
        {
            Console.WriteLine($"Parabéns! Você atingiu a meta de {goal} pontos!");
            break;
        }
    }
    Console.WriteLine($"Sua pontuação final foi: {score} pontos!");

}