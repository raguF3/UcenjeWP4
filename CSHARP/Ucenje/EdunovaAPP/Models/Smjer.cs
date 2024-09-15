using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaAPP.Models
{
    public class Smjer: Entitet
    {
        public string? naziv {  get; set; }
        public int? trajanje { get; set; }
        public decimal? cijena { get; set; }
        public DateTime? izvodiseod { get; set; }
        [Column("verificiran")] // ovo se ne mora u završnom radu raditi
        public bool? vaucer { get; set; }
    }
}
