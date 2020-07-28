using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class student
    {
        string[] skills;
        string name, phone;
        int id;
        //indexer
        public 
        void someMethod(int id)
        {
            if (this.id==id)
            {
                Console.WriteLine("Same person");
            }
        }
        public string this [int index]
        {
            get { return skills[index]; }
            set { skills[index] = value; }
        }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Id { get => id; set => id = value; }
    }
}
