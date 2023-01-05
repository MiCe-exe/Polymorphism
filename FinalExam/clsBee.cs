using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class clsBee : clsInsect
    {
        public clsBee(string TypeOfBee) : base(TypeOfBee)
        {

        }

        // Bee's color property
        private string _InsectColor;
        public override string InsectColor
        {
            get { return _InsectColor; }
            set { _InsectColor = value; }
        }

        //Override Methods
        public override string MakeNoise()
        {
            return "Bees go buzz";
        }

        public override string InsectMakes()
        {
            return "Bees make honey";
        }

        //bee living method
        public string BeesLive()
        {
            return "Bees live in colonies";
        }

    }
}
