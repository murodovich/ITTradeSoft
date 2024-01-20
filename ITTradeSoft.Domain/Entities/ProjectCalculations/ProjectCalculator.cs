namespace ITTradeSoft.Domain.Entities.ProjectCalculations
{
    public class ProjectCalculator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}

    }
}
