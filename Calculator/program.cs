using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Add;
using Subtract;
using Multiply;
using Divide;

namespace Calculator
{
    internal class program
    {
        
        static void Main(string[] args)
        {
            Addition add = new Addition();


            Console.WriteLine(add.Calculate(3, 6));

            List<string> Results = new List<string>();
            int choice;
            do
            {
                Console.WriteLine("Welcome to the Calculator!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Mathematical Operations");
                Console.WriteLine("2. Array Operations");
                Console.WriteLine("3. String Operations");
                Console.WriteLine("4. Number Operations");
                Console.WriteLine("5. View Results");
                Console.WriteLine("6. Clear Results");
                Console.WriteLine("7. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int choice1;
                        Console.WriteLine("Mathematical Operations:");
                        Console.WriteLine("Please select an option:");
                        Console.WriteLine("1. Power");
                        Console.WriteLine("2. HCF");
                        Console.WriteLine("3. LCM");
                        Console.WriteLine("4. Simple Interest");
                        Console.WriteLine("5. Compound Interest");

                        Console.WriteLine("6. Back to Main Menu");

                        


                        do
                        {
                            Console.WriteLine("Please select an option:");
                            choice1 = Convert.ToInt32(Console.ReadLine());
                            switch (choice1)
                            {
                                case 1:
                                    Console.WriteLine("Enter base and exponent:");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    int y = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine($"Result: {Mathematical_Operations.power(x, y)}");
                                    Results.Add($"Power of {x}^{y} = {Mathematical_Operations.power(x, y)}");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter two numbers to find HCF:");
                                    int a = Convert.ToInt32(Console.ReadLine());
                                    int b = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine($"HCF: {Mathematical_Operations.HCF(a, b)}");
                                    Results.Add($"HCF of {a} and {b} = {Mathematical_Operations.HCF(a, b)}");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter two numbers to find LCM:");
                                    int m = Convert.ToInt32(Console.ReadLine());
                                    int n = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine($"LCM: {Mathematical_Operations.LCM(m, n)}");
                                    Results.Add($"LCM of {m} and {n} = {Mathematical_Operations.LCM(m, n)}");
                                    break;

                                case 4:
                                    Console.WriteLine("Enter principal, rate, and time for Simple Interest:");
                                    int principal = Convert.ToInt32(Console.ReadLine());
                                    int rate = Convert.ToInt32(Console.ReadLine());
                                    int time = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine($"Simple Interest: {Mathematical_Operations.simple_interest(principal, rate, time)}");
                                    Results.Add($"Simple Interest of {principal}, {rate}%, and {time} years = {Mathematical_Operations.simple_interest(principal, rate, time)}");
                                    break;

                                case 5:
                                    Console.WriteLine("Enter principal, rate, and time for Compound Interest:");
                                    double principalCI = Convert.ToDouble(Console.ReadLine());
                                    double rateCI = Convert.ToDouble(Console.ReadLine());
                                    double timeCI = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine($"Compound Interest: {Mathematical_Operations.compound_interest(principalCI, rateCI, timeCI)}");
                                    Results.Add($"Compound Interest of {principalCI}, {rateCI}%, and {timeCI} years = {Mathematical_Operations.compound_interest(principalCI, rateCI, timeCI)}");
                                    break;


                                case 6:
                                    Console.WriteLine("Returning to Main Menu.");
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }

                        } while (choice1 !=6);

                        break;
                           
                            
                    case 2:
                            
                                int choice2;
                        do { 
                                Console.WriteLine("Array Operations:");
                                Console.WriteLine("Please select an option:");
                                Console.WriteLine("1. Sum of Array Elements");
                                Console.WriteLine("2. Average of Array Elements");
                                Console.WriteLine("3. Maximum Element in Array");
                                Console.WriteLine("4. Minimum Element in Array");
                                Console.WriteLine("5. search for an Element in Array");
                                Console.WriteLine("6. sort assending order");
                                Console.WriteLine("7. sort decending order");
                                Console.WriteLine("8. Back to Main Menu");
                                choice2 = Convert.ToInt32(Console.ReadLine());

                            
                            switch (choice2)
                            {
                                case 1:
                                    Console.WriteLine("Enter the size of the array:");
                                    int size = Convert.ToInt32(Console.ReadLine());
                                    int[] arr = new int[size];
                                    Console.WriteLine("Enter the elements of the array:");
                                    for (int i = 0; i < size; i++)
                                    {
                                        arr[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.WriteLine($"Sum of Array Elements: {Array_Operations.sum(arr)}");
                                    Results.Add($"Sum of Array Elements = {Array_Operations.sum(arr)}");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the size of the array:");
                                    int sizeAvg = Convert.ToInt32(Console.ReadLine());
                                    int[] arrAvg = new int[sizeAvg];
                                    Console.WriteLine("Enter the elements of the array:");
                                    for (int i = 0; i < sizeAvg; i++)
                                    {
                                        arrAvg[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.WriteLine($"Average of Array Elements: {Array_Operations.average(arrAvg)}");
                                    Results.Add($"Average of Array Elements = {Array_Operations.average(arrAvg)}");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the size of the array:");
                                    int sizeMax = Convert.ToInt32(Console.ReadLine());
                                    int[] arrMax = new int[sizeMax];
                                    Console.WriteLine("Enter the elements of the array:");
                                    for (int i = 0; i < sizeMax; i++)
                                    {
                                        arrMax[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.WriteLine($"Maximum Element in Array: {Array_Operations.maximum(arrMax)}");
                                    Results.Add($"Maximum Element in Array = {Array_Operations.maximum(arrMax)}");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the size of the array:");
                                    int sizeMin = Convert.ToInt32(Console.ReadLine());
                                    int[] arrMin = new int[sizeMin];
                                    Console.WriteLine("Enter the elements of the array:");
                                    for (int i = 0; i < sizeMin; i++)
                                    {
                                        arrMin[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.WriteLine($"Minimum Element in Array: {Array_Operations.minimum(arrMin)}");
                                    Results.Add($"Minimum Element in Array = {Array_Operations.minimum(arrMin)}");
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the size of the array:");
                                    int sizeSearch = Convert.ToInt32(Console.ReadLine());
                                    int[] arrSearch = new int[sizeSearch];
                                    Console.WriteLine("Enter the elements of the array:");
                                    for (int i = 0; i < sizeSearch; i++)
                                    {
                                        arrSearch[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.WriteLine("Enter the element to search for:");
                                    int valueToSearch = Convert.ToInt32(Console.ReadLine());
                                    bool contains = Array_Operations.contains(arrSearch, valueToSearch);
                                    if (contains)
                                    {
                                        Console.WriteLine($"The array contains {valueToSearch}.");
                                        Results.Add($"The array contains {valueToSearch}.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"The array does not contain {valueToSearch}.");
                                        Results.Add($"The array does not contain {valueToSearch}.");
                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the size of the array:");
                                    int sizeSortAsc = Convert.ToInt32(Console.ReadLine());
                                    int[] arrSortAsc = new int[sizeSortAsc];
                                    Console.WriteLine("Enter the elements of the array:");
                                    for (int i = 0; i < sizeSortAsc; i++)
                                    {
                                        arrSortAsc[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int[] sortedAsc = Array_Operations.sort_array_ascending(arrSortAsc);
                                    Console.WriteLine("Array sorted in ascending order:");
                                    foreach (int num in sortedAsc)
                                    {
                                        Console.Write(num + " ");
                                    }
                                    Console.WriteLine();
                                    Results.Add("Array sorted in ascending order: " + string.Join(", ", sortedAsc));
                                    break;

                                case 7:
                                    Console.WriteLine("Enter the size of the array:");
                                    int sizeSortDesc = Convert.ToInt32(Console.ReadLine());
                                    int[] arrSortDesc = new int[sizeSortDesc];
                                    Console.WriteLine("Enter the elements of the array:");
                                    for (int i = 0; i < sizeSortDesc; i++)
                                    {
                                        arrSortDesc[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int[] sortedDesc = Array_Operations.sort_array_descending(arrSortDesc);
                                    Console.WriteLine("Array sorted in descending order:");
                                    foreach (int num in sortedDesc)
                                    {
                                        Console.Write(num + " ");
                                    }
                                    Console.WriteLine();
                                    Results.Add("Array sorted in descending order: " + string.Join(", ", sortedDesc));
                                    break;

                                case 8:
                                    Console.WriteLine("Returning to Main Menu.");
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        } while (choice2 != 8);

                        break;



                    case 3:
                        int choice3;
                        do { 
                        Console.WriteLine("String Operations:");
                        Console.WriteLine("Please select an option:");
                        Console.WriteLine("1. Reverse a String");
                        Console.WriteLine("2. count vowels in a String");
                        Console.WriteLine("3. Return to Main Menu");
                        choice3 = Convert.ToInt32(Console.ReadLine());
                        
                        
                            switch (choice3)
                            {
                                case 1:
                                    Console.WriteLine("Enter a string to reverse:");
                                    string inputString = Console.ReadLine();
                                    Console.WriteLine($"Reversed String: {String_Operations.reverse_string(inputString)}");
                                    Results.Add($"Reversed String of '{inputString}' = '{String_Operations.reverse_string(inputString)}'");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter a string to count vowels:");
                                    string vowelString = Console.ReadLine();
                                    int vowelCount = String_Operations.count_vowels(vowelString);
                                    Console.WriteLine($"Number of vowels in the string: {vowelCount}");
                                    Results.Add($"Number of vowels in '{vowelString}' = {vowelCount}");
                                    break;
                                case 3:
                                    Console.WriteLine("Returning to Main Menu.");
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        } while (choice3 != 3);

                        break;
                     
                        

                    case 4:
                        
                        int choice4;
                        do { 
                        
                        Console.WriteLine("Number Operations:");
                        Console.WriteLine("Please select an option:");
                        Console.WriteLine("1. Calculate Factorial");
                        Console.WriteLine("2. Check if a Number is Prime");
                        Console.WriteLine("3. check if number is armstrong");
                        Console.WriteLine("4. check if number is palindrome");
                        Console.WriteLine("5. Return to Main Menu");
                        choice4 = Convert.ToInt32(Console.ReadLine());

                        
                       
                            switch (choice4)
                            {
                                case 1:
                                    Console.WriteLine("Enter a number to calculate its factorial:");
                                    int numFactorial = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine($"Factorial of {numFactorial}: {NumberOperations.factorial(numFactorial)}");
                                    Results.Add($"Factorial of {numFactorial} = {NumberOperations.factorial(numFactorial)}");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter a number to check if it's prime:");
                                    int numPrime = Convert.ToInt32(Console.ReadLine());
                                    bool isPrime = NumberOperations.prime_number(numPrime);
                                    Console.WriteLine($"{numPrime} is {(isPrime ? "a prime number" : "not a prime number")}");
                                    Results.Add($"{numPrime} is {(isPrime ? "a prime number" : "not a prime number")}");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter a number to check if it's an Armstrong number:");
                                    int numArmstrong = Convert.ToInt32(Console.ReadLine());
                                    bool isArmstrong = NumberOperations.armstrong(numArmstrong);
                                    Console.WriteLine($"{numArmstrong} is {(isArmstrong ? "an Armstrong number" : "not an Armstrong number")}");
                                    Results.Add($"{numArmstrong} is {(isArmstrong ? "an Armstrong number" : "not an Armstrong number")}");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter a number to check if it's a palindrome:");
                                    int numPalindrome = Convert.ToInt32(Console.ReadLine());
                                    bool isPalindrome = NumberOperations.palindrome(numPalindrome);
                                    Console.WriteLine($"{numPalindrome} is {(isPalindrome ? "a palindrome" : "not a palindrome")}");
                                    Results.Add($"{numPalindrome} is {(isPalindrome ? "a palindrome" : "not a palindrome")}");
                                    break;
                                case 5:
                                    Console.WriteLine("Returning to Main Menu.");
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        } while (choice4 != 5);



                        break;
                    case 5:
                        Console.WriteLine("Results:");
                        foreach (string result in Results)
                        {
                            Console.WriteLine(result);
                        }
                        break;
                    case 6:
                        Results.Clear();
                        Console.WriteLine("Results cleared.");
                        break;
                    case 7:
                        Console.WriteLine("Exiting the Calculator");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 7);
        }
    }
}
