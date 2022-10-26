using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.validation
{
    internal interface IValidation
    {
        bool check(string text, string regex);
    }
}
