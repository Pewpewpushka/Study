using Microsoft.EntityFrameworkCore;
using MyCompany2.Domain.Entities;
using MyCompany2.Domain.Repositories.Abstract;
using System;
using System.Linq;

namespace MyCompany2.Domain.Repositories.EntityFramework
{   
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        // связь наших объектов сайта с БД
        private readonly AppDbContext context;
        public EFTextFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }
        // реализуем методы, обращаемся к context и выбираем все записи из таблицы TextFields
        public IQueryable<TextField> GetTextFields()
        {
            return context.TextFields;
        }
        //пишем метод если хотим выбрать одну запись FirstOrDefault
        public TextField GetTextFieldById(Guid id)
        {
            return context.TextFields.FirstOrDefault(x => x.Id == id);
        }
        // если выбираем по ключевому слову
        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }
        // сохраняем и проверяем
        public void SaveTextField(TextField entity)
        { // если Id  = значению по умолчанию, то предпологается что новая запись создана и Id для нее еще нет 
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;// помечаем его ключом что это новый объект , и добавит его в БД
            else
                // если Id  есть у объекта (не сотвествует стандартному значению Guid), помечаем флагом что он изменен есть  в БД но изменились занчения св-в 
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();// обращаемся к context  и сохраняем изменения
        }
        // удаляем текстовое поле из БД
        public void DeleteTextField(Guid id)
        {
            // обращаемся к свойству таблицы ввызываем метод Remove создаем фековый объект и назаначаем ему id  и по нему удаляем соотв. запись
            context.TextFields.Remove(new TextField() { Id = id });
            context.SaveChanges();// сохраняем в  Context
        }

        //public TextField GetTextFieldCodeWord(string codeWord)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

