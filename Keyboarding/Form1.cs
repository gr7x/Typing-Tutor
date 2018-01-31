using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboarding
{
    public partial class Form1 : Form
    {
        Dictionary<char, int> errorTracker = new Dictionary<char, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {


            switch (e.KeyCode)
            {
                case Keys.A:
                    button21.ForeColor = Color.Black;
                    button21.BackColor = Color.Red;
                    break;
                case Keys.B:
                    b.ForeColor = Color.Black;
                    b.BackColor = Color.Red;
                    break;
                case Keys.C:
                    c.ForeColor = Color.Black;
                    c.BackColor = Color.Red;
                    break;
                case Keys.D:
                    d.ForeColor = Color.Black;
                    d.BackColor = Color.Red;
                    break;
                case Keys.E:
                    ee.ForeColor = Color.Black;
                    ee.BackColor = Color.Red;
                    break;
                case Keys.F:
                    f.ForeColor = Color.Black;
                    f.BackColor = Color.Red;
                    break;
                case Keys.G:
                    g.ForeColor = Color.Black;
                    g.BackColor = Color.Red;
                    break;
                case Keys.H:
                    h.ForeColor = Color.Black;
                    h.BackColor = Color.Red;
                    break;
                case Keys.I:
                    i.ForeColor = Color.Black;
                    i.BackColor = Color.Red;
                    break;
                case Keys.J:
                    j.ForeColor = Color.Black;
                    j.BackColor = Color.Red;
                    break;
                case Keys.K:
                    k.ForeColor = Color.Black;
                    k.BackColor = Color.Red;
                    break;
                case Keys.L:
                    l.ForeColor = Color.Black;
                    l.BackColor = Color.Red;
                    break;
                case Keys.M:
                    m.ForeColor = Color.Black;
                    m.BackColor = Color.Red;
                    break;
                case Keys.N:
                    n.ForeColor = Color.Black;
                    n.BackColor = Color.Red;
                    break;
                case Keys.O:
                    o.ForeColor = Color.Black;
                    o.BackColor = Color.Red;
                    break;
                case Keys.P:
                    p.ForeColor = Color.Black;
                    p.BackColor = Color.Red;
                    break;
                case Keys.Q:
                    q.ForeColor = Color.Black;
                    q.BackColor = Color.Red;
                    break;
                case Keys.R:
                    r.ForeColor = Color.Black;
                    r.BackColor = Color.Red;
                    break;
                case Keys.S:
                    s.ForeColor = Color.Black;
                    s.BackColor = Color.Red;
                    break;
                case Keys.T:
                    t.ForeColor = Color.Black;
                    t.BackColor = Color.Red;
                    break;
                case Keys.U:
                    u.ForeColor = Color.Black;
                    u.BackColor = Color.Red;
                    break;
                case Keys.V:
                    v.ForeColor = Color.Black;
                    v.BackColor = Color.Red;
                    break;
                case Keys.W:
                    w.ForeColor = Color.Black;
                    w.BackColor = Color.Red;
                    break;
                case Keys.X:
                    x.ForeColor = Color.Black;
                    x.BackColor = Color.Red;
                    break;
                case Keys.Y:
                    y.ForeColor = Color.Black;
                    y.BackColor = Color.Red;
                    break;
                case Keys.Z:
                    z.ForeColor = Color.Black;
                    z.BackColor = Color.Red;
                    break;
                case Keys.Enter:
                    enter.ForeColor = Color.Black;
                    enter.BackColor = Color.Red;
                    button1_Click(sender, e);
                    break;
                case Keys.Space:
                    space.ForeColor = Color.Black;
                    space.BackColor = Color.Red;
                    break;
                case Keys.Escape:
                    esc.ForeColor = Color.Black;
                    esc.BackColor = Color.Red;
                    Application.Exit();
                    break;
                case Keys.Back:
                    back.ForeColor = Color.Black;
                    back.BackColor = Color.Red;
                    break;
                case Keys.ShiftKey:
                    sh.ForeColor = Color.Black;
                    sh.BackColor = Color.Red;
                    break;


            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    button21.BackColor = Color.White;
                    button21.ForeColor = Color.Black;
                    break;
                case Keys.B:
                    b.BackColor = Color.White;
                    b.ForeColor = Color.Black;
                    break;
                case Keys.C:
                    c.BackColor = Color.White;
                    c.ForeColor = Color.Black;
                    break;
                case Keys.D:
                    d.BackColor = Color.White;
                    d.ForeColor = Color.Black;
                    break;
                case Keys.E:
                    ee.BackColor = Color.White;
                    ee.ForeColor = Color.Black;
                    break;
                case Keys.F:
                    f.BackColor = Color.White;
                    f.ForeColor = Color.Black;
                    break;
                case Keys.G:
                    g.BackColor = Color.White;
                    g.ForeColor = Color.Black;
                    break;
                case Keys.H:
                    h.BackColor = Color.White;
                    h.ForeColor = Color.Black;
                    break;
                case Keys.I:
                    i.BackColor = Color.White;
                    i.ForeColor = Color.Black;
                    break;
                case Keys.J:
                    j.BackColor = Color.White;
                    j.ForeColor = Color.Black;
                    break;
                case Keys.K:
                    k.BackColor = Color.White;
                    k.ForeColor = Color.Black;
                    break;
                case Keys.L:
                    l.BackColor = Color.White;
                    l.ForeColor = Color.Black;
                    break;
                case Keys.M:
                    m.BackColor = Color.White;
                    m.ForeColor = Color.Black;
                    break;
                case Keys.N:
                    n.BackColor = Color.White;
                    n.ForeColor = Color.Black;
                    break;
                case Keys.O:
                    o.BackColor = Color.White;
                    o.ForeColor = Color.Black;
                    break;
                case Keys.P:
                    p.BackColor = Color.White;
                    p.ForeColor = Color.Black;
                    break;
                case Keys.Q:
                    q.BackColor = Color.White;
                    q.ForeColor = Color.Black;
                    break;
                case Keys.R:
                    r.BackColor = Color.White;
                    r.ForeColor = Color.Black;
                    break;
                case Keys.S:
                    s.BackColor = Color.White;
                    s.ForeColor = Color.Black;
                    break;
                case Keys.T:
                    t.BackColor = Color.White;
                    t.ForeColor = Color.Black;
                    break;
                case Keys.U:
                    u.BackColor = Color.White;
                    u.ForeColor = Color.Black;
                    break;
                case Keys.V:
                    v.BackColor = Color.White;
                    v.ForeColor = Color.Black;
                    break;
                case Keys.W:
                    w.BackColor = Color.White;
                    w.ForeColor = Color.Black;
                    break;
                case Keys.X:
                    x.BackColor = Color.White;
                    x.ForeColor = Color.Black;
                    break;
                case Keys.Y:
                    y.BackColor = Color.White;
                    y.ForeColor = Color.Black;
                    break;
                case Keys.Z:
                    z.BackColor = Color.White;
                    z.ForeColor = Color.Black;
                    break;
                case Keys.Enter:
                    enter.BackColor = Color.White;
                    enter.ForeColor = Color.Black;
                    break;
                case Keys.Space:
                    space.BackColor = Color.White;
                    space.ForeColor = Color.Black;
                    
                    break;
                case Keys.Escape:
                    esc.BackColor = Color.White;
                    esc.ForeColor = Color.Black;
                    break;
                case Keys.Back:
                    back.BackColor = Color.White;
                    back.ForeColor = Color.Black;
                    break;
                case Keys.ShiftKey:
                    sh.BackColor = Color.White;
                    sh.ForeColor = Color.Black;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Score Points = new Score();
            Phrases Phrase = new Phrases();
            //Count count = new Count();
            String[] samples = {
            "Enter the text found here in the textbox bellow. Press next to start", 
            "A typed word is counted as any five keystrokes.",
            "Do not stop to correct your errors in these first tests but check them out.",
            "The beautiful scenic country of New Zealand is situated in the South Pacific to the east of Australia.",
            "The ferry crosses Cook Strait and cruises beautiful Queen Charlotte Sounds between Wellington, NZ's Capital City, and Picton.",
            "NZ's East Coast has many stretches of white sand and rolling surf which attract NZ and overseassurfers. They are popular NZ family holiday places.",
            "New Zealand is a land of contrasts, which attract thousands of overseas tourists every year to climb, ski or snowboard our mountains, swim, fish or cruise on our lakes and rivers.",
            "Between The Southern Alps and the West Coast is a fantastic scenic drive taking the Haast Passroad. Here is our great rain forest. Most overseas and local tours include this route in their Itinerary.",
            "New Zealand is a very sport oriented country and sometimes hosts world events. Sports include tennis, golf, yachting, canoeing, cruising, cricket, soccer, rugby, basketball, netball, swimming, surf lifesaving, athletics, and riding. ",
            "Watching events where they take place is fine but many can only watch at home as the event is screened on our TVs. New Zealand is proud too of our sporting participants who have enteredand gained medals in many sporting events including Olympic Games10. Masters' Games are very popular in New Zealand as in many other countries and NZ swimmers were really proud in the year 2002 to host the FINA World Masters Swimming Champs at Christ church in the South Island, at which I gained 10th place medals for 100 m and 200 m backstroke. ",
            "Some challenging events which draw overseas sports people include the annual Coast to Coast involving running, cycling and kayaking from the West Coast, through mountain passes to the East Coast, and the Iron Man including running, cycling, and swimming. I am proud one of my sons twice took part in the Ironman." };
            Count.plusCount();
            
            //count++;
            label1.Text = samples[Count.count];
            String input = textBox1.Text;

            int correct = 0;
            int incorrect = 0;
          
                for (int i = 0; i < samples[Count.last].Length && i < input.Length; i++)
                {
                    if (samples[Count.last][i] == input[i])
                    {
                        correct += 1;
                    }
                    else
                    {
                        incorrect += 1;
                        char x = samples[Count.last][i];
                        if (errorTracker.ContainsKey(x))
                        {
                            errorTracker[x] += 1;

                        }
                        else
                        {//x
                            errorTracker.Add(x, 1);

                        }

                    }
                }
            
            incorrect += Math.Abs(samples[Count.last].Length - input.Length);
            
                /*if (Phrase[1] == textBox1.Text)
                {
                    Points.addToScore(1);

                }
            double score = Points.score;*/
                label3.Text = correct.ToString("00");//score.ToString("0.0");
                label4.Text = incorrect.ToString("00");//score.ToString("0.0");
                textBox1.Text = String.Empty;
                if (Count.count == 10)
                {
                    List<KeyValuePair<char, int>> error = errorTracker.ToList();
                    error.Sort((firstPair, nextPair) =>
                        {
                            return firstPair.Key.CompareTo(nextPair.Key);
                        }
                    );
                    
                    StringBuilder s = new StringBuilder();

                    foreach (var item in error)
                    {
                        s.AppendFormat("        {0}                  {1}  \n", item.Key, item.Value);

                    }
                    
                MessageBox.Show("       Your Error Report \n \n         Key       Missed \n\n" + s.ToString());
                    
              }
           //TODO design an array to hold these values and call the function to get them
                //Phrase.setArray();

                // Find out why the value wont pass
            //count.addCount();
                
               
                //label1.Text = Phrase[count.count];//Phrase[count.count];
                
           

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the text listed above in the text field");
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the text listed above in the textfield below");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<char, int>> error = errorTracker.ToList();
            error.Sort((firstPair, nextPair) =>
            {
                return firstPair.Key.CompareTo(nextPair.Key);
            }
            );

            StringBuilder s = new StringBuilder();

            foreach (var item in error)
            {
                s.AppendFormat("        {0}                  {1}  \n", item.Key, item.Value);

            }

            MessageBox.Show("        Your Key Misses \n \n         Key       Missed \n\n" + s.ToString());
                   
        }
    }
}
