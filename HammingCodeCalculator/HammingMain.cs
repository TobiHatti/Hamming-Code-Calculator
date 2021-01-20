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
    public partial class HammingMain : Form
    {
        public HammingMain()
        {
            InitializeComponent();
        }

        private void txbEncRawInput_TextChanged(object sender, EventArgs e)
        {
            lbxEncParity.Items.Clear();
            dgvEncVisual.DataSource = null;
            txbEncEncoded.Text = "";

            try
            {
                Hamming code = new Hamming();

                code.RawData = txbEncRawInput.Text;
                txbEncEncoded.Text = code.HammingCode;

                int p = 1;
                foreach (KeyValuePair<int, int> parity in code.ParityBits)
                    lbxEncParity.Items.Add($"p{p++} (c{parity.Key}) = {parity.Value}");

                dgvEncVisual.DataSource = code.GetVisual();
            }
            catch
            {
                MessageBox.Show("Please enter only '1' and '0' in the input field.", "Could not parse Hamming-Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txbEncRawInput_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dgvEncVisual_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var cell = dgvEncVisual.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if(cell.Value.ToString().StartsWith("p"))
            {
                e.CellStyle.ForeColor = Color.Blue;
            }
            else if(cell.Value.ToString().StartsWith("d"))
            {
                e.CellStyle.ForeColor = Color.Green;
            }
            else if (cell.Value.ToString().StartsWith("c"))
            {
                e.CellStyle.ForeColor = Color.Gray;
            }
        }
    }
}
