﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;
using DataAccessLayer;
namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService iCategoryRepository;

        public CategoryService()
        {
            iCategoryRepository = new CategoryRepository();
        }
        public List<Category> GetCategories()
        {
            return iCategoryRepository.GetCategories();
        }
    }
}
