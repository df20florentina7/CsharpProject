using bluee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace blueM
{
    public class QuestMrg:MrgAbstract
    {
        //initialize the quests list
        public void InitQuest()
        {
            XmlDocument document = new XmlDocument();
            document.Load("Quest.xml");
            XmlNodeList lista_nod = document.SelectNodes("/quest/Quest");
            foreach (XmlNode noduri in lista_nod)
            {
                string questText = noduri["QuestText"].InnerText;
                string questAnswer = noduri["QuestAnswer"].InnerText;
                quests.Add(new Quest(CountQuests+1,questText, questAnswer));
                CountQuests++;
            }
        }
        

    }
}
