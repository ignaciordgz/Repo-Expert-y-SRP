using System;
// No se cumple el principio de SRP ya que la clase Book tiene mas de una razon para cambiar


namespace Ucu.Poo.Expert
{
    public class Book
    {

        private string Title { get ; }
        private string Author { get ; }
        private string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
    
    public class BookUbication
    {
        private string LibrarySector { get ; set; }
        private string LibraryShelve { get ; set; }

        public void ShelveBook(Book book,string sector,string shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}
