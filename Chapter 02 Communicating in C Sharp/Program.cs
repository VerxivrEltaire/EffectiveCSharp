
// Statements, Comments and Blocks 

using Chapter_02_Communicating_in_C_Sharp;

int x = 5; 
x = x + 2; 
Console.WriteLine(x); 

    
// This is a single-line comment

/*
This is a
multi-line comment
*/

int y = 10; // This comment explains that y is assigned the value 10


if (x > 5) {
    Console.WriteLine("x is greater than 5");
} else {
    Console.WriteLine("x is not greater than 5");
}


// Declare an integer variable and assign a value
int number = 3;

// Check if the number is positive, negative, or zero
if (number > 0) {
    // number is positive
    Console.WriteLine("The number is positive");
} else if (number < 0) {
    // number is negative
    Console.WriteLine("The number is negative");
} else {
    // number is zero
    Console.WriteLine("The number is zero");
}


// The C# Vocabulary: Keywords, Identifiers, and Literals

double price = 99.99;
bool isAvailable = true;
while (isAvailable) {
    if (price < 100) {
        Console.WriteLine("The price is affordable.");
    }
    break;
}


int age; // 'age' is an identifier for a variable
string firstName; // 'firstName' is an identifier for a variable

void CalculateSum() { // 'CalculateSum' is an identifier for a method
    // Method implementation
}

// class Person { // 'Person' is an identifier for a class
//     // Class implementation
// }


// namespace ShoppingCart {
//     class Item {
//         int quantity;
//         string name;
//
//         void DisplayItem() {
//             Console.WriteLine("Item: " + name + ", Quantity: " + quantity);
//         }
//     }
// }

int year = 2024;
float pi = 3.14f;
char grade = 'A';
string greeting = "Hello, World!";
bool isPassed = true;


// Introducing Namespaces

// namespace School {
//     class Student {
//         public string Name { get; set; }
//     }
// }
//
// namespace University {
//     class Student {
//         public string Name { get; set; }
//         public string Major { get; set; }
//     }
// }


// using System;

// namespace MyApp {
//     class Program {
//         static void Main(string[] args) {
//             Console.WriteLine("Hello, World!");
//         }
//     }
// }


// using System;
// using MathOperations;

// namespace MyApp {
//     class Program {
//         static void Main(string[] args) {
//             MathOperations.Calculator calc = new MathOperations.Calculator();
//             int result = calc.Add(5, 3);
//             Console.WriteLine("The sum is: " + result);
//         }
//     }
// }


// using System;
// using Utilities;
//
// namespace MyApp {
//     class Program {
//         static void Main(string[] args) {
//             Utilities.Printer printer = new Utilities.Printer();
//             printer.PrintMessage("This is a custom message from the Printer class.");
//         }
//     }
// }


// Comprehending Variable: Naming things and Allocating Value

int num = 10;
Console.WriteLine(num); // Output: 10

num = 20;
Console.WriteLine(num); // Output: 20

//int age;            // Declaration
age = 25;           // Initialization

string name = "John"; // Declaration and initialization

// int x = 1, y = 2, z = 3;

// Exercise

double height = 1.75;      // Person's height in meters
double weight = 70.5;      // Person's weight in kilograms
// bool isStudent = true;     // Whether the person is a student

int score = 10;
Console.WriteLine(score); // Output: 10

score = 20;
Console.WriteLine(score); // Output: 20

// var age = 25;               // Inferred as int
// var name = "Alice";         // Inferred as string
// var isStudent = true;       // Inferred as bool


// Operators and Expressions

int a = 10;
int b = 3;

Console.WriteLine(a + b); // Output: 13
Console.WriteLine(a - b); // Output: 7
Console.WriteLine(a * b); // Output: 30
Console.WriteLine(a / b); // Output: 3
Console.WriteLine(a % b); // Output: 1


// bool x = true;
// bool y = false;
//
// Console.WriteLine(x && y); // Output: False
// Console.WriteLine(x || y); // Output: True
// Console.WriteLine(!x);     // Output: False


// int a = 10;
// int b = 20;
//
// Console.WriteLine(a == b);  // Output: False
// Console.WriteLine(a != b);  // Output: True
// Console.WriteLine(a > b);   // Output: False
// Console.WriteLine(a < b);   // Output: True
// Console.WriteLine(a >= b);  // Output: False
// Console.WriteLine(a <= b);  // Output: True


// int number = 10;
// string result = (number > 5) ? "Greater than 5" : "5 or less";
// Console.WriteLine(result); // Output: Greater than 5

// int number = 7;
// string result = (number % 2 == 0) ? "Even" : "Odd";
// Console.WriteLine(result); // Output: Odd


// Introducing and Exploring Console Applications

Console.WriteLine("Hello, User!"); // Output: Hello, User!
Console.Write("Enter your name: "); // Output: Enter your name: 


Console.WriteLine("Welcome to our console application!");
Console.Write("Please enter your name: ");


// Console.Write("Enter your name: ");
// string name = Console.ReadLine();
// Console.WriteLine("Hello, " + name + "!");


Console.Write("Enter your favorite color: ");
string color = Console.ReadLine();
Console.WriteLine("Your favorite color is " + color + "!");










