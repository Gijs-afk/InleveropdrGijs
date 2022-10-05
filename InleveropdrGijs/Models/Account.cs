using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InleveropdrGijs.Data;

namespace InleveropdrGijs.Models
{
    public class Account
    {
        #region
        [Key]
        public int Id { get; set; }

        [Required, DisplayName("klantNaam"), StringLength(100)]
        public string klantNaam { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int AantalVrienden { get; set; }
        public int Punten { get; set; }
        #endregion

        #region
        /// <param name="description">Description of the task</param>
#endregion
    }
}
