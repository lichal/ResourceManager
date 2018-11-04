using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResourceManager.Models
{
 
    public class Resource
    {
        private bool free = true;

        private int resourceNum;

        public void Initialize(int number)
        {
            resourceNum = number;
        }

        public int ResourceNumber()
        {
            return resourceNum;
        }

        public void Allocate()
        {
            free = false;
        }

        public void Deallocate()
        {
            free = true;
        }

        public bool Check()
        {
            return free;
        }
    }
}