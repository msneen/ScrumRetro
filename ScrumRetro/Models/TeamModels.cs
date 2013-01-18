using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace ScrumRetro.Models
{
    public class TeamModels
    {
    }

    public class TeamContext : DbContext
    {
        public TeamContext() : base("DefaultConnection")
        {
        }

        //public DbSet<UserProfile> UserProfiles { get; set; }
    }
}