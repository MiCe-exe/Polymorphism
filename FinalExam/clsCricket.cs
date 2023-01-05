using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class clsCricket : clsInsect
    {
        public clsCricket(string TypeOfCricket) : base(TypeOfCricket)
        {

        }

        //Cricket's Color property
        private string _InsectColor;
        public override string InsectColor
        {
            get { return _InsectColor; }
            set { _InsectColor = value; }
        }

        //Override methods
        public override string MakeNoise()
        {
            return "Crickets go chirp";
        }

        public override string InsectMakes()
        {
            return "Crickets make noise";
        }

        //cricket Lives method
        public string CricketsLive()
        {
            return "Crickets are solitary";
        }
    }
}
