﻿namespace ChalengeApp
{
    public class Employee
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }
        private List<int> score = new List<int>();
        

        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;

        }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
         this.score.Add(number);      
        }

        public void SubtractScore(int number)
        {
          this.score.Add(-number);
        }
    }
}
