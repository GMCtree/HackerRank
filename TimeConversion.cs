namespace TimeConversion {

	public class TimeConversion {

		public static void Main(string[] args) {
			string[] originalTime = (System.Console.ReadLine()).Split(':');

			if (is_pm(originalTime[originalTime.Length - 1]))
				System.Console.WriteLine(convert_pm(originalTime));
			else
				System.Console.WriteLine(convert_am(originalTime));
			System.Console.ReadKey();
		}

		public static bool is_pm(string time) {
			if (time.Contains("PM"))
				return true;
			else
				return false;
		}

		public static string convert_am(string[] time) {
			string result = "";
			string[] AM = time[time.Length - 1].Split('A');
			time[time.Length - 1] = AM[0];

			if (time[0] == "12")
				time[0] = "00";

			for (int i = 0; i < time.Length; i++) {
				result += time[i];
				if (i == 2)
					break;
				result += ":";
			}	
            return result;
		}

		public static string convert_pm(string[] time) {
			string result = "";
			string[] PM = time[time.Length - 1].Split('P');
			time[time.Length - 1] = PM[0];

			int newTime = System.Int32.Parse(time[0]) + 12;
			if (newTime == 24)
				time[0] = "12";
			else
				time[0] = newTime.ToString();

			for (int i = 0; i < time.Length; i++) {
				result += time[i];
				if (i == 2)
					break;
				result += ":";
			}
			return result;
		}
	}
}