namespace Assignment_3._2_Question_2
{
    internal class Program
    {

        //Write a program for the addition of two matrices
        //of the same size

        //similar setup to question 1

        //nest loops for rows/columns = i/j

        static void Main()
        {
            //set rows and columns
            int rows, columns;

            Console.WriteLine("Let's make matrices!");
            Console.WriteLine();
            //input stuff for matrices (less than 5?)
            Console.Write("Please enter how many rows you want: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); //because spaces are important
            Console.Write("Please enter how many columns you want: ");
            columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //making math, with commas,
            int[,] matrixuno = new int[rows, columns];
            int[,] matrixdos = new int[rows, columns];
            int[,] result = new int[rows, columns];

            //input for numero uno
            Console.WriteLine("Enter elements of first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter element at position [{i},{j}]: ");
                    matrixuno[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //input for numero dos
            Console.WriteLine("Enter elements of second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter element at position [{i},{j}]: ");
                    matrixdos[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //addition magic
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrixuno[i, j] + matrixdos[i, j];
                }
            }

            //print results
            //lines between numbers in matrices?
            Console.WriteLine("Sum of the two matrices is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(" | " + result[i, j] + " | ");
                }
                Console.WriteLine();
            }

        }
    }
}
