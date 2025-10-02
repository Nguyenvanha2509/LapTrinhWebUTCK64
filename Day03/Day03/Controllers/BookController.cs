using Microsoft.AspNetCore.Mvc;
using Day03.Models;
namespace Day03.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            //danh sach genres convert SelectListItem de hien thi tren combobox
            ViewBag.authors = book.Authors;//truyen du lieu SeclectListItem qua View
            ViewBag.genres = book.Genres;//truyen du lieu SeclectListItem qua View
            var books = book.GetBooksList();
            return View(books);//truyen du lieu qua View duoi dang tham so
        }
    }
}
