using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_calc_Csharp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsReset_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtResult.Text = "";

            radKg.Checked = false;
            radLb.Checked = false;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Weight = Convert.ToDouble(txtWeight.Text);
            double Height = Convert.ToDouble(txtHeight.Text);
            double Result = 0.0;
            string Result2 = "";


            if (radKg.Checked)
            {
                Result = Weight / (Height * Height);
            }
            else
                if (radLb.Checked)
            {
                Weight = Weight / 2.205;
                Result = Weight / (Height * Height);
            }
            if (Result < 16)
            {
                Result2 = "შენ გაქვს წონის მწვავე დეფიციტი ";
            }
            else if (Result < 18.5)
            {
                Result2 = "შენ გაქვს წონის დეფიციტი";
            }

            else if (Result < 25)
            {
                Result2 = " შენ გაქვს ნორმალური წონა";
            }
            else if (Result < 30)
            {
                Result2 = "შენ გაქვს ზედმეტი წონა ";
            }
            else if (Result > 30)
            {
                Result2 = " სიმსუქნე ";
            }

            txtResult.Text = "შენი BMI=" + Result.ToString("#.#") + Result2;


        }

       
    }
}
