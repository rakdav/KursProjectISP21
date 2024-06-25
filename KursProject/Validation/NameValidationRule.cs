using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KursProject.Validation
{
    class NameValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string name = value.ToString()!;
            if (name.All(c => char.IsLetter(c) || c == ' '))
                return new ValidationResult(true, null);
            return new ValidationResult(false, "Должны быть только буквы");
        }
    }
}
