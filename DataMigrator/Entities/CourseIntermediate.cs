﻿namespace DataMigrator.Entities
{
    public class CourseIntermediate
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string ExternalId { set; get; }
        public int? TargetId { set; get; }
        public bool ToBeDeleted { set; get; }
    }
}