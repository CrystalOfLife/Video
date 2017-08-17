using System;

namespace VideoMenu
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        Console.WriteLine("List Videos\n");
                        break;
                    case 2:
                        Console.WriteLine("add Videos\n");
                        break;
                    case 3:
                        Console.WriteLine("Delete Videos\n");
                        break;
                    case 4:
                        Console.WriteLine("Edit Videos\n");
                        break;
                    default:
                        break;
                }
                selection = ShowMenu(menuItems);
            }
            Console.WriteLine("See ya!");

            Console.ReadLine();
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