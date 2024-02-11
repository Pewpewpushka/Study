using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Domain.Entities;
using MyCompany.Service;

namespace MyCompany2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager dataManager;
        public TextFieldsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        // передам годовое слово и ищем  БД это представление и передаем его в текстовое поле
        public IActionResult Edit(string codeWord)
        {
            var entity = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
            return View(entity);
        }

        [HttpPost]
        // приходит модель с форомой
        public IActionResult Edit(TextField model)
        {// проверям модель на валидность если да то сохраняем в БД 
            if (ModelState.IsValid)
            {
                dataManager.TextFields.SaveTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}

