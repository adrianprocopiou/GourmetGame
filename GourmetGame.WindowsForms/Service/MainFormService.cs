﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GourmetGame.Application.Service.Interface;
using GourmetGame.Application.ViewModel;
using GourmetGame.WindowsForms.Service.Interface;

namespace GourmetGame.WindowsForms.Service
{
    public class MainFormService : IMainFormService
    {
        private readonly ICategoryAppService _service;
        private readonly IUserDisplayMessageService _messageService;

        public MainFormService(ICategoryAppService service, IUserDisplayMessageService messageService)
        {
            _service = service;
            _messageService = messageService;
        }

        public void StartGame()
        {
            var categories = _service.GetAll();
            ProccessCategories(categories.ToList());
        }

        private bool ProccessCategories(ICollection<CategoryViewModel> categories)
        {
            foreach (var category in categories)
            {
                if (!ProccessCategory(category)) continue;

                if (!ProccessCategories(category.SubCategories))
                {
                    ProccessDishies(category.Dish);
                }

                return true;
            }

            return false;
        }

        private void ProccessDishies(DishViewModel dishies)
        {
            var quetionResult = _messageService.ShowAUserQuestion(string.Format(Properties.Resources.CategoryUserMessage,dishies.Name));
            if (quetionResult == DialogResult.No)
                _messageService.ShowAUserInfo(_messageService.GetUserInput(Properties.Resources.DishUserImputCaption));
            else
                _messageService.ShowAUserInfo(Properties.Resources.SuccessUserMessage);
           

        }

        private bool ProccessCategory(CategoryViewModel category)
        {
            return _messageService.ShowAUserQuestion(string.Format(Properties.Resources.CategoryUserMessage,category.Name)) == DialogResult.Yes;
        }
    }
}