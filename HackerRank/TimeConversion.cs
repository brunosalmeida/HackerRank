namespace HackerRank
{
    public class TimeConversion
    {
        public static string Convert(string date)
        {
            var hour = int.Parse(date.Split(':')[0]);
            var minute = date.Split(':')[1];
            var seconds = date.Split(':')[2].Substring(0,2);


            var type = date.Substring(date.Length - 2);

            if (hour != 12 && type.ToUpper() == "PM")
                hour += 12;

            if (hour == 12 && type.ToUpper() == "AM")
                hour = 0;
            
            var convertedDate = hour < 10? $"0{hour}:{minute}:{seconds}" : $"{hour}:{minute}:{seconds}";

            return convertedDate;
        }
    }
}
