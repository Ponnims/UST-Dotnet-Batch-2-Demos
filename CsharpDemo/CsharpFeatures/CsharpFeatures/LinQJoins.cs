using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
    }

    class Developer
    {
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public int ProjectId { get; set; }
    }

    internal class LinQJoins
    {
        static void Main(string[] args)
        {
            List<Project> projects = new List<Project>()
            {
                new Project(){ ProjectId=11, ProjectName="ASIS"},
                new Project(){ ProjectId=22, ProjectName="MDU"},
                new Project(){ ProjectId=33, ProjectName="CUBUS"},
                new Project(){ ProjectId=44, ProjectName="MTP"},
                new Project(){ ProjectId=55, ProjectName="ELEARN"},
            };

            List<Developer> developers = new List<Developer>()
            {
                new Developer(){ DeveloperId=1, DeveloperName="John", ProjectId=11},
                new Developer(){ DeveloperId=2, DeveloperName="Smith", ProjectId=22},
                new Developer(){ DeveloperId=3, DeveloperName="David", ProjectId=33},
                new Developer(){ DeveloperId=4, DeveloperName="Miller", ProjectId=44},
                new Developer(){ DeveloperId=5, DeveloperName="James", ProjectId=55},
                new Developer(){ DeveloperId=6, DeveloperName="Alice", ProjectId=11},
                new Developer(){ DeveloperId=7, DeveloperName="Bob", ProjectId=22},
                new Developer(){ DeveloperId=8, DeveloperName="Charlie", ProjectId=33},
                new Developer(){ DeveloperId=9, DeveloperName="Eve", ProjectId=44},
                new Developer(){ DeveloperId=10, DeveloperName="Frank", ProjectId=55},

            };

            var queryjoin = from dev in developers
                            join proj in projects
                            on dev.ProjectId equals proj.ProjectId
                            select new
                            {
                                devname = dev.DeveloperName,
                                projname = proj.ProjectName
                            };

            foreach (var item in queryjoin)
            {
                Console.WriteLine($"{item.devname} works for the Project {item.projname}");
            }
            // alternative way to print the results using ToList and ForEach
            queryjoin.ToList().ForEach(x => Console.WriteLine($"{x.devname} works for the Project {x.projname}"));


            var queryjoinwithmethodsyntax= developers.Join(projects, d=>d.ProjectId, p=>p.ProjectId,
                (d,p)=> new { devname = d.DeveloperName, projname = p.ProjectName });
        }
    }
}
