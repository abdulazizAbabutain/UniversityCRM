namespace Domain.Entities
{
    public class Identifier
    {
        public Identifier()
        {
            IdentifierType = new IdentifierType();
        }
        public int IdentifierId { get; private set; }
        public string IdentifierNumber { get; private set; } = string.Empty;
        public DateTime IssueDate { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public IdentifierType IdentifierType { get; private set; }
        public int IdentifierTypeId { get; private set; }
        public int StudentId { get; private set; }
        public Student Student { get; private set; }
    }
}
