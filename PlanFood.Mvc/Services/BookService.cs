using System.Collections.Generic;
using System.Linq;
using PlanFood.Mvc.Context;
using PlanFood.Mvc.Models.Db;
using PlanFood.Mvc.Services.Interfaces;

namespace PlanFood.Mvc.Services
{
    public class BookService : IBookService
    {
        private readonly PlanFoodContext _context;

        public BookService(PlanFoodContext planFoodContext)
        {
            _context = planFoodContext;
        }

        public bool Create(Book book)
        {
            _context.Books.Add(book);
            return _context.SaveChanges() > 0;
        }

        public Book Get(int id)
        {
            return _context.Books.SingleOrDefault(b => b.Id == id);
        }

        public IList<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public bool Update(Book book)
        {
            _context.Books.Update(book);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);
            if (book == null)
                return false;

            _context.Books.Remove(book);
            return _context.SaveChanges() > 0;
        }
    }
}
