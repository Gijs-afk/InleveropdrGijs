using System.ComponentModel.DataAnnotations;


namespace InleveropdrGijs.Models
{
    public class Foto
    {
        [Key]
        public int FotoID { get; set; }

        public int? CameraID { get; set; }
        public List<Camera>? Camera{ get; set; }
        public int AantalFotos { get; set; }

        
    }
}
