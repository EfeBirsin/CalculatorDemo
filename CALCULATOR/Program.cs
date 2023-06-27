// See https://aka.ms/new-console-template for more information




// Declare a boolean variable to control the loop
bool devam = true;
// Start a while loop that runs as long as devam is true
while (devam)
{
    // Write a welcome message to the console
    Console.WriteLine("Welcome to the calculator");

    // Write a prompt for the first number
    Console.WriteLine("Please enter the first number");

    // Read the user input as a string
    string giris1 = Console.ReadLine();

    // Declare a decimal variable to store the first number
    decimal sayı1;

    // Try to parse the user input as a decimal and assign it to sayı1
    if (decimal.TryParse(giris1, out sayı1))
    {
        // Write a prompt for the second number
        Console.WriteLine("Please enter the second number ");
        // Read the user input as a string
        string giris2 = Console.ReadLine();
        // Declare a decimal variable to store the second number
        decimal sayı2;
        // Try to parse the user input as a decimal and assign it to sayı2
        if (decimal.TryParse(giris2, out sayı2))
        {
            // Write a prompt for the operation
            Console.WriteLine("Please choose the operation you want to do");
            Console.WriteLine("1-addition");
            Console.WriteLine("2-subtraction");
            Console.WriteLine("3-multiplication");
            Console.WriteLine("4-division");
            // Read the user input as a string
            string secim = Console.ReadLine();
            // Use a switch statement to perform different operations based on secim
            switch (secim)
            {
                case "1":
                    // Declare a decimal variable to store the sum of sayı1 and sayı2
                    decimal toplam = sayı1 + sayı2;
                    // Write the result to the console using string interpolation
                    Console.WriteLine($"{sayı1} + {sayı2} = {toplam}");
                    break;
                case "2":
                    // Declare a decimal variable to store the difference of sayı1 and sayı2
                    decimal fark = sayı1 - sayı2;
                    // Write the result to the console using string interpolation
                    Console.WriteLine($"{sayı1} - {sayı2} = {fark}");
                    break;
                case "3":
                    // Declare a decimal variable to store the product of sayı1 and sayı2
                    decimal çarpım = sayı1 * sayı2;
                    // Write the result to the console using string interpolation
                    Console.WriteLine($"{sayı1} * {sayı2} = {çarpım}");
                    break;
                case "4":
                    // Check if sayı2 is not zero to avoid division by zero error
                    if (sayı2 != 0)
                    {
                        // Declare a decimal variable to store the quotient of sayı1 and sayı2
                        decimal bölüm = sayı1 / sayı2;
                        // Write the result to the console using string interpolation
                        Console.WriteLine($"{sayı1} / {sayı2} = {bölüm}");
                    }
                    else
                    {
                        // Write an error message to the console
                        Console.WriteLine("Please enter a valid number");
                    }
                    break;
                default:
                    // Write an error message to the console if secim is not valid
                    Console.WriteLine("Please choose a valid operation");
                    break;
            }
        }
        else
        {
            // Write an error message to the console if giris2 is not valid
            Console.WriteLine("Please enter a valid number");
        }
    }
    else
    {
        // Write an error message to the console if giris1 is not valid
        Console.WriteLine("Please enter a valid number");
    }
    // Write a prompt for continuing or exiting the loop
    Console.WriteLine("Do you want to continue{y/n]");

    // Read the user input as a string
    string git = Console.ReadLine();

    // Check if git is n or N and set devam to false to exit the loop
    if (git == "n" || git == "N")
    {
        devam = false;
    }
}
