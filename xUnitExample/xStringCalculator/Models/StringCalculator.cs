namespace xStringCalculator.Models
{
    public class StringCalculator
    {

        public bool IsInt(string number)
        {
            return int.TryParse(number, out _);
        }
    }
}