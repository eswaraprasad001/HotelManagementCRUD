using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementCRUD.Models
{
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Please Enter Hotel Name.")]

        public string? HotelName { get; set; }

        
        public int ZipCode { get; set; }


        [Column(TypeName = "varchar(20)")]
        public string? City { get; set; }

        public int Price { get; set; }
    }
}
