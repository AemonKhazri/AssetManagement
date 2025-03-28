using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Data.Models
{
    public class Asset
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public string Status { get; set; }
        public string AssignedTo { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime ReplacementDate { get; set; }
        public string Department { get; set; }



    }
}
