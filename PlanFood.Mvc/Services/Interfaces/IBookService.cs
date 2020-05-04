using System.Collections.Generic;
using PlanFood.Mvc.Models.Db;

namespace PlanFood.Mvc.Services.Interfaces
{
	public interface IBookService
	{
		bool Create(Book book);
		Book Get(int id);
		IList<Book> GetAll();
		bool Update(Book book);
		bool Delete(int id);
	}
}