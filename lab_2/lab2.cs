using System;

namespace Matrix
{
    /// <summary>
    /// Клас, що представляє матрицю та надає базові операції над нею.
    /// </summary>
    class Matrix
    {
        private int rows;
        private int columns;
        private int[,] matrixArray;

        /// <summary>
        /// Конструктор класу Matrix.
        /// </summary>
        /// <param name="rows">Кількість рядків матриці.</param>
        /// <param name="columns">Кількість стовпців матриці.</param>
        public Matrix(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            matrixArray = new int[rows, columns];
        }

        /// <summary>
        /// Заповнення матриці випадковими значеннями.
        /// </summary>
        public void FillMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrixArray[i, j] = rand.Next(-20, 21);
                }
            }
        }

        /// <summary>
        /// Обчислення суми діагональних елементів матриці.
        /// </summary>
        /// <returns>Сума діагональних елементів.</returns>
        private int CalculateDiagonalSum()
        {
            int sum = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (i == j) sum += matrixArray[i, j];
                }
            }
            return sum;
        }

        /// <summary>
        /// Відображення матриці на консолі.
        /// </summary>
        public void DisplayMatrix()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"{matrixArray[i, j], -10}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Отримання суми діагональних елементів матриці.
        /// </summary>
        /// <returns>Сума діагональних елементів.</returns>
        public int GetDiagonalSum()
        {
            return CalculateDiagonalSum();
        }

        /// <summary>
        /// Властивість, що повертає або встановлює кількість рядків матриці.
        /// </summary>
        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        /// <summary>
        /// Властивість, що повертає або встановлює кількість стовпців матриці.
        /// </summary>
        public int Columns
        {
            get { return columns; }
            set { columns = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;

            Console.Write("Введіть кількість рядків матриці: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть кількість стовпців матриці: ");
            columns = Convert.ToInt32(Console.ReadLine());

            Matrix matrix = new Matrix(rows, columns);

            matrix.FillMatrix();
            matrix.DisplayMatrix();
            int diagonalSum = matrix.GetDiagonalSum();

            Console.WriteLine($"Сума діагональних елементів: {diagonalSum}");
        }
    }
}
