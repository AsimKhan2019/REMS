﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management
{
    class EstateProject
    {
        //every estate project should have an unique ID
        public string ID { get; }
        private string description;
        private int noWorkers;
        List<Apartment> apartments;
        List<User> users;
        public EstateProject()
        {
            Guid guid = Guid.NewGuid();
            this.ID = guid.ToString();
        }
    }
}
