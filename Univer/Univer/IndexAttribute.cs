using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Univer
{
    public class IndexAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (!int.TryParse(value.ToString(), out int result))
            {
                return false;
            }

            if (result > 99999)
            {
                return true;
            }
            else
            {
                this.ErrorMessage = "Wrong Range!";
                return false;
                    
            }
        }
    }
}
