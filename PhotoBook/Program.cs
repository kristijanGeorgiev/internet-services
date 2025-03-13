// See https://aka.ms/new-console-template for more information
#region PhotoBook
using PhotoBook.Polymorphism;
Book PhotoBook = new Book(62);
Book PhotoBook1 = new Book();
BigPhotoBook bigPhotoBook2 = new BigPhotoBook(84);
BigPhotoBook bigPhotoBook3 = new BigPhotoBook();
Console.WriteLine(PhotoBook1.GetNumPages());
Console.WriteLine(PhotoBook.GetNumPages());
Console.WriteLine(bigPhotoBook2.GetNumPages());
Console.WriteLine(bigPhotoBook3.GetNumPages());
#endregion