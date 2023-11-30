using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;
using System;
using System.Linq;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        public void DeleteTextField(Guid id)
        {
            throw new NotImplementedException();
        }

        public TextField GetTextFieldById(Guid id)
        {
            throw new NotImplementedException();
        }

        public TextField GetTextFieldCodeWord(string codeWord)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TextField> GetTextFields()
        {
            throw new NotImplementedException();
        }

        public void SaveTextField(TextField entity)
        {
            throw new NotImplementedException();
        }
    }
}
