using MyCompany2.Domain.Entities;
using System.Linq;
using System;
using System.Threading.Tasks;


namespace MyCompany2.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        // метод выбора  всех услуг
        IQueryable<ServiceItem> GetServiceItems();
        //выбрать, провалится в услугу выбрать ее по Id
        ServiceItem GetServiceItemById(Guid id);
        // обновить или создать новую услугу
        void SaveServiceItem(ServiceItem entity);
        // удалить услугу
        void DeleteServiceItem(Guid id);
    }
}
