using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ds3achievementtracker
{
    public partial class Form1 : Form
    {
        private string filepath = "data/progress.json";
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            //Load from the JSON file, create it if it doesn't exist
            if (!File.Exists(filepath))
            {
                if (!Directory.Exists("data"))
                {
                    Directory.CreateDirectory("data");
                }
                File.Create(filepath);
                
                //After the file has been created, add a blank set of data
                
            }
        }

        private void FillStarterData()
        {
            List<Ring> rings = new List<Ring>();
            List<Miracle> miracles = new List<Miracle>();
            List<Sorcery> sorceries = new List<Sorcery>();
            List<Gesture> gestures = new List<Gesture>();
            List<Pyromancy> pyromancies = new List<Pyromancy>();

            
        }

        private List<Ring> FillListRings()
        {
            var rings = new List<Ring>()
            {
                new Item.Ring()
                {name = "Life Ring", id = 0, }
            };
            return null;
        }
        private List<Sorcery> FillListSorceries()
        {
            return null;
        }
        private List<Miracle> FillListMiracles()
        {
            return null;
        }
        private List<Gesture> FillListGestures()
        {
            return null;
        }
        private List<Pyromancy> FillListPyromancies()
        {
            return null;
        }

        private void sorceryMasterImage_Click(object sender, EventArgs e)
        {

        }
    }
}
