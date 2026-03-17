using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAnnotations.Models
{
    internal class Learner
    {
        public int LearnerID { get; set; }
        public string Name { get; set; }
            public string Course { get; set; }
            public int Marks { get; set; }
    }
}
