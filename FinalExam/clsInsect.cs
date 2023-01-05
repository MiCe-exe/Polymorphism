using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public abstract class clsInsect
    {
        public clsInsect(string TypeOfInsect)
        {
            _InsectType = TypeOfInsect;
        }

        //Insect type
        private string _InsectType;
        public string InsectType
        {
            get { return _InsectType; }
        }


        // prop color of insect
        public abstract string InsectColor
        {
            get;
            set;
        }

        //abstract methods
        public abstract string MakeNoise();

        public abstract string InsectMakes();
    }
}
