namespace MethodOverloading
{
    public class Methods
    {
       public static int Add(int x, int y)
        {
            return (x + y);
        }
        public static decimal Add(decimal x, decimal y)
        {
            return (x + y);
        }
       public static string Add(int x, int y, bool z)
        {
            int answer = x + y;

            if (z && answer > 1)
            {
                return $"{answer} dollars";
            }
            else if (z && answer == 1)
            {
                return $"{answer} dollar";
            }
            else
            {
                return $"error";
            }
        }
        
    }
}