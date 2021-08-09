using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project.Model
{
    class Paper
    {
        private string InputCase;
        private string OuputCase;
        private string OuputPaper;

        public Paper()
        {

        }

        public Paper(string inputCase, string ouputCase, string ouputPaper)
        {
            InputCase = inputCase;
            OuputCase = ouputCase;
            OuputPaper = ouputPaper;
        }

        public string InputCase1 { get => InputCase; set => InputCase = value; }
        public string OuputCase1 { get => OuputCase; set => OuputCase = value; }
        public string OuputPaper1 { get => OuputPaper; set => OuputPaper = value; }
    }
}
