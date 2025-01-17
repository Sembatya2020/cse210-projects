using System;

class Program
{
    static void Main(string[] args)
    {
        Journal TheJournal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEntry(TheJournal);
                    break;
                case "2":
                    TheJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    TheJournal.SaveToFile(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    TheJournal.LoadFromFile(loadFilename);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddEntry(Journal journal)
    {
        Console.Write("Enter the date (yyyy-mm-dd): ");
        string date = Console.ReadLine();

        Console.Write("Enter the prompt text: ");
        string promptText = Console.ReadLine();

        Console.Write("Enter your entry text: ");
        string entryText = Console.ReadLine();

        Entry newEntry = new Entry
        {
            _date = date,
            _promptText = promptText,
            _entryText = entryText
        };

        journal.AddEntry(newEntry);
    }
}
