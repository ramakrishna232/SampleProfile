using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS_API
{
    public class Education
    {
        [Key]
        public int EducationId{get;set;}
        public string Degree{get;set;}
        public string Course{get;set;}
        // public string College { get; set; }
        [NotMapped]
        public DateTime Starting_Year{get;set;}
        [NotMapped]
        public DateTime Ending_Year{get;set;}
        public int? Starting{get;set;}
        public int? Ending{get;set;}
        public float Percentage{get;set;}
        public int personaldetailsid{get;set;}
        public int collegeid {get;set;}
        


        [ForeignKey("personaldetailsid")]
        [InverseProperty("education")]
        public virtual PersonalDetails? personalDetails{get;set;}
        public DateTime? CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }
        [ForeignKey("collegeid")]
        [InverseProperty("education")]
        public virtual College? college { get; set; }
         public bool IsActive { get; set; }
    }
}