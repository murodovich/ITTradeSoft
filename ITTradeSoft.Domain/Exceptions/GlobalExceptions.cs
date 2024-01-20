namespace ITTradeSoft.Domain.Exceptions
{
    public class GlobalExceptions : Exception
    {
        public string TitleMessage { get; set; } = default!;
    }
}
