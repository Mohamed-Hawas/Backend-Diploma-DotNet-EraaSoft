using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9_ORM_StudentSystem.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public ResourceType Type { get; set; }
        public int CourseId { get; set; }
        public Course course { get; set; }
        
    }
    public enum ResourceType
    {
        Video = 1,
        Presentation = 2,
        Document = 3,
        Other = 4
    }
}
