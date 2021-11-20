using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dela.Manager
{
    [Serializable]
    public class Task
    {
        public int Id;
        public string Quests;
        public string Status;

        public override string ToString()
        {
            return $"Задача {Id}: {Quests} - {Status}";
        }

    }
}
