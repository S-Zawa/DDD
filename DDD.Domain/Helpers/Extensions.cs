namespace DDD.Domain.Helpers
{
    public static class Extensions
    {
        public static float ToSingle(this double value)
        {
            return Convert.ToSingle(value);
        }
    }
}