﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entities;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-Q640SRQG; Database=noteDb; Trusted_Connection=true");

        }

        public DbSet<Note> notes { get; set; }
        public DbSet<User> users { get; set; }

    }
}
