using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Dela.Manager
{
    public class Tasker
    {
        public List<Task> Tasks { get; set; } = new List<Task>();
        int count = 1;
        public void addTask(string quest)
        {
            Tasks.Add(new Task() { Id = count++, Quests = quest, Status = "В процессе" });
        }
        public void changeStatus(int Id, string status)
        {
            Tasks[Id-1].Status = status;
        }
        public void delTask(int Id)
        {
            Tasks.Remove(Tasks[Id - 1]);
            string path = @"SpisokD.txt";
            Console.WriteLine("Новый список: ");
            foreach (var item in Tasks)
            {
                Console.WriteLine(item.ToString());
            }
            FileInfo fp = new FileInfo(path);
            fp.Delete();
            Zapis();
            Console.WriteLine("Успешно записано");
        }
        public void Zapis() //Записть структуры в файл
        {
            string path = @"SpisokD.txt";
            XmlSerializer formatter = new XmlSerializer(typeof(List<Task>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Tasks);
            }
        }
        public void Chtenie()
        {
            string path = @"SpisokD.txt";
            XmlSerializer formatter = new XmlSerializer(typeof(List<Task>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    Tasks = formatter.Deserialize(fs) as List<Task> ?? new List<Task>();
                    count = Tasks.Count()+1;
                }

            }
        }

    }
}
