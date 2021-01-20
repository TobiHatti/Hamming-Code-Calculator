using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HammingCodeCalculator
{
    class Hamming
    {
        private string rawData = "0";
        private string hammingCode = "0";

        public string RawData 
        {
            get => rawData;
            set
            {
                ParityBits.Clear();
                rawData = ValidateInput(value);
                hammingCode = Encode();
            }
        }

        public string HammingCode
        {
            get => hammingCode;
            set
            {
                ParityBits.Clear();
                hammingCode = ValidateInput(value);
                rawData = Decode();
            }
        }

        public Dictionary<int, int> ParityBits { get; } = new Dictionary<int, int>();

        private string ValidateInput(string input)
        {
            input = Regex.Replace(input, @"\s+", "");

            foreach (char digit in input)
                if (digit != '1' && digit != '0')
                    throw new DataException("Invalid code.");

            return input;
        }


        public DataTable GetVisual()
        {
            DataTable dt = new DataTable();

            int d = 1;
            int p = 1;

            for(int i = 0; i < HammingCode.Length; i++)
                dt.Columns.Add($"");

            DataRow cRow = dt.NewRow();
            DataRow dpRow = dt.NewRow();
            DataRow valRow = dt.NewRow();
            for (int i = 0; i < HammingCode.Length; i++)
            {
                cRow[i] = $"c{i+1}";

                if (IsPowerOfTwo(i + 1)) dpRow[i] = $"p{p++}";
                else dpRow[i] = $"d{d++}";

                valRow[i] = HammingCode[i];
            }

            dt.Rows.Add(cRow);
            dt.Rows.Add(dpRow);
            dt.Rows.Add(valRow);

            return dt;
        }

        private int GetParityBit(int parityNumber)
        {
            int parityBitStep = (int)Math.Pow(2, parityNumber - 1);

            int c = 0;
            int d = 1;

            bool bitReadActive = false;
            int bitReadCounter = 0;
            int activeBits = 0;

            while(d <= rawData.Length)
            {
                if(!IsPowerOfTwo(c))
                {
                    if (bitReadActive && rawData[d - 1] == '1') activeBits++;

                    d++;
                }

                bitReadCounter++;
                if(bitReadCounter >= parityBitStep)
                {
                    bitReadCounter = 0;
                    bitReadActive = !bitReadActive;
                }

                c++;
            }

            ParityBits.Add(parityBitStep, activeBits % 2);

            return activeBits % 2;
        }

        private bool IsPowerOfTwo(int x)
        {
            return (x & (x - 1)) == 0;
        }


        private string Encode()
        {
            int c = 1;
            int p = 1;
            int d = 1;

            StringBuilder sb = new StringBuilder();

            while(d <= rawData.Length)
            {
                if(IsPowerOfTwo(c))
                {
                    sb.Append(GetParityBit(p));
                    p++;
                }
                else
                {
                    sb.Append(rawData[d-1]);
                    d++;
                }

                c++;
            }


            for(int i = 0; i < rawData.Length; i++)
            {
                Debug.Print(rawData[i].ToString());
            }

            return sb.ToString();
        }

        private string Decode()
        {
            return null;
        }


    }
}
