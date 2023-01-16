using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int StudentId { get; private set; }
    }
}
