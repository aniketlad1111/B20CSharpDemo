public class Utility
{
    public int GetOtp()
    {
        Random rand = new Random();
        return rand.Next(1000, 9999);
    }
}
