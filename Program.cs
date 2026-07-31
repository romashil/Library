using System;
using System.Collections.Generic;

public class Book
{
    private string nameBook;
    private string titleBook;

    public Book(string name, string title)
    {
        this.nameBook = name;
        this.titleBook = title;
    }
    public void Info()
    {
        Console.WriteLine($"Книга: {nameBook}, Автор: {titleBook}");
    }
    public string GetAuthor()
    {
        return titleBook;
    }
}
public class MainProgram
{
    public static void Main()
    {
        List<Book> booking = new List<Book>();
        while (true)
        {
            Console.WriteLine("Введите название книги (либо 'continue' для продолжения): ");
            string name = Console.ReadLine();
            if (name == "continue")
            {
                break;
            }
            Console.WriteLine("Введите автора книги: ");
            string author = Console.ReadLine();
            booking.Add(new Book(name, author));
        }
        foreach (Book book in booking)
        {
            book.Info();
        }
        while (true)
        {
            Console.WriteLine("(Введите только цифру) \n(1) Выход из программы. \n(2) Поиск книги автора по фамилии.");
            int numb = Convert.ToInt16(Console.ReadLine());
            if (numb == 1)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите фамилию автора: ");
                bool InLibrary = false;
                string Fam = Console.ReadLine();
                foreach (Book book in booking)
                {
                    if (book.GetAuthor().ToUpper() == Fam.ToUpper())
                    {
                        book.Info();
                        InLibrary = true;
                    }
                }
                if (InLibrary == false)
                {
                    Console.WriteLine("Книг данного автора не найдено :(");
                }
            }
        }
    }
}