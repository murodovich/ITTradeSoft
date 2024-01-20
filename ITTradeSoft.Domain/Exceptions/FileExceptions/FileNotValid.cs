namespace ITTradeSoft.Domain.Exceptions.FileExceptions
{
    public class FileNotValid : GlobalExceptions
    {
        public FileNotValid()
        {
            TitleMessage = "Image Not Valid!";
        }
    }
}
