using System;
using System.Collections.Generic;
using System.Text;

namespace Bcs.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public string SessionName { get; set; }
        public bool ActiveSession { get; set; }
        public DateTime SessionStart { get; set; }
        public DateTime SessionEnd { get; set; }
    }
}
