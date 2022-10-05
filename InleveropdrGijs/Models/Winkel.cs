using System.ComponentModel.DataAnnotations;

namespace InleveropdrGijs.Models
{
    public class Winkel
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemNaam { get; set; }
        public int Prijs { get; set; }
        public int Vooraad { get; set; }
           
    }
}
