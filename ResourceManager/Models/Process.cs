﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResourceManager.Models
{
    public class Process
    {
        private int id;
        public int GetID()
        {
            return id;
        }

        public void DefineID(int id)
        {
            this.id = id;
        }
    }
}