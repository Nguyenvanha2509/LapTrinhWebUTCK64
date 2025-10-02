using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        //danh sach cac cuon sach (nho using System.Collections.Generic)
        public List<Book> GetBooksList()
        {
           List<Book> books = new List<Book>()
           {
               new Book(){
                Id=1, 
                Title="Book 1",
                AuthorId=-1,
                GenreId=1,
                Image="/images/products/b1.jpg",
                Price=500000,
                TotalPage=250,   
                Sumary="This is book 1"
           },
           new Book(){
                Id=2, 
                Title="Book 2",
                AuthorId=-1,
                GenreId=2,
                Image="/images/products/b2.jpg",
                Price=600000,
                TotalPage=300,   
                Sumary="This is book 2"
           },
           new Book(){
                 Id=3, 
                 Title="Book 3",
                 AuthorId=-1,
                 GenreId=3,
                 Image="/images/products/b3.jpg",
                 Price=700000,
                 TotalPage=350,   
                 Sumary="This is book 3"
              },
           new Book(){
                  Id=4, 
                  Title="Book 4",
                  AuthorId=-1,
                  GenreId=4,
                  Image="/images/products/b4.jpg",
                  Price=800000,
                  TotalPage=400,   
                  Sumary="This is book 4"
                  },
           };
           return books;
        }

        //chi tiet 1 cuon sach theo id (nhosw using System.Linq)
        public Book GetBookById(int id)
        {
            Book book = this.GetBooksList().FirstOrDefault(b => b.Id == id);
            return book;

        }
        // SelectListItem Authours (using Microsoft.AspNetCore.Mvc.Rendering)
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="NamCao"},
            new SelectListItem{Value="2", Text="NguyenNhatAnh"},
            new SelectListItem{Value="3", Text="NguyenHien"},
            new SelectListItem{Value="4", Text="NguyenTrai"}

        };

        //SelectListItem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="TrinhTham"},
            new SelectListItem{Value="2", Text="KinhDi"},
            new SelectListItem{Value="3", Text="VienTuong"},
            new SelectListItem{Value="4", Text="LangMan"}
        };


    }
}
