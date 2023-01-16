using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student
    {
        public Student()
        {
            Identifier = new Identifier();
        }
        public int StudentId { get; private set; }
        public string FirstNameArabic { get; private set; } = string.Empty;
        public string? SecondNameArabic { get; private set; }
        public string? ThirdNameArabic { get; private set; }
        public string FamilyNameArabic { get; private set; } = string.Empty;        
        public string FirstNameEnglish { get; private set; } = string.Empty;
        public string? SecondNameEnglish { get; private set; }
        public string? ThirdNameEnglish { get; private set; }
        public string FamilyNameEnglish { get; private set; } = string.Empty;
        public DateTime DateOfBirth { get; private set; }
        public string PhoneNumber { get; private set; }
        public string PhoneCountyCode { get; set; }
        public Identifier Identifier { get; private set; }
    }
}
