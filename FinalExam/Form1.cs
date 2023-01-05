using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class Form1 : Form
    {
        // Insect Objects
        clsInsect MyBee;
        clsInsect MyCricket;

        public Form1()
        {
            InitializeComponent();
        }

        //make insects
        private void btnMakeBee_Click(object sender, EventArgs e)
        {
            string typeOfBee, colorOfBee = "";

            //grab data
            typeOfBee = txtInsectType.Text;
            colorOfBee = txtInsectColor.Text;

            //Bee Object
            MyBee = new clsBee(typeOfBee);
            MyBee.InsectColor = colorOfBee;

            if(btnOutputBee.Enabled == false)
            {
                btnOutputBee.Enabled = true;
            }

            //clears info
            ClearInfo();
        }

        private void btnMakeCricket_Click(object sender, EventArgs e)
        {
            string typeOfCricket, colorOfCricket = "";

            //grab data
            typeOfCricket = txtInsectType.Text;
            colorOfCricket = txtInsectColor.Text;

            // Cricket object
            MyCricket = new clsCricket(typeOfCricket);
            MyCricket.InsectColor = colorOfCricket;

            if(btnCallCricket.Enabled == false)
            {
                btnCallCricket.Enabled = true;
            }

            //clears info
            ClearInfo();
        }

        //Output buttons
        private void btnOutputBee_Click(object sender, EventArgs e)
        {
            lblOutput.Text = CreateInsect(ref MyBee);
        }

        private void btnCallCricket_Click(object sender, EventArgs e)
        {
            lblOutput.Text = CreateInsect(ref MyCricket);
        }

        //Clear textbox
        private void ClearInfo()
        {
            txtInsectColor.Text = "";
            txtInsectType.Text = "";
        }

        //Create Insect: Polymorphic method
        private string CreateInsect(ref clsInsect oInsect)
        {
            string insectInfo = "";

            insectInfo = string.Format("The insect type is a {0}\r\nThe insect color is {1}\r\n"
                                        + "{2}\r\n{3}\r\n", oInsect.InsectType, oInsect.InsectColor,
                                        oInsect.MakeNoise(), oInsect.InsectMakes());
            
            return insectInfo;
        }
    }
}

