using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;
namespace MyCompany.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        // метод выборки всех текстовых полей
        IQueryable<TextField>GetTextFields();
        //выбрать текстовое поле по Id
        TextField GetTextFieldById(Guid id);
        //выбрать техтовое поле по его кодовому слову
       TextField GetTextFieldByCodeWord(string codeWord);
        // сохранить изменения в БД
        void SaveTextField(TextField entity);
        // удалить текстовое поле
        void DeleteTextField(Guid id);

    }
}
