using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EncaladaD_LigaPro.Models
{
    public class Equipo{
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName ("Ingrese el nombre: ")]
        public string Nombre { get; set; }
        [Range(0,100)]
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 20)]
        public int TotalPuntos 
        {
            get 
            { 
                return (PartidosGanados * 3) + PartidosEmpatados;
            }
            set { }  
        }

    }
}
