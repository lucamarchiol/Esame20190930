using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssicurazioneWebApp.Models
{
    public class Automobile
    {
        [Key]
        public string targa { get; set; }
        public string marca { get; set; }
        public int cilindrata { get; set; }
        public int potenza { get; set; }
        public Proprietario proprietarioId { get; set; }
        public int assicurazioneId { get; set; }
    }
}
