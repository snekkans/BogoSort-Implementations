using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BogoSort___Windows_Forms.BogoSorter;

namespace BogoSort___Windows_Forms
{
    public partial class BogoSortForm : Form
    {

        

        public BogoSortForm()
        {
            InitializeComponent();
        }

        string arrayString = "[";
        List<int> values = new List<int>();
        private void lbl_generateArray_Click(object sender, EventArgs e)
        {
            
            try {
                string tryConvert = txtBox_numGeneratedValues.Text;
                int numGeneratedValues = Convert.ToInt32(tryConvert);
                if (numGeneratedValues < 1) {
                    MessageBox.Show(numGeneratedValues + " is too low!");
                }
                else {
                    if (numGeneratedValues>5) {
                        MessageBox.Show("WARNING: Sorting an array larger than 5 integers" +
                            "\nwith BogoSort will take a VERY LONG TIME!" +
                            "\nI would recommend using a smaller array.");
                    }
                    List<int> arrayToBeSorted=generateArray(numGeneratedValues);
                    lbl_generatedArray.Text = arrayString;
                    
                    //Console.WriteLine(arrayString);
                }
                
            }
            catch (Exception){
                MessageBox.Show(this.txtBox_numGeneratedValues.Text + " is not a number!");
            }
        }

        private List<int> generateArray(int numGeneratedValues)
        {
            //reset arrayString and values array
            arrayString = "[";
            values.Clear();
            Random rnd = new Random();
            for (int i = 0; i < numGeneratedValues; i++) {
                int nxtRnd = rnd.Next(1, 99);
                values.Add(nxtRnd);
                arrayString += nxtRnd.ToString();
                if (i != numGeneratedValues - 1) { arrayString += ", "; }
            }
            arrayString += "]";
            btn_go.Enabled = true;
            return values;
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            lbl_numShuffles.ResetText();
            btn_generateArray.Enabled = false;
            int howLong = Sort(values);
            lbl_numShuffles.Text = howLong.ToString();
            btn_generateArray.Enabled = true;
            btn_go.Enabled = false;
            //Console.WriteLine("Bogosort took " + howLong + " tries to sort the initial array " + arrayString);
        }
    }
}
