namespace Domain.Entities
{
    public class IdentifierType
    {
        public IdentifierType()
        {
            Identifier = new Identifier();
        }
        public int IdentifierTypeId { get; private set; }
        public string NameArabic { get; private set; } = string.Empty;
        public string? NameEnglish { get; private set; }
        public Identifier Identifier { get; private set; }
    }
}