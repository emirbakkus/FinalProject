using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // Temel voidler için başlangıç noktası
    public interface IResult
    {
        bool Success { get; } // İşlemin başarılı olup olmadığını belirten özellik
        string Message { get; } // İşlemle ilgili mesajı tutan özellik
    }
}
