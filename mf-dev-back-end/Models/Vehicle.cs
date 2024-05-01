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
        [Display (Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Display (Name = "Placa")]
        public string Plate { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Display(Name = "Ano de Fabricação")]
        public int YearFabrication { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Display (Name= "Ano do Modelo")]
        public int YearModel { get; set; }
    }
}

