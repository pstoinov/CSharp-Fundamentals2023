﻿using System;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleTokens = Console.ReadLine().Split(", ");
            string title = articleTokens[0];
            string content = articleTokens[1];
            string author = articleTokens[2];

            Article article = new Article(title, content, author);
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }

            }
            Console.WriteLine(article.ToString());

        }

        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            private string Title { get; set; }
            private string Content { get; set; }
            private string Author { get; set; }

            public void Edit(string newContent)
            {
                Content = newContent;
            }

            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }

            public void Rename(string newTitle)
            {
                Title = newTitle;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
