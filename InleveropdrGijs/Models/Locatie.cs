using System.ComponentModel.DataAnnotations;

namespace InleveropdrGijs.Models
{
    public class Locatie
    {
        [Key]
        public int LocatieID { get; set; }    
        public string plaats{ get; set; }
            
    }
}
