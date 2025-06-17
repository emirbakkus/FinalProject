using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult :Result
    {
        public SuccessResult(string message) : base(true, message)  // Parametreli constructor ile başarılı bir sonuç ve mesaj oluşturma
        {
        
        }

        public SuccessResult() : base(true) // Parametresiz constructor ile sadece başarılı bir sonuç oluşturma
        {

        }
    }
}
