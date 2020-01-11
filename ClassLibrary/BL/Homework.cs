﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.BL
{
    class Homework
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int LessonInScheduleId { get; set; }
        public LessonInSchedule LessonInSchedule { get; set; }
    }
}
