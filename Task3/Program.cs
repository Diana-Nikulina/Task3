using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
class Book
{
    //свойства
    public string Title { get; set; }
    string Author { get; set; }
    int Pages { get; set; }

    //конструктор
    public Book(string title,string author,int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    //метод возращающий информацию о книге
    public string GetInfo()
    {
        return $"Название:{Title}, Автор:{Author}, Страницы:{Pages}";


    }
}
class Library()
{
    public List<Book> books = new List<Book>();

    public void Add(Book book)
    {

        books.Add(book);
    }

    public void SchowBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("В библиотеке нет книг");
        }
        foreach (var book in books)
        {
            Console.WriteLine(book.GetInfo());
        }
    }
    public Book FindBook(string title)
    {
        foreach (var book in books) 
        { 
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase)) 
            { 
                return book; 
            }
        }
        return null; // Если книга не найдена }
    }
    static void Main()
    {
        Library library = new Library();
        library.Add(new Book("Мой лучший враг", "Эли Фрей", 448));
        library.Add(new Book("Белый клык", "Джек Лондон", 384));
        library.Add(new Book("Воскресни за 40 дней", "Медина Мирай", 272));
        Console.WriteLine("Доступные книги в библиотеке:");
        library.SchowBooks();
        Console.WriteLine("Введите название книги для поиска(с заглавной буквы):");
        string findTitle = Console.ReadLine();
        Book foundBook = library.FindBook(findTitle);
        if (foundBook != null)
        {
            Console.WriteLine($"Книга '{foundBook.Title}' найдена.");
            Console.WriteLine(foundBook.GetInfo());
        }
        else
        {
            Console.WriteLine("Книга не найдена.");
        }
    }
    
}
