using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkDictionary
{
    class Car
    {
        private string _cvr;
        private string _name;
        private string _model;

        public string CVR
        {
            get { return _cvr; }
            set { _cvr = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public Car(string cvr, string name, string model)
        {
            CVR = cvr;
            Name = name;
            Model = model;
        }


    }
}
