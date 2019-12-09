using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class Exam
    {
        [Key]
        public int RollNumber { get; set; }
        public ExamSubject Subject { get; set; }
        public string StartTime { get; set; }
        public DateTime ExamDateTime { get; set; }
        public int Duration { get; set; }
        public ClassRoom Class { get; set; }
        public Faculty Faculty { get; set; }
        public Status Status { get; set; }
    }

    public enum Faculty
    {
        Jayalakshmi = 1,
        John_Cater = 2,
        HienPA = 3
    }

    public enum Status
    {
        done = 1,
        up_comming = 2,
        on_going = 3

    }

    public enum ClassRoom
    {
        B10 = 1,
        B16 = 2,
        B14 = 3,
    }

    public enum ExamSubject
    {
        CoreJava = 1,
        AdvanceJava = 2,
        ProgammingC = 3
    }
}