using System;
using System.Collections.Generic;
using System.Text;

namespace Lab0
{
    class Person
    {
        private string name;
        private int age;
        private double height;
        private double weight;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public Person()
        {
            // this is an empty constructor
        }

        public Person(string name, int age, double height, double weight)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }
    }
}
