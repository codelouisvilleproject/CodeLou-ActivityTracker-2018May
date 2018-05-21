using System;

namespace ActivityTracker.Models
{
    public sealed class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ActivityMeasurementType MeasurementType {get; set;}
        // public Category category {get; set;}
    }
}