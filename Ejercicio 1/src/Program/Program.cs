using System;

namespace Ucu.Poo.Expert
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            
            BookUbication bookUbication1 = new BookUbication();
            bookUbication1.ShelveBook(book1,"B","3");
            
            BookUbication bookUbication2 = new BookUbication();
            bookUbication2.ShelveBook(book2,"A","7");
        }
    }
}