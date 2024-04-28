using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_back_end.Models
{
    [Table("Vehicles")]
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Este campo é obrigatório.")]
        public int Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int Plate { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int YearFabrication { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int YearModel { get; set; }
    }
}

