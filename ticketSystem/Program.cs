using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ticketSystem
{
    static class Tickets
    {
        public static void Main(string[] args)
        {
        string file = "tickets.csv";
                string selection;
            int TicketID = 0;
          

            do { 

                Console.WriteLine("1.Enter new ticket");
                Console.WriteLine("2.Read current tickets");
                Console.WriteLine("3.Exit Program");

                selection = Console.ReadLine();

                if (selection == "1")
                {
                    StreamWriter fileWriter = new StreamWriter(file);

                    TicketID++;
                    string Summary;
                    string Status;
                    string Priority;
                    string Submitter;
                    string Assigned;
                    string Watching;



                    Console.WriteLine("What is this ticket for?");
                    Summary = Console.ReadLine();


                    Console.WriteLine("What is the status of this ticket?");
                    Status = Console.ReadLine();

                    Console.WriteLine("What is the priority of this ticket?");
                    Priority = Console.ReadLine();

                    Console.WriteLine("What is your name?");
                    Submitter = Console.ReadLine();

                    Console.WriteLine("Whos this ticket for");
                    Assigned = Console.ReadLine();

                    Console.WriteLine("Whos watching this ticket?");
                    Watching = Console.ReadLine();

                    fileWriter.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}", TicketID, Summary, Status, Priority, Submitter, Assigned, Watching);
                    {
                        fileWriter.Close();
                    }

                }

              
                else if (selection == "2")
                {
                    if (File.Exists(file))
                    {

                        Console.WriteLine("These are the current tickets");
                        StreamReader fileReader = new StreamReader(file);
                        while (!fileReader.EndOfStream)
                        {
                            string line = fileReader.ReadLine();

                            string[] array = line.Split(',');

                            Console.WriteLine(array);


                        }
                    }
                    else
                    {
                        Console.WriteLine("File does not exist!");
                    }

              
                }

            } while (selection == "1" || selection == "2");

        }
        }
    } 

