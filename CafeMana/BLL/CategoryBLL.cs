using System;
using System.Collections.Generic;
using CafeMana.DTO;
using CafeMana.DAL;

namespace CafeMana.BLL
{
    class CategoryBLL
    {
        private static CategoryBLL _Instance;

        internal static CategoryBLL Instance
        {
            get { if (_Instance == null) _Instance = new CategoryBLL(); return _Instance; }
            private set { _Instance = value; }
        }

        private CategoryBLL() { }

        public List<Category> RetreiveAllCategories()
        {
            return DataAccess.Instance.RetreiveAllCategories();
        }

        public Category RetreiveCategory(int ID)
        {
            foreach (Category category in Data.Instance.CategoriesList)
            {
                if (category.ID == ID) return category;
            }
            return null;
        }
    }
}
