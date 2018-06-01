using System;
using System.ComponentModel.DataAnnotations;

namespace NCS.CDS.Diversity.Models
{
    public class Diversity
    {
        public Guid DiversityId { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public int LLDDHealthProblemDeclarationId { get; set; }

        [Required]
        public int PrimaryLLDDHeathProblemId { get; set; }

        [Required]
        public int SecondaryLLDDHeathProblemId { get; set; }

        [Required]
        public Guid EthnicityId { get; set; }

        [Required]
        public Guid GenderId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCollected { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime LastModifiedDate { get; set; }

        public Guid LastModifiedBy { get; set; }
    } 
}
