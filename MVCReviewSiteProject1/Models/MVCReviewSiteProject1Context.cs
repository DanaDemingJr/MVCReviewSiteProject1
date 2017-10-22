﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject1.Models
{
    public class MVCReviewSiteProject1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVCReviewSiteProject1Context() : base("name=MVCReviewSiteProject1Context")
        {
        }

        public System.Data.Entity.DbSet<MVCReviewSiteProject.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<MVCReviewSiteProject.Models.Reviews> Reviews { get; set; }
    }
}