using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    /// <summary>
    ///     A class with common properties shared between subclasses
    /// </summary>
    public class Animal 
    {
        private string _id;
        private int _noOfLegs;

        public Animal(string id, int noOfLegs)
        {
            _id = id;
            _noOfLegs = noOfLegs;
        }

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }


        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }

        public virtual void Run()
        {
            throw new NotImplementedException();
        }

        public virtual void Talk()
        {
            throw new NotImplementedException();
        }
    }
}
