using System;
using System.Collections.Generic;
using VideoMenuEntity;

namespace VideoMenuUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            Video video1 = new Video()
            {
                Id = id++,
                Name = "Generic cat video 329"
            };
            videos.Add(video1);
            videos.Add(new Video()
            {
                Id = id++,
                Name = "Something, something clickbait"
            });

            String[] menuItems = {
                "List all Videos",
                "Add Video",
                "Delete Video",
                "Edit Video",
                "Exit\n"
            };

            var selection = ShowMenu(menuItems);

            while (selection != 5)
            {
                switch (selection)
                {
                    case 1:
                        ListVideos();
                        break;
                    case 2:
                        AddVideos();
                        break;
                    case 3:
                        DeleteVideos();
                        break;
                    case 4:
                        EditVideos();
                        break;
                    default:
                        break;
                }
                selection = ShowMenu(menuItems);
            }
            Console.WriteLine("See ya!");

            Console.ReadLine();
        }

        private static void EditVideos()
        {
            var video = FindVideoById();
            Console.WriteLine("Name: ");
            video.Name = Console.ReadLine();
        }

        private static Video FindVideoById()
        {
            Console.WriteLine("Insert Video Id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a number");
            }
        }
        private static void DeleteVideos()
        {
            var videoFound = FindVideoById();
            if (videoFound != null)
            {
                videos.Remove(videoFound);
            }
        }

        private static void AddVideos()
        {
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
        }

        private static void ListVideos()
        {
            Console.WriteLine("\nList of Videos");
            foreach (var video in videos)
            {
                Console.WriteLine($"Video: {video.Id} Name: {video.Name}");
            }
            Console.WriteLine("\n");
        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("What do you want to do, select a number between 1-5:\n");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine((i + 1) + ":" + menuItems[i]);
            }

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 5)
            {
                Console.WriteLine("you need to select a number between 1-5");
            }

            Console.WriteLine("selection: " + selection);
            return selection;
        }
    }
}