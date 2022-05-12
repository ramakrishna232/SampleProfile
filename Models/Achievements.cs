using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PMS_API
{
    public class Achievements
    {
        [Key]
        public int AchievementId{get;set;}
        public string AwardType{get;set;}
        public string base64header {get;set;}
        public byte[]? Image{get;set;}
        public int PersonalDetailsId{get;set;}

        [ForeignKey("PersonalDetailsId")]
        [InverseProperty("achievements")]
        public virtual PersonalDetails? personaldetails{get;set;}
        public bool IsActive{get;set;}
         public DateTime? CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }
    }
}