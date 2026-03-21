using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Presenters.Commom
{
    public class ModelDataValidation
    {
        public void Valite(object model)
        {
            string errorMessage = "";
            List<ValidationResult> results = new List<ValidationResult>();
            var context = new ValidationContext(model);
            bool validation = Validator.TryValidateObject(model, context, results, true);
            if (validation == false)
            {
                foreach (var item in results)
                {
                    errorMessage += "-" + item.ErrorMessage + "\n";
                }
                throw new Exception("Erro ao realizar validação:\n" + errorMessage);
            }
        }
    }
}
