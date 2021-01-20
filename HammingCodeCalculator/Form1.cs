using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HammingCodeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbEncRawInput_TextChanged(object sender, EventArgs e)
        {
            Hamming code = new Hamming();


            code.RawData = txbEncRawInput.Text;
            txbEncEncoded.Text = code.HammingCode;

            int p = 1;
            lbxEncParity.Items.Clear();
            foreach(KeyValuePair<int, int> parity in code.ParityBits)
                lbxEncParity.Items.Add($"p{p++} (c{parity.Key}) = {parity.Value}");

            dgvEncVisual.DataSource = code.GetVisual();

        }

        private void txbEncRawInput_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
