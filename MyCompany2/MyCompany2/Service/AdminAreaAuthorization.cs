using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace MyCompany2.Service
{
    public class AdminAreaAuthorization : IControllerModelConvention
    {
        private readonly string area;
        private readonly string policy;

        public AdminAreaAuthorization (string area, string policy)
        {
            this.area = area;
            this.policy = policy;
        }

        public void Apply (ControllerModel controller)
        {

            //проверяем для контроллера его атрибуты если присутствует атрибут AreaAttribute то добавлеям фильтр AuthorizeFilter, отпавляем пользователя на авторитизацию
            if (controller.Attributes.Any(a =>
                     a is AreaAttribute && (a as AreaAttribute).RouteValue.Equals(area, StringComparison.OrdinalIgnoreCase))
                 || controller.RouteValues.Any(r =>
                     r.Key.Equals("area", StringComparison.OrdinalIgnoreCase) && r.Value.Equals(area, StringComparison.OrdinalIgnoreCase)))
            {
                controller.Filters.Add(new AuthorizeFilter(policy));
            }



        }

    }
}
