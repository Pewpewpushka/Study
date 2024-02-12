using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using MyCompany2.Domain;

namespace MyCompany2.Models.ViewComponents
{
    public class SidebarViewComponent: ViewComponent
    {
        private readonly DataManager dataManager;

        public SidebarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
      
        //создаем асинхронный метод возвращаем представление Default
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult) View("Default",dataManager.ServiceItems.GetServiceItems()));

        }




    }   
    
}
