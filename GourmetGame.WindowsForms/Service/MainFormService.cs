using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GourmetGame.Application.Service.Interface;
using GourmetGame.Application.ViewModel;
using GourmetGame.WindowsForms.Properties;
using GourmetGame.WindowsForms.Service.Interface;

namespace GourmetGame.WindowsForms.Service
{
    public class MainFormService : IMainFormService
    {
        private readonly DishViewModel _fallbackDish;
        private readonly IUserDisplayMessageService _messageService;
        private readonly ICategoryAppService _service;

        public MainFormService(ICategoryAppService service, IUserDisplayMessageService messageService)
        {
            _service = service;
            _messageService = messageService;
            _fallbackDish = new DishViewModel {Name = "Bolo de Chocolate"};
        }

        public void StartGame()
        {
            var categories = _service.GetAll().ToList();
            if (!ProccessCategories(categories))
            {
                var newCategory = ProccessDish(_fallbackDish);
                if (newCategory != null)
                    _service.Add(newCategory);
            }
        }

        private bool ProccessCategories(IList<CategoryViewModel> categories)
        {
            foreach (var category in categories)
            {
                category.IsCategorySelected = ProccessCategory(category);

                if (!category.IsCategorySelected) continue;

                var subCategories = _service.FindSubCategoriesById(category.Id).ToList();
                category.IsCategorySelected = !ProccessCategories(subCategories);

                if (category.IsCategorySelected) AddNewDish(category);

                return true;
            }

            return false;
        }

        private void AddNewDish(CategoryViewModel category)
        {
            var newCategory = ProccessDish(category.Dish);
            if (newCategory != null)
            {
                newCategory.CategoryId = category.Id;
                newCategory.Dish.CategoryId = category.CategoryId;
                _service.Add(newCategory);
            }
        }

        private CategoryViewModel ProccessDish(DishViewModel dish)
        {
            var quetionResult =
                _messageService.ShowAUserQuestion(string.Format(Resources.CategoryUserMessage, dish.Name));
            if (quetionResult == DialogResult.No)
                return CreateNewDish(_messageService.GetUserInput(Resources.DishUserInputCaption), dish.Name);
            _messageService.ShowAUserInfo(Resources.SuccessUserMessage);
            return null;
        }

        private CategoryViewModel CreateNewDish(string newDishName, string dishName)
        {
            if (string.IsNullOrWhiteSpace(newDishName)) return null;

            var dish = new DishViewModel {Name = newDishName, Id = Guid.NewGuid()};
            var category =
                CreateNewCategory(_messageService.GetUserInput(string.Format(Resources.CategoryUserInputCaption,
                    newDishName, dishName)));
            category.Dish = dish;

            return category;
        }

        private static CategoryViewModel CreateNewCategory(string categoryName)
        {
            return new CategoryViewModel {Name = categoryName, Id = Guid.NewGuid()};
        }


        private bool ProccessCategory(CategoryViewModel category)
        {
            return _messageService.ShowAUserQuestion(string.Format(Resources.CategoryUserMessage, category.Name)) ==
                   DialogResult.Yes;
        }
    }
}