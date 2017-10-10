using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagement.Models;
using ProjectManagement.DAL;

namespace ProjectManagement.ViewModels
{
    public class ProjectView
    {
        public Project project { get; set; }
        public IEnumerable<Card> Pending { get; set; }
        public IEnumerable<Card> Active { get; set; }
        public IEnumerable<Card> Completed { get; set; }
        public IEnumerable<Card> Confirmed { get; set; }

        public ProjectView(Project project)
        {
            var db = new PMContext();
            this.project = project;

            this.Pending = new List<Card>
            {
                new Card { Title = "" }
            };
        }
    }
}