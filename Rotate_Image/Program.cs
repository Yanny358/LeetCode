using System;

namespace Rotate_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = {new int[] {1, 2, 3,4}, new int[] {5, 6, 7,8}, new int[] {9,10,11,12}, new []{13,14,15,16}};
            Console.Write(matrix[0][0]);
            Console.Write(matrix[0][1]);
            Console.Write(matrix[0][2]);
            Console.Write(matrix[0][3]);
            Console.WriteLine();
            Console.Write(matrix[1][0]);
            Console.Write(matrix[1][1]);
            Console.Write(matrix[1][2]);
            Console.Write(matrix[1][3]);
            Console.WriteLine();
            Console.Write(matrix[2][0]);
            Console.Write(matrix[2][1]);
            Console.Write(matrix[2][2]);
            Console.Write(matrix[2][3]);
            Console.WriteLine();
            Console.Write(matrix[3][0]);
            Console.Write(matrix[3][1]);
            Console.Write(matrix[3][2]);
            Console.Write(matrix[3][3]);
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Rotate(matrix);
            Console.Write(matrix[0][0]);
            Console.Write(matrix[0][1]);
            Console.Write(matrix[0][2]);
            Console.Write(matrix[0][3]);
            Console.WriteLine();
            Console.Write(matrix[1][0]);
            Console.Write(matrix[1][1]);
            Console.Write(matrix[1][2]);
            Console.Write(matrix[1][3]);
            Console.WriteLine();
            Console.Write(matrix[2][0]);
            Console.Write(matrix[2][1]);
            Console.Write(matrix[2][2]);
            Console.Write(matrix[2][3]);
            Console.WriteLine();
            Console.Write(matrix[3][0]);
            Console.Write(matrix[3][1]);
            Console.Write(matrix[3][2]);
            Console.Write(matrix[3][3]);
        }
        
        public static void Rotate(int[][] matrix)
        {
            int left = 0;
            int right = matrix.Length - 1;

            while (left < right)
            {
                for (int i = 0; i < right - left; i++)
                {
                    int top = left;
                    int bottom = right;
                    
                    int topLeft = matrix[top][left + i];
                    matrix[top][left + i] = matrix[bottom - i][left];
                    matrix[bottom - i][left] = matrix[bottom][right - i];
                    matrix[bottom][right - i] = matrix[top + i][right ];
                    matrix[top + i][right] = topLeft;
                }

                left++;
                right--;
            }
        }
    }
}