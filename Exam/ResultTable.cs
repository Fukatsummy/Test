using ExamConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class ResultTable
    {
        public string Name { get; set; }//Имя викторины
        IMyXmlFile XmlFile { get; set; }//файл 
        List<TableItem> TableItems { get; set; }// таблица элементов
        public string Path { get; set; }//путь
        public void SaveResultTable();  //сохранение результата
        public string Top20(string name);//топ игроков
        public string AllResults(string name);//все результаты

        public void SaveResultTable(string name)
        {
            object login = null;
            //XmlFile.SaveResultTable(ResultTable);
            List<TableItem> scoreUser = GetScoreUser(login);
            //проверка    //count  для подсчёта
            if(scoreUser.Count ==0)
            {
                Console.WriteLine("Нет результатов!");
            }
            else
            {
                foreach (var score in scoreUser)
                    Console.WriteLine($"{score.name} {score}");
            }

        }

        private List<TableItem> GetScoreUser(object login)
        {
            throw new NotImplementedException();
        }

        public string Top20(int top, string name)
        {
            List<TableItem> topItem = Gettop(name);
            //проверка
            if(topItem.Count==0)
            {
                Console.WriteLine("Нет результатов!");
            }
            else
            {
                //top=top>topItem.Count;
                //topItem.Count = top;
                for (int i=0;i<top;i++)
                {
                    TableItem score = topItem[i];
                    Console.WriteLine($"{i} {score.UserName} { score}");

                }
            }
        }

        private List<TableItem> Gettop(string name)
        {
            throw new NotImplementedException();
        }
    }
}
