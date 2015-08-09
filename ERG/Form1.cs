using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ERG
{
    public partial class Form1 : Form
    {
        patternbuilder pb;
        polygons poly;
        string sequencestring;
        Point polycenter;

        public Form1()
        {
            InitializeComponent();
            pb = new patternbuilder();
            poly = new polygons();
            polycenter = new Point(bigpolygondrawing.Width / 2, bigpolygondrawing.Height / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set a default beat/pattern
            resolution.Value = 16;
            pulses.Value = 4; //oonts oonts oonts oonts            
        }

        private void resolution_ValueChanged(object sender, EventArgs e)
        {
            pulses.Maximum = resolution.Value;
            offset.Maximum = (int)resolution.Value - 1;            
            sequencestring = pb.ERG((int)resolution.Value, (int)pulses.Value);
            settext(offsetter(sequencestring, offset.Value));
        }

        private void pulses_ValueChanged(object sender, EventArgs e)
        {
            sequencestring = pb.ERG((int)resolution.Value, (int)pulses.Value);
            settext(offsetter(sequencestring, offset.Value));            
        }

        private void offset_Scroll(object sender, EventArgs e)
        {
            settext(offsetter(sequencestring, offset.Value));            
        }

        private string offsetter(string sequence, int offsetby)
        {
            return sequence.Substring(sequence.Length - offsetby, offsetby) + sequence.Substring(0, sequence.Length - offsetby);
        }

        private void translate_CheckedChanged(object sender, EventArgs e)
        {
            settext(offsetter(sequencestring, offset.Value));
        }

        private void settext(string text)
        {           
            if (translate.Checked)
            {
                text = text.Replace("0", ".");
                text = text.Replace("1", "x");
            }
            label3.Text = "offset : " + offset.Value;
            ERGoutput.Text = text;
            setimages(offsetter(sequencestring, offset.Value));
        }

        private void setimages(string text)
        {
            char[] textarray = text.ToCharArray();
            for (int i = 0; i < textarray.Length; i++)
            {                
                Panel p = (Panel)this.Controls["panel" + i.ToString()]; 
                if (textarray[i] == '1')
                {
                    p.BackColor = Color.Red;
                }
                else
                {
                    p.BackColor = Color.Black;
                }
            }
            for (int i = textarray.Length; i < 32; i++)
            {
                Panel p = (Panel)this.Controls["Panel" + i.ToString()];
                p.BackColor = Color.Gray;
            }
            poly.drawpolygononpanel(bigpolygondrawing, text, (int)resolution.Value, polycenter, blackcircles.Checked ? true : false);
        }

        private void blackcircles_CheckedChanged(object sender, EventArgs e)
        {
            setimages(offsetter(sequencestring, offset.Value));
        }
    }
}
