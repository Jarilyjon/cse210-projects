using System;
using System.Collections.Generic;
using System.IO;


class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }
    }

class Journal
    {
        public List<Entry> Entries { get; set; }

        public Journal()
        {
            Entries = new List<Entry>();
        }
    }

class Program
    {
        static void Main(string[] args)
        {

            Journal journal = new Journal();

            int answer = 0;

            while (answer != 5)
            {
                Console.WriteLine("Make a selection: ");
                Console.WriteLine("1: Write");
                Console.WriteLine("2: Display");
                Console.WriteLine("3: Load");
                Console.WriteLine("4: Save");
                Console.WriteLine("5: Quit");

                answer = int.Parse(Console.ReadLine());

                if (answer == 1){
                    SaveEntry();
                }

                if (answer == 2){
                    DisplayJournal(journal);
                }


                if (answer == 3){

                }


                if (answer == 4){

                }

                if (answer == 5){

                }


            }


        }


        static void SaveEntry()
            {
                List<string> prompts = new List<string>()
                {
                    
                    "What are three things I'm grateful for today?",
                    "What did I learn today?",
                    "How did I challenge myself today?",
                    "What was the biggest accomplishment of my day?",
                    "What was a positive interaction I had with someone today?",
                    "What was the best moment of my day?",
                    "What did I do for self-care today?",
                    "How did I show kindness to someone else today?",
                    "What are my goals for tomorrow?",
                    "Reflect on a challenge I faced today and how I overcame it."
                };

                Random rand = new Random();
                int randomIndex = rand.Next(0, prompts.Count);
                string selectedPrompt = prompts[randomIndex];

                Console.WriteLine(selectedPrompt);
                string response = Console.ReadLine();

                Entry entry = new Entry
                {
                    Prompt = selectedPrompt,
                    Response = response,
                    Date = DateTime.Now
                };

                Console.WriteLine("Prompt: " + entry.Prompt);
                Console.WriteLine("Response: " + entry.Response);
                Console.WriteLine("Date: " + entry.Date);
            }


        static void DisplayJournal(Journal journal)
        {
            Console.WriteLine("Journal Entries:");
            Console.WriteLine("----------------");

      foreach (Entry entry in journal.Entries)
            {
                Console.WriteLine("Prompt: " + entry.Prompt);
                Console.WriteLine("Response: " + entry.Response);
                Console.WriteLine("Date: " + entry.Date);
                Console.WriteLine();
            }
        }


        
    }
    