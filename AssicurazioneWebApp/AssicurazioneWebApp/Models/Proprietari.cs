using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AssicurazioneWebApp.Models
{
    public class Proprietari
    {
        [Key]
        public string codicefiscale { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string residenza { get; set; }
    }
}
