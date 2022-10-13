using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Animals
    {
        public Animals()
        {
        }

        public Animals(string name, int age, string gender, string type)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Type = type;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }

        public void Information()
        {
            Debug.WriteLine($"Имя ({Name.GetType()}): {Name}");
            Debug.WriteLine($"Возраст ({Age.GetType()}): {Age}");
            Debug.WriteLine($"Пол ({Gender.GetType()}): {Gender}");
            Debug.WriteLine($"Семейство ({Type.GetType()}): {Type}");
            Debug.WriteLine($"Класс: {GetType()}\n");
        }
    }
}
