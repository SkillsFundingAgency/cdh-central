using System;
using System.Collections.Generic;
using System.Text;

namespace CDS2FuncApp.Models
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public int TitleID { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public DateTime DateofBirth { get; set; }
        public int UniqueLearnerNumber { get; set; }
        public Boolean OptInUserResearch { get; set; }
        public Boolean OptInMarketResearch { get; set; }
        public DateTime DateOfAccountClosure { get; set; }
        public int ReasonForClosureID { get; set; }
        public int IntroducedByID { get; set; }
        public string IntroducedByAdditionalInfo { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Guid LastModifiedTouchpointID { get; set; }

    }
}
