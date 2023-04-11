// See https://aka.ms/new-console-template for more information
using blueM;
using bluee;

internal class Program
{
    private static async Task Main(string[] args)
    {
        EmployeeMgr mgrEmployee = new EmployeeMgr();
        mgrEmployee.InitEmployee();

        QuestMrg mgrQuest = new QuestMrg();
        mgrQuest.InitQuest();
        string ans = "no";
        do {
            string? name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            mgrEmployee.Game(name);
            Console.WriteLine("do another employee want to play? (yes/no)");
            ans= Console.ReadLine();
        } while (ans=="yes");
        Console.WriteLine();
        mgrEmployee.addQuest();
        Console.WriteLine();
        Console.WriteLine("THE RANKING IN ASCENDING ORDER IS:");
        mgrEmployee.Write2Console();
        
        mgrQuest.Write();
    }
}