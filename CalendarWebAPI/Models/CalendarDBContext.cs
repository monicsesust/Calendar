using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarWebAPI.Models
{
    public class CalendarDBContext:DbContext
    {
        //public string ConnectionString { get; set; }

        //public CalendarDBContext(string connectionString)
        //{
        //    this.ConnectionString = connectionString;
        //}

        //private MySqlConnection GetConnection()
        //{
        //    return new MySqlConnection(ConnectionString);
        //}
        public CalendarDBContext(DbContextOptions<CalendarDBContext> options) : base(options)
        {

        }

        public DbSet<DCalendar> DCalendars { get; set; }

    }
}
