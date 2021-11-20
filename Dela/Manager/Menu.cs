using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dela.Manager
{
    public class Menu
    {
        Tasker tasker = new Tasker();
        public Menu(Tasker tasker)
        {
           this.tasker = tasker;
        }
        public void Show()
        {
            int count;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1) Добавить задачу ");
                Console.WriteLine("2) Изменить статус задачи ");
                Console.WriteLine("3) Удалить задачу ");
                Console.WriteLine("4) Все задачи ");
                Console.WriteLine("5) Выход ");

                count = Convert.ToInt32(Console.ReadLine());

                switch (count)
                {
                    case 1:
                        Console.WriteLine("Введите задачу");
                        var quest = Console.ReadLine();
                        tasker.addTask(quest);
                        tasker.Zapis();
                        Console.WriteLine("Успешно записано");
                        break;

                    case 2:
                        Console.WriteLine("Для какой задачи вы хотите поменять статус?");
                        foreach (var item in tasker.Tasks)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        int id = Convert.ToInt32(Console.ReadLine());
                        tasker.changeStatus(id, "Завершено");
                        Console.WriteLine(tasker.Tasks[id-1]);
                        tasker.Zapis();
                        break;

                    case 3:
                        Console.WriteLine("Какую задачу вы хотите удалить?");
                        foreach (var item in tasker.Tasks)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        int delid = Convert.ToInt32(Console.ReadLine());
                        tasker.delTask(delid);
                        break;

                    case 4:
                        foreach (var item in tasker.Tasks)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;

                    case 5:
                        exit = true;
                        break;
                }
                Console.WriteLine("Нажмите Enter чтобы продолжить");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
