using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern
{
    class ProgramUI
    {
        //Challenge Write a method that shows all streaming content of one user selected genre, Write a method that parses a float 
        private StreamingContentRepository _showRepo;
        private List<StreamingContent> _shows;

        public ProgramUI()
        {
            _showRepo = new StreamingContentRepository();
            _shows = _showRepo.GetContentList();
        }

        public void Run()
        {
            while (RunMenu()) { }
        }

        private bool RunMenu()
        {
            Console.Clear();
            Console.WriteLine($"What do you want to do?\n" +
                $"1. See all shows\n" +
                $"2. Add new show to list\n" +
                $"3. Exit");
            while (true)
            {
                switch (ParseIntput())
                {
                    case 1:
                        PrintAllShows();
                        return true;
                    case 2:
                        CreateNewShow();
                        return true;
                    case 3:
                        return false;
                    default:
                        return true;
                }
            }
        }

        private void PrintAllShows()
        {
            foreach (StreamingContent content in _shows)
            {
                Console.WriteLine($"{content.ContentTitle} {content.Genre} {content.IsMature} {content.StarRating}");
            }
            Console.ReadLine();
        }

        private void CreateNewShow()
        {
            Console.WriteLine("Enter new show title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter genre number:\n" +
                "1. Science Fiction\n" +
                "2. Romance\n" +
                "3. Action");
            int genreInput = ParseIntput();

            Genre genre;
            switch (genreInput)
            {
                case 1:
                    genre = Genre.ScienceFiction;
                    break;
                case 2:
                    genre = Genre.Romance;
                    break;
                default:
                    genre = Genre.Action;
                    break;
            }

            Console.WriteLine("Enter show runtime in minutes: ");
            float length = ParseFloatPut();

            StreamingContent newShow = new StreamingContent(title, genre, length);
            _showRepo.AddContentToList(newShow);
            Console.WriteLine($"\"{title}\" added to list.");
            Console.ReadLine();
        }

        private int ParseIntput()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        private float ParseFloatPut()
        {
            float input = float.Parse(Console.ReadLine());
            return input;
        }
    }
}
    //First Walkthrough
    //StreamingContentRepository _contentRepo = new StreamingContentRepository();

    //public void Run()
    //{
    //    bool running = true;
    //    while (running)
    //    {
    //        Console.Clear();
    //        Console.WriteLine("What would you like to do?\n" +
    //            "1. Add content to list\n" +
    //            "2. Display list\n" +
    //            "3. Exit");

    //        string input = Console.ReadLine();
    //        int choice = int.Parse(input);

    //        switch (choice)
    //        {
    //            case 1:
    //                AddContent();
    //                break;
    //            case 2:
    //                DisplayList();
    //                break;
    //            case 3:
    //                running = false;
    //                break;
    //        }
    //    }
    //}

    //private void AddContent()
    //{
    //    //Title Genre Length IsMature Rating
    //    StreamingContent newContent = new StreamingContent();

    //    Console.WriteLine("Enter the title:");
    //    newContent.ContentTitle = Console.ReadLine();

    //    Console.WriteLine("Enter the genre:");
    //    newContent.Genre = Console.ReadLine();

    //    Console.WriteLine("Enter the length in minutes:");
    //    string lengthAsString = Console.ReadLine();
    //    newContent.Length = float.Parse(lengthAsString);

    //    Console.WriteLine("This is mature content (true/false)");
    //    string isMature = Console.ReadLine().ToLower();
    //    if (isMature == "true")
    //    {
    //        newContent.IsMature = true;
    //    }
    //    else
    //    {
    //        newContent.IsMature = false;
    //    }

    //    Console.WriteLine("Enter the rating:");
    //    string ratingAsString = Console.ReadLine();
    //    newContent.Rating = int.Parse(ratingAsString);

    //    _contentRepo.AddContentToList(newContent);
    //}

    //private void DisplayList()
    //{
    //    List<StreamingContent> contentList = _contentRepo.GetStreamingContentList();

    //    foreach (StreamingContent content in contentList)
    //    {
    //        Console.WriteLine($"{content.ContentTitle} is {content.Length} minutes long.");

    //        if (content.IsMature)
    //        {
    //            Console.WriteLine("This is mature content.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("This is family friendly");
    //        }

    //        Console.WriteLine();
    //    }

    //    Console.ReadKey();
    //}
