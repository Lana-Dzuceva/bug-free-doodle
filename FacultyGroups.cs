using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleEditorClassLibrary
{
    public class FacultyGroups
    {
        public List<Group> Groups { get; set; }

        public FacultyGroups(List<Group> groups)
        {
            Groups = groups;
        }
    }

    public class Group
    {
        public List<AcademicClass> Classes { get; set; } //  ScheduleAcademicClass

        public Group(List<AcademicClass> classes)
        {
            Classes = classes;
        }
    }

    public enum ClassType
    {
        Lecture,
        Practice
    }

    public enum SubGroup
    {
        first,
        second
    }

    public class AcademicClass
    {
        public string ClassTitle { get; set; }
        public Teacher Teacher { get; set; }
        public int Hours { get; set; }
        public ClassType Type { get; set; }
        public SubGroup SubGroup { get; set; }

        public AcademicClass(string classTitle, Teacher teacher, int hours, ClassType type, SubGroup subGroup)
        {
            this.ClassTitle = classTitle;
            this.Teacher = teacher;
            this.Hours = hours;
            this.Type = type;
            this.SubGroup = subGroup;
        }        
    }

    public enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class ScheduleAcademicClass : AcademicClass
    {
        public int Audience { get; set; }
        WeekDay WeekDay { get; set; }
        int ClassNumber { get; set; }

        public ScheduleAcademicClass(int audience, WeekDay weekDay, int classNumber, AcademicClass academicClass)
            : base(academicClass.ClassTitle, academicClass.Teacher, academicClass.Hours, academicClass.Type, academicClass.SubGroup)
        {
            Audience = audience;
            WeekDay = weekDay;
            ClassNumber = classNumber;
        }
    }

    public class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }
    }
}