namespace WebApi.Helpers
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public int ExpiryDays { get; set; }
    }
}