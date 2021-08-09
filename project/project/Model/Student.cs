using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project.Model
{
    class Student
    {
        private string rollName;
        private int Mark;
        private int Question;

        public Student()
        {

        }

        public Student(string rollName, int mark, int question)
        {
            this.rollName = rollName;
            Mark = mark;
            Question = question;
        }

        public string RollName { get => rollName; set => rollName = value; }
        public int Mark1 { get => Mark; set => Mark = value; }
        public int Question1 { get => Question; set => Question = value; }
    }
}
