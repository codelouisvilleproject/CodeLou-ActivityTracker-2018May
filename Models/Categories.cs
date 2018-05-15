using Microsoft.EntityFrameworkCore;
using System;

namespace ActivityTracker.Models
{
    public class CategoriesContext: DbContext
    {
        public int Id { get; set; }
        enum Name
        {
            Cardio,
            Flexibility,
            CardioStrength
        }
    }
}