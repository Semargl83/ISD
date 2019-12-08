using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Book
    {
        public Content MyCont { get; set; }
        public Title MyTitle { get; set; }
        public Author MyAuthor { get; set; }
        public void Show()
        {
            MyAuthor.Show();
            MyTitle.Show();
            MyCont.Show();
            
        }
        public Book()
        {
            MyAuthor = new Author();
            MyTitle = new Title();
            MyCont = new Content();
        }
        public Book(string autName, string bookTitle, string bookContent)
        {
            MyAuthor = new Author();
            MyTitle = new Title();
            MyCont = new Content();
            MyCont.BookContent = bookContent;
            MyAuthor.AutName = autName;
            MyTitle.BookName = bookTitle;
        }
    }
}
