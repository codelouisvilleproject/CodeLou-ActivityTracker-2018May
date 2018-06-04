using Microsoft.EntityFrameworkCore;
using System;

namespace ActivityTracker.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
        public enum Name
        {
            Cardio,
            Flexibility,
            CardioStrength
        }
}