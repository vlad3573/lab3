using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_1
{
    internal class Cats
    {
        public Cats()
        {
        }

        public Cats(string name, int age, string gender, string type, string breed) : base(name, age, gender, type)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Type = type;
            Breed = breed;

        }

        public string Breed { get; set; }

        public void Information()
        {
            Debug.WriteLine($"Имя ({Name.GetType()}): {Name}");
            Debug.WriteLine($"Возраст ({Age.GetType()}): {Age}");
            Debug.WriteLine($"Пол ({Name.GetType()}): {Gender}");
            Debug.WriteLine($"Семейство ({Type.GetType()}): {Type}");
            Debug.WriteLine($"Порода ({Breed.GetType()}): {Breed}");
            Debug.WriteLine($"Класс: {GetType()}\n");

        }
    }
}
