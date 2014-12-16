using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database
{
    public class Tickets
    {
        private string ticketName;
        private string technician;
        private double timer;
        private string description;
        private int priority;
        private bool status;

        public Tickets(string ticketName, string technician, double timer, string description, int priority, bool status)
        {
            this.ticketName = ticketName;
            this.technician = technician;
            this.timer = timer;
            this.description = description;
            this.priority = priority;
            this.status = status;
        }
        public string TicketName
        {
            get { return ticketName; }
            set { ticketName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public string Technician
        {
            get { return technician; }
            set { technician = value; }
        }

        public double Timer
        {
            get { return timer; }
            set { timer = value; }
        }
    }
}