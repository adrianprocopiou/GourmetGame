using System.Collections.Generic;

namespace GourmetGame.Application.Service.Interface
{
    public interface IAppService<TViewModel> where TViewModel : class
    {
        void Add(TViewModel obj);
        IEnumerable<TViewModel> GetAll();
    }
}