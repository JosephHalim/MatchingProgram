using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudyGuide
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> list = new Dictionary<string, string>();
        private int correct,incorrect = 0;
        List<string> Keys = new List<string>();
        List<string> Values = new List<string>();

       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        
        private void Form1_Closing(object sender, EventArgs e )
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
       
        private void button1_Click(object sender, System.EventArgs e)
        {
           
                var key = listBox1.SelectedItem.ToString();
                var data = listBox2.SelectedItem.ToString();
                var exist = list.Where(r => r.Key.Contains(key) && r.Value == data); //Finds if values are correct
          
            var temp = exist.ToList();


            if (temp.Count == 0) 
            {
                MessageBox.Show("incorrect");
                incorrect++;
            }
            else
            {
               
                var result = MessageBox.Show("Correct, Remove From List", "closing", MessageBoxButtons.YesNo); 
                correct++;
              if(result == DialogResult.Yes) //if user wants to remove data, remove data from both lists
              {
                  listBox1.Items.Remove(listBox1.SelectedItem);
               
                  listBox2.Items.Remove(listBox2.SelectedItem);
                  listBox1.Update();
                  
                  listBox2.Update();
                 
              }
                 
            }
            Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Update() //updates data & checks if lists are empty
        { 

            lblCorrect.Text = correct.ToString();
            lblIncorrect.Text = incorrect.ToString();
            lblNumberRemaining.Text = listBox1.Items.Count.ToString();
            if (listBox1.Items.Count == 0)
            {
                var result = MessageBox.Show("You have completed the exercise, would you like to reset?", "closing", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Reset();
                }
            }

        }
        private void Reset() // reset all the data
        {
            var result = MessageBox.Show("Are you sure you want to reset?", "closing", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                correct = 0;
                incorrect = 0;
                Alphabetical(Keys);
                ShuffleItems(Values);
                Update();
            }

        }
        private void AddData() // open user file and converts text file into usable text
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            var temp = file.FileName;
            using (StreamReader reader = File.OpenText(temp))
                while (!reader.EndOfStream)
                {
                    string vocabword = reader.ReadLine().Trim().ToLower().ToString();
                    string vocabdefinition = reader.ReadLine().Trim().ToString();
                    list.Add(vocabword, vocabdefinition);
                }
        }
        private void SeparateData()
        {

            foreach (var data in list)
            {
                Keys.Add(data.Key);
                Values.Add(data.Value);
            }
        }
        private void ShuffleItems(List<string> sender) //shuffles listbox items
        {
            Random rng = new Random();
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = sender[k];
                sender[k] = sender[n];
                sender[n] = value;
            }
            foreach (var item in sender)
            {
                listBox2.Items.Add(item);
            }
        }
        private void Alphabetical(List<string> sender) //alphabetizes data
        {
            var d = from value in sender
                    orderby value ascending
                    select value;
            foreach (var item in d)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnAddTxtFile_Click(object sender, EventArgs e)
        {
            
            AddData();
            SeparateData();
            Alphabetical(Keys);
            ShuffleItems(Values);
            Update();
        }

       
    }
   
}
