using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    public class Student : Observer
    {
        private Academy subject;

        public string Message { get; set; }

        public string Name { get; }

        public Student(Academy subject, string name)
        {
            this.subject = subject;
            Name = name;
        }

        public override void Update()
        {
            Message = subject.Message;
            Console.WriteLine("Studerende {0} modtog nyheden {1} fra Akademiet {2}", Name, Message, subject.Name);
        }
    }
}
