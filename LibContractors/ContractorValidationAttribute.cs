using System.ComponentModel.DataAnnotations;

namespace LibContractors
{
    public class ContractorValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Contractor contractor = value as Contractor;
            if (contractor.Type == ContractorType.LegalEntity && contractor.KPP == null)
            {
                this.ErrorMessage = "KPP can't be null for legal entity";
                return false;
            }

            return true;
        }
    }
}
