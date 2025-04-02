using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Data.Models
{
    public class Asset
    {
        [Key]
        public int Id { get; set; }
        public  required string Name { get; set; }
        public required string Description { get; set; }
        public required double UnitPrice { get; set; }
        public required DateTime DateOfPurchase { get; set; }
        public required string Status { get; set; }
        public required string AssignedTo { get; set; }
        public required DateTime AssignmentDate { get; set; }
        public required DateTime ReplacementDate { get; set; }
        public required string Department { get; set; }



    }
}
