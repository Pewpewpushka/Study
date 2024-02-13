using Microsoft.AspNetCore.Mvc;
using MyCompany2.Domain;

namespace MyCompany2.Controllers
{
    public class HomeController : Controller
    {   //добавляем доступ к БД
        readonly private DataManager dataManager;
        // создаем текстовое поле 
        public HomeController (DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        
        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));// предаем текстовое поле по ключевому слову
        }

        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }
    }

}
