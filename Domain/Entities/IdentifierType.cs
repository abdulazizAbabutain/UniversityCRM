namespace Domain.Entities
{
    public class IdentifierType
    {
        public int IdentifierTypeId { get; private set; }
        public string NameArabic { get; private set; } = string.Empty;
        public string? NameEnglish { get; private set; }
    }
}