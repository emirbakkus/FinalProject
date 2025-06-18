using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity //Diğer katmanların erişebilmesi için public olarak tanımlandı.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        //[Required]
        //[MinLength(2)]
        //SOLID e aykırı bir kullanım. Validation işlemleri Business katmanında yapılmalı.
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
