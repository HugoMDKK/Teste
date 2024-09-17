using System;

class Program
{
    static void Main()
    {   
        
        //Primeiro
        Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceAFibonacci(numero))
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");

        //Segundo
        Console.WriteLine();
        Console.WriteLine("Informe uma string para verificar a presença e a quantidade de letras 'A':");
        string input = Console.ReadLine();

        VerificarLetraA(input);


        //Terceiro 
        Console.WriteLine();
        int indice = 12;
        int soma = 0;
        int k = 1;

        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }
        Console.WriteLine("O valor da variável é " + soma);  
    }





    // Função de Fibonacci
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


    // Função de verificar letras "A"
    static void VerificarLetraA(string input)
    {
        int contador = 0;

        foreach (char c in input.ToLower())
        {
            if (c == 'a') contador++;
        }

        if (contador > 0)
            Console.WriteLine($"A letra 'A' aparece {contador} vezes.");
        else
            Console.WriteLine("A letra 'A' não aparece na string.");
    }
   
    
}