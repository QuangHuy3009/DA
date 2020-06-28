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

        public int RetreiveCategoryID()
        {         
            return ++Data.Instance.IdentityCategory;
        }

        public int RetreiveIdentityCategory()
        {
            return DataAccess.Instance.RetreiveIdentityCategory();
        }

        public void AddNewCategory(Category category)
        {
            Data.Instance.CategoriesList.Add(category);
            DataAccess.Instance.AddNewCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            List<Category> CategoriesList =Data.Instance.CategoriesList;
            for (int i = 0; i < CategoriesList.Count; i++)
            {
                if (CategoriesList[i].ID == category.ID)
                {
                    CategoriesList[i].Name=category.Name;
                    CategoriesList[i].Description = category.Description;
                    CategoriesList[i].Image = category.Image;
                    break;
                }
            }
            DataAccess.Instance.UpdateCategory(category);
        }

        public void DeleteCategory(int ID)
        {
            List<Category> CategoriesList = Data.Instance.CategoriesList;
            int Index = 0;
            for (int i = 0; i < CategoriesList.Count; i++)
            {
                if (CategoriesList[i].ID == ID) { Index = i; break; }
            }
            if (DataAccess.Instance.DeleteSomething(ID, "Categories")==true) CategoriesList.RemoveAt(Index);

        }

    }
}
