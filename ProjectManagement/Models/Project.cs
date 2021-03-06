﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjectManagement.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ProjectStatus? Phase { get; set; }
    }

    public enum ProjectStatus
    {
        Pending = 1,
        Active = 2,
        Complete = 3
    }
}