namespace HackerRank //namespace is like a package in Java
{
    public class ArraySum
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(System.Console.ReadLine()); //reads in data from user then converts to integer
            int[] array = new int[size];
            int total = 0;

			/* take the elements of the array inputted from the user and then convert those values to integer and then
			   put them into the integer array
			*/
			array = System.Array.ConvertAll(System.Console.ReadLine().Split(' '), int.Parse);
            foreach (int cur in array) //for each loop
                total += cur;

            System.Console.WriteLine(total);
            System.Console.ReadKey();
        }
    }
}
