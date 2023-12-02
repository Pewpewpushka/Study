using MyCompany.Domain.Entities;
using System.Linq;
using System;
using System.Threading.Tasks;
using MyCompany.Domain.Repositories.Abstract;
namespace MyCompany.Domain
{
    // обслуживающий класс котором реализовано управление репозиториями
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItemsRepository { get; set; }
        // через свойства Datamanager будем управлять тем или иным действием
        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository ) 
        {

            TextFields = textFieldsRepository;
            ServiceItemsRepository = serviceItemsRepository;
        }
    }
}
