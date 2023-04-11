using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using bluee;
namespace blueM
{
    public abstract class MrgAbstract
    {
        protected static List<Employee> employees = new List<Employee>();
        protected static List<Quest> quests = new List<Quest>();
        protected static int CountQuests { get; set; } = 0;
        //prints the employees 
        public void Write2Console()
        {
            foreach (Employee elem in interogare_linq)
            {
                Console.Write(elem.Description()+" BADGES:");
                elem.BadgesPrint();
                Console.WriteLine();
            }

        }
        //prints the quests
        public void Write()
        {
            foreach (Quest q in quests)
            {
                Console.WriteLine(q.Description());
            }
        }
        IEnumerable<Employee> interogare_linq =
           from elem in employees
           orderby elem.Tokens
           select elem;
        
        //method for the game
        public void Game(string? name)
        {
            string? answ = "no";
            bool ? flag = false;
            Employee e = new Employee();
            foreach (Employee elem in employees)
            {
                if (elem.Name == name)
                {
                    e = elem;
                    flag= true;
                }
                
            }
            if (flag == true)
            {
                do
                {
                    int questNumber = RandomNumber();
                    foreach (Quest quest in quests)
                    {
                        if (quest.Id == questNumber)
                        {
                            Console.WriteLine(quest.QuestText);
                            Console.WriteLine("Input your answer: ");
                            string? answer = Console.ReadLine();
                            if (answer == quest.QuestAnswer)
                            {
                                Console.WriteLine("     Congratulation! You won 100 tokens!");
                                e.Tokens += 100;
                                Bonus(e);
                            }
                            else Console.WriteLine("    Your answer is incorrect!");
               
                            Console.WriteLine("Do you want to keep playing:(yes/no) ");
                            answ = Console.ReadLine();
                        }
                    }
                } while (answ == "yes");
            }
            else Console.WriteLine(" The employee is not part of the list");
        }

        //method that gives the bonuses
        public void Bonus(Employee emp)
        {
            
                if (emp.Tokens == 100)
                {
                     emp.AddInList("The First Step");
                    Console.WriteLine("    You won your first badge and a gift card of choice. Congratulation!");
                }
                if (emp.Tokens == 300)
                {
                     emp.AddInList("Learning New Things");
                     Console.WriteLine("    You won your first BONUS a gift of your choice. Congratulation!");
                }
                if (emp.Tokens == 500)
                {
                     emp.AddInList("The Biggest Involment");
                     Console.WriteLine("    You won half a day off. Congratulation!");
                }
                if (emp.Tokens == 700)
                {
                      emp.AddInList("Quiz Breaker");
                      Console.WriteLine("   You won a day of. Congratulation!");
                }
                if (emp.Tokens >= 900)
                {
                      emp.AddInList("Perfect Score");
                      Console.WriteLine("   You won a three day vacation to a destination of choice. Congratulation!");
                }
                
            
        }
        private readonly Random random = new Random();
        public int RandomNumber()
        {
            return random.Next(0, CountQuests+1);
        }
        //adds a new quest when an employee has a certain number of points/tokens
        public void addQuest()
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine("Employee Name: " + emp.Name);
                if (emp.Tokens >= 300) {
                    Console.WriteLine("Congratulation you can add a new quest!");
                    Console.WriteLine("introduce a quest:");
                    string? text = Console.ReadLine();
                    Console.WriteLine("introduce the answer:");
                    string? answer = Console.ReadLine();

                    quests.Add(new Quest(CountQuests + 1, text, answer));
                    CountQuests++;
                }
            }
        }
    }
}
