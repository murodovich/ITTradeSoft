namespace ITTradeSoft.Domain.Exceptions.projects
{
    public class ProjectNotFoundExceptions : GlobalExceptions
    {
        public ProjectNotFoundExceptions()
        {
            TitleMessage = "Project not found!";
        }
    }
}
