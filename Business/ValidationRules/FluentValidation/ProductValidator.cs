using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        //validation = doğrulama
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(P => P.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1); // Örnek: CategoryId'si 1 olan ürünlerin fiyatı 10'dan büyük veya eşit olmalıdır.
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı"); // Örnek: Ürün adı "A" harfi ile başlamalıdır.

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
