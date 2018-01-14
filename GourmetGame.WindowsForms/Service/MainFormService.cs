using System.Collections.Generic;
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

        private void ProccessCategories(ICollection<CategoryViewModel> categories)
        {
            foreach (var category in categories)
            {
                if (ProccessCategory(category))
                {
                    ProccessCategories(category.SubCategories);
                }
                else
                {
                    ProccessDishies(category.Dish);
                }
            }
        }

        private void ProccessDishies(List<DishViewModel> dishies)
        {
            foreach (var dish in dishies)
            {
                var questionResult = _messageService.ShowAUserQuestion(dish.Name);
                if (questionResult == DialogResult.Yes)
                    break;
            }
        }

        private bool ProccessCategory(CategoryViewModel category)
        {
            var questionResult = _messageService.ShowAUserQuestion(category.Name);

            if (questionResult == DialogResult.No) return false;

            return true;
        }
    }
}