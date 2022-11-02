using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    interface IMassiveVictorins
    {
        IMyXmlFile XmlFile { get; set; }
        List<IVictorina> VictorinaList { get; set; }
    }

    interface IVictorina
    {
        IMyXmlFile XmlFile { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        List<IQuestion> questions { get; set; }
        public void Start();
        public void Save();
        public void Load();
    }

    interface IQuestion
    {
        public string Name { set; get; }
        List<string> variants { get; set; }
        List<int> answers { get; set; }
        public string ToString();
    }

    interface IUser
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
        public string ToString();
    }

    interface IAuth
    {
        IMyXmlFile XmlFile { get; set; }
        public bool GetAuth(IUser user);
        public string GetUserName(IUser user);
    }

    interface IRegister
    {
        IMyXmlFile XmlFile { get; set; }
        public bool SaveNewUser(IUser user);
        public bool ExistUser(IUser user);
    }
    interface Settings
    {
        IMyXmlFile XmlFile { get; set; }
        public bool ChangeUserSettingsPassword(IUser user, string password);
        public bool ChangeUserSettingsBirthDate(IUser user, DateTime date);
        public bool ChangeUserSettingsAll(IUser user, string password, DateTime date);
    }

    interface IMyXmlFile
    {
        public bool ExistFile(string path);
        public IVictorina GetVictorina(string path);
        public bool SaveVictorina(string path, IVictorina victorina);
        public IUser GetUser(string path);
        public bool SaveUser(string path, IUser user, bool rewrite = false);
        public ResultTable GetResultTable(string path);
        public bool SaveResultTable(string path, ResultTable rt);
        public IMassiveVictorins GetAllVictorins();
    }

    interface ResultTable   //мой
    {
        public string Name { get; set; }//Имя викторины
        IMyXmlFile XmlFile { get; set; }//файл 
        List<TableItem> TableItems { get; set; }// таблица списком
        public string Path { get; set; }//путь
        public void SaveResultTable();  //сохранение результата
        public string Top20(string name);//топ игроков
        public string AllResults(string name);//все результаты
    }

    interface TableItem   //мой
    {
        public string Score { get; set; }//счет
        public string NameUser { get; set; }//имя игрока
        public string NameVictorina { get; set; }//название викторины
        public string ToString();
    }

    interface IEditor
    {
        IMyXmlFile XmlFile { get; set; }
        IVictorina Victorina { get; set; }
        public void NewVictorina();
        public void SaveVictorina();
        public void EditVictorina();
    }
    public string AllResults(string name)
    {

    }

}
