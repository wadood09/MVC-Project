namespace QuestionGenerator.Core.Domain.Entities
{
    public class Document : Auditables
    {
        public string Title { get; set; } = default!;
        public string DocumentUrl { get; set; } = default!;
        public int UserId { get; set; }

        #region Relationships
        public User User { get; set; }
        public List<Assessment> Assessments { get; set; } = [];
        public List<RevisitedAssesment> RevistedAssesments { get; set; } = [];

        #endregion
    }
}
