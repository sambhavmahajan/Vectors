# Vector

Vector is a C# library providing functionalities related to vectors, matrices, and mathematical operations. It includes methods for vector operations, matrix operations, and mathematical functions.

## Features

- **Vector Operations:** Perform operations such as calculating the distance between two points, calculating the sigmoid function, soft sign function, absolute value, and more.
- **Matrix Operations:** Implement matrix addition, scalar multiplication, and matrix multiplication.
- **Mathematical Functions:** Includes mathematical functions like factorial, power, natural logarithm, and computation of Euler's number.

## Installation

To use the Vector library in your C# projects, follow these steps:

1. Clone this repository to your local machine.
2. Include the `Vector.cs` file in your C# project.
3. Ensure that the namespace `Vector` is accessible in your project.

## Usage

Here's a basic example demonstrating how to use the Vector library:

```csharp
using System;
using Vector;

class Program
{
    static void Main(string[] args)
    {
        // Example usage of vector operations
        int x1 = 1, y1 = 2, x2 = 3, y2 = 4;
        double distance = Vector.Distance(x1, x2, y1, y2);
        Console.WriteLine($"Distance between ({x1},{y1}) and ({x2},{y2}): {distance}");

        // Example usage of mathematical functions
        int factorial = Vector.Factorial(5);
        Console.WriteLine($"Factorial of 5: {factorial}");

        float power = Vector.Power(2, 3);
        Console.WriteLine($"2 raised to the power of 3: {power}");

        // Example usage of matrix operations
        float[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        float[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        float[,] sum = Vector.Matrix.Add(matrix1, matrix2);
        Console.WriteLine("Sum of matrices:");
        for (int i = 0; i < sum.GetLength(0); i++)
        {
            for (int j = 0; j < sum.GetLength(1); j++)
            {
                Console.Write($"{sum[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
```

## Contributing

Contributions to the Vector library are welcome! If you encounter any issues or have suggestions for improvements, please feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
