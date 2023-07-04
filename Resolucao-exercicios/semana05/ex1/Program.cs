using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o primeiro número: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.Write("Insira o segundo número: ");
        float num2 = float.Parse(Console.ReadLine());

        try
        {
            float resultado = num1 / num2;
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Erro: Não é possível dividir por zero. Erro completo: {ex}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Erro: letras não podem ser informadas. Digites números. Erro completo: {ex}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex}");
        }
        finally
        {
            System.Console.WriteLine("Zerando variáveis...");
            num1 = 0;
            num2 = 0;
            System.Console.WriteLine("Encerrando programa...");
        }
    }
}