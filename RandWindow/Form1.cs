using System;
using System.Drawing;
using System.Windows.Forms;

namespace RandWindow
{
 
  public partial class Form1 : Form
  {
    Point tmp_location;
    int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
    int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
    Random rnd = new Random();
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
          MessageBox.Show("Вы усердны!!");
          Application.Exit();
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
      textBox1.Text = e.X.ToString();
      textBox2.Text = e.Y.ToString();
      
      if (e.X > 80 && e.X < 195 && e.Y > 100 && e.Y < 135)
      {
        tmp_location = this.Location;
       
        tmp_location.X += rnd.Next(-100, 100);
        tmp_location.Y += rnd.Next(-100, 100);
        if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) ||
        tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
        {
          tmp_location.X = _w / 2;
          tmp_location.Y = _h / 2;
        }
        this.Location = tmp_location;
      }
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Мы не сомневались в вешем безразличии", "Внимание",
      MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
  }
}
