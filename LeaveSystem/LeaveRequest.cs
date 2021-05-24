using System;
using System.Collections.Generic;

namespace LeaveSystem
{
    class LeaveRequest
    {
        public string name { get; set; }
        public string EmployeeIdNumber { get; set; }
        public string Birthday { get; set; }
        public string LeaveDay { get; set; }
        public string Reason { get; set; }

        public static List<string> LeaveType = new List<string>()
        { "Birthday Leave", "Sick Leave", "Maternity Leave", "Faternity Leave", "Vacation Leave" };
    }
}
