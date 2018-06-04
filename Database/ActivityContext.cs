using ActivityTracker.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ActivityTracker.Database
{
    /// <summary>
    /// Database context to connect to the database.
    /// </summary>
    public class ActivityContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Activity> Activities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQLite for Dev, will use something else for production. SQLite is GREAT for local development if you can get away with it
            optionsBuilder.UseSqlite("Data Source=activity.db");

            // Really weird way to seed the DB since DB seeding as an EF builtin only exists in 2.1, and we're on 2.0.
            if (!Activities.Any())
            {
                Activities.Add(new Activity { Id = 1, Name = "Running", MeasurementType = ActivityMeasurementType.LengthOfTime });
                Activities.Add(new Activity { Id = 2, Name = "Stretching", MeasurementType = ActivityMeasurementType.LengthOfTime });
                Activities.Add(new Activity { Id = 3, Name = "Weightlifting", MeasurementType = ActivityMeasurementType.RepsWithWeight });
                Activities.Add(new Activity { Id = 4, Name = "Swimming", MeasurementType = ActivityMeasurementType.LengthOfTime });
                Activities.Add(new Activity { Id = 5, Name = "Jumping Jacks", MeasurementType = ActivityMeasurementType.Reps });
            }
        }
    }
}
