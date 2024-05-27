using System;

class Program
{
    static void Main(string[] args)
    {
        // Read inputs from the user
        Console.Write("Enter the base number: ");
        int baseNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        int exponent = int.Parse(Console.ReadLine());

        Console.Write("Enter the modulus: ");
        int modulus = int.Parse(Console.ReadLine());

        // Perform modular exponentiation
        int result = ModularExponentiation(baseNumber, exponent, modulus);

        // Display the result
        Console.WriteLine($"({baseNumber}^{exponent}) % {modulus} = {result}");
        Console.ReadLine();
    }

    static int ModularExponentiation(int baseNumber, int exponent, int modulus)
    {
        if (modulus == 1) return 0;
        int result = 1;
        baseNumber = baseNumber % modulus;
        while (exponent > 0)
        {
            // If exponent is odd, multiply base with result
            if ((exponent & 1) == 1)
                result = (result * baseNumber) % modulus;
            // Exponent must be even now
            exponent = exponent >> 1; // Exponent = exponent / 2
            baseNumber = (baseNumber * baseNumber) % modulus; // Change base to base^2
        }
        return result;
    }
}
