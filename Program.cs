using EmirHomework;

Console.WriteLine("Hello");

BookContext bookdb = new BookContext();
/*
---------------------KİTAP EKLEME--------------------


Book book = new Book()
{
    Name = "Batman",
    Author = "McGregor",
    Publisher = "DC"
};

bookdb.Book.Add(book);
bookdb.SaveChanges();
*/





/*
 ---------------------KİTAP SİLME-----------------------

var book = bookdb.Book.Find(3);
if(book != null)
{
    bookdb.Book.Remove(book);
    bookdb.SaveChanges();
}
else
{
    Console.WriteLine("No Book!!");
}

*/



/* ----------------------KİTAP GÜNCELLEME-----------------------

 var book = bookdb.Book.Where(x => x.Name =="Batman").FirstOrDefault();
book.Publisher = "Khabib";
bookdb.SaveChanges();
 
*/ 
 
 