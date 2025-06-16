using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal; //Bağımlılığı constructor ile veriyoruz
        public CategoryManager(ICategoryDal categoryDal) 
        {
            _categoryDal = categoryDal; //Bağımlılığı constructor ile veriyoruz
        }
        public List<Category> GetAll()
        {
            // İş kodları burada yer alacak.
            return _categoryDal.GetAll(); //DataAccess katmanındaki GetAll metodunu çağırıyoruz.

        }

        // Select * from Categories where CategoryId = 1 
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId); //DataAccess katmanındaki Get metodunu çağırıyoruz.
        }
    }
}
