using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluee
{
    public class Quest
    {
        public string QuestText { get; set; }
        public string QuestAnswer { get; set; }
        public int Id { get; set; }

        public Quest(int id,string quests, string questAnswer)
        {
            QuestText = quests;
            QuestAnswer = questAnswer;
            Id = id;
        }
        public string Description()
        {
            return " QUEST: " + this.QuestText + " ANSWER: " + this.QuestAnswer;
        }

    }
}
