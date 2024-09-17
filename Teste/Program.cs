using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceAFibonacci(numero))
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
    }

    //Função para encontrar os números da sequencia de Fibonacci

    static bool PertenceAFibonacci(int num)
    {
        int a = 0;
        int b = 1;

        while (a <= num)
        {
            if (a == num) return true;
            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }
}
