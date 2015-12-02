namespace DiagonalDifference {

	public class DiagonalDIfference {

		public static void Main(string[] args) {
			int size = System.Int32.Parse(System.Console.ReadLine());
			int[,] matrix = new int[size, size];

			fill_matrix(ref matrix, size);
			System.Console.WriteLine(calculate_difference(matrix, size));
			System.Console.ReadKey();
		}

		public static void fill_matrix(ref int[,] matrix, int size) {
			string[] temp;

			for (int i = 0; i < size; i++) {
				temp = (System.Console.ReadLine()).Split();
				for (int j = 0; j < size; j++)
					matrix[i, j] = System.Int32.Parse(temp[j]);
			}
		}

		public static void print_matrix(int[,] matrix, int size) {
			for (int i = 0; i < size; i++) {
				for (int j = 0; j < size; j++)
					System.Console.Write(matrix[i,j] + " ");
				System.Console.WriteLine();
			}
		}

		public static int calculate_difference(int[,] matrix, int size) {
			int first_diag = 0;
			int	second_diag = 0;

			for (int i = 0; i < size; i++) //add up diagonal from top left to bottom right
				first_diag += matrix[i, i];

			for (int i = 0; i < size; i++) //add up diagonal from top right to bottom left
				second_diag += matrix[i, size - 1 - i];

			return System.Math.Abs(first_diag - second_diag);
		}
	}
}