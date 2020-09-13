using System.ComponentModel.DataAnnotations;

namespace LibContractors
{
    [ContractorValidation]
    public class Contractor
    {
        public int Id { get; private set; }

        [Required(ErrorMessage = "Contractor's name is required")]
        public string Name { get; set; }

        public string FullName { get; set; }

        [Required(ErrorMessage = "Contractor's type is required")]
        [Range(0, int.MaxValue,
            ErrorMessage = "Contractor's type should be an integer number")]
        public ContractorType Type { get; set; }

        [Required(ErrorMessage = "Contractor's INN is required")]
        public string INN { get; set; }

        public string KPP { get; set; }
    }
}