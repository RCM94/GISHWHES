using System;
using System.Collections;
using System.Resources;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using GISHWHES_Mascot.Properties;

namespace GISHWHES_Mascot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            IDictionaryEnumerator resource = Resources.ResourceManager.GetResourceSet(new System.Globalization.CultureInfo("en"), false, true).GetEnumerator();

            while (resource.MoveNext())
            {
                if (resource.Value is Bitmap)
                {
                    String key = (string)resource.Key;

                    if(key.Contains("_Legs"))
                    {
                        Legs.Add((Bitmap)resource.Value);
                    }
                    else if (key.Contains("_Body"))
                    {
                        Bodies.Add((Bitmap)resource.Value);
                    }
                    else if (key.Contains("_Head"))
                    {
                        Heads.Add((Bitmap)resource.Value);
                    }

                }
            }
            Randomize();
        }


        private void Randomize()
        {
            Random random = new Random();
            LegBox.Image = Legs[random.Next(0, Legs.Count)];
            BodyBox.Image = Bodies[random.Next(0, Bodies.Count)];
            HeadBox.Image = Heads[random.Next(0, Heads.Count)];
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private List<Bitmap> Legs = new List<Bitmap>();
        private List<Bitmap> Bodies = new List<Bitmap>();
        private List<Bitmap> Heads = new List<Bitmap>();
        

        private void RandomButton_click(object sender, EventArgs e)
        {
            Randomize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
