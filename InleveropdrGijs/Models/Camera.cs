using System.ComponentModel.DataAnnotations;

namespace InleveropdrGijs.Models
{
    public class Camera
    {
        [Key]
        public int CameraID { get; set; }
        public List<Locatie> LocatieID { get; set; }

        public List<Foto>? Foto { get; set; }

        public string Type { get; set; }
        public int AantalBevestigd { get; set; }

    }
}
