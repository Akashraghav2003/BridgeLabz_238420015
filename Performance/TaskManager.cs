﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance
{
    public class TaskManager
    {
        public string RunningTask(int sleepTime)
        {
            Thread.Sleep(sleepTime);
            return "Task is complete";
        }
    }
}
