using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace L2MWeapCalc
{
    
    public partial class Form1 : Form
    {
        double a = 31.47;
        public Form1()
        {
            InitializeComponent();
        }
        //private int i = 4;

        //public int I { get => 4; set => i = value; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double m = Convert.ToDouble(textBox1.Text);
                double m2 = Convert.ToDouble(label2.Text);
                double w = m + m2 * a;
                if (radioButton1.Checked) w *= 1.04;
                label5.Text = Convert.ToString(w);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Błędny Format!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) label2.Text = "301";
            else label2.Text = "293";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) label7.Text = "332";
            else label7.Text = "322";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double m = Convert.ToDouble(textBox2.Text);
                double m2 = Convert.ToDouble(label7.Text);
                double w = m + m2 * a;
                label12.Text = Convert.ToString(w);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Błędny Format!");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                double m = Convert.ToDouble(textBox3.Text);
                double m2 = Convert.ToDouble(label18.Text);
                double w = m + m2 * a;
                if (radioButton1.Checked) w *= 1.05;
                label15.Text = Convert.ToString(w);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Błędny Format!");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) label18.Text = "349";
            else label18.Text = "339";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) label24.Text = "384";
            else label24.Text = "373";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double m = Convert.ToDouble(textBox4.Text);
                double m2 = Convert.ToDouble(label24.Text);
                double w = m + m2 * a;
                label22.Text = Convert.ToString(w);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Błędny Format!");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) label30.Text = "382";
            else label30.Text = "371";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double m = Convert.ToDouble(textBox5.Text);
                double m2 = Convert.ToDouble(label30.Text);
                double w = m + m2 * a;
                if (radioButton1.Checked) w *= 1.05;
                label28.Text = Convert.ToString(w);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Błędny Format!");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) label36.Text = "420";
            else label36.Text = "408";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double m = Convert.ToDouble(textBox6.Text);
                double m2 = Convert.ToDouble(label36.Text);
                double w = m + m2 * a;
                label34.Text = Convert.ToString(w);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Błędny Format!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Proszę odświeżyć obliczenia");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) MessageBox.Show("Proszę odświeżyć obliczenia");
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double m = Convert.ToDouble(textBox7.Text);
                double m2 = Convert.ToDouble(trackBar1.Value);
                double w = m + m2 * a;
                if (radioButton1.Checked) w *= 1.05;
                label40.Text = Convert.ToString(w);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Błędny Format!");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string nazwa = @"c:\tmp\L2_Results.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Create, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);

            zapis.WriteLine("   Zapis na datę: {0}", monthCalendar1.SelectionRange.Start.ToShortDateString()); zapis.WriteLine();

            if (checkBox1.Checked) zapis.Write("1. Blessed ");
            zapis.Write("{0} z bazową mocą postaci: {1} daje moc o wartości: {2}", label1.Text, textBox1.Text, label5.Text);
            if (radioButton1.Checked) zapis.Write(" (Sigil-jest)"); else zapis.Write(" (Sigil-brak)");
            zapis.WriteLine(); zapis.WriteLine();

            if (checkBox2.Checked) zapis.Write("2. Blessed ");
            zapis.Write("{0} z bazową mocą postaci: {1} daje moc o wartości: {2} (Brak możliwości korzystania z sigila)", label8.Text, textBox2.Text, label12.Text);
            zapis.WriteLine(); zapis.WriteLine();

            if (checkBox3.Checked) zapis.Write("3. Blessed ");
            zapis.Write("{0} z bazową mocą postaci: {1} daje moc o wartości: {2}", label16.Text, textBox3.Text, label15.Text);
            if (radioButton1.Checked) zapis.Write("( Sigil-jest)"); else zapis.Write(" (Sigil-brak)");
            zapis.WriteLine(); zapis.WriteLine();

            if (checkBox4.Checked) zapis.Write("4. Blessed ");
            zapis.Write("{0} z bazową mocą postaci: {1} daje moc o wartości: {2} (Brak możliwości korzystania z sigila)", label19.Text, textBox4.Text, label22.Text);
            zapis.WriteLine(); zapis.WriteLine();

            if (checkBox5.Checked) zapis.Write("5. Blessed ");
            zapis.Write("{0} z bazową mocą postaci: {1} daje moc o wartości: {2}", label25.Text, textBox5.Text, label28.Text);
            if (radioButton1.Checked) zapis.Write(" (Sigil-jest)"); else zapis.Write(" (Sigil-brak)");
            zapis.WriteLine(); zapis.WriteLine();

            if (checkBox6.Checked) zapis.Write("6. Blessed ");
            zapis.Write("{0} z bazową mocą postaci: {1} daje moc o wartości: {2} (Brak możliwości korzystania z sigila)", label31.Text, textBox6.Text, label34.Text);

            zapis.Close();
            plik.Close();
            MessageBox.Show("Plik został zapisany w ścieżce @c:/tmp/L2_results.txt", "Sukces!");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wszelkie prawa do obrazów oraz zamieszczonej strony posiada NCSoft oraz Innova. Program tylko do użytku prywatnego. Rozpowszechnianie zabronione. \nAutor Programu: Stanisław Młyński","Prawa Autorskie");
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string b = "1";
                double c;
                c = Convert.ToDouble(Interaction.InputBox("Podaj swój M.Atk: ", "Oczekiwanie na dane", b, 100, 100));

                //double m = Convert.ToDouble(textBox1.Text);
                double m2 = Convert.ToDouble(label2.Text);
                double w = m2 + c * a;
                if (radioButton1.Checked) w *= 1.05;
                label5.Text = Convert.ToString(w);
                textBox1.Text = Convert.ToString(c);

                //double m1 = Convert.ToDouble(textBox2.Text);
                double m12 = Convert.ToDouble(label7.Text);
                double w1 = c + m12 * a;
                label12.Text = Convert.ToString(w1);
                textBox2.Text = Convert.ToString(c);

                //double m11 = Convert.ToDouble(textBox3.Text);
                double m112 = Convert.ToDouble(label18.Text);
                double w11 = c + m112 * a;
                if (radioButton1.Checked) w11 *= 1.05;
                label15.Text = Convert.ToString(w11);
                textBox3.Text = Convert.ToString(c);

                //double m111 = Convert.ToDouble(textBox4.Text);
                double m1112 = Convert.ToDouble(label24.Text);
                double w111 = c + m1112 * a;
                label22.Text = Convert.ToString(w111);
                textBox4.Text = Convert.ToString(c);

                //double m0 = Convert.ToDouble(textBox5.Text);
                double m02 = Convert.ToDouble(label30.Text);
                double w0 = c + m02 * a;
                if (radioButton1.Checked) w0 *= 1.05;
                label28.Text = Convert.ToString(w0);
                textBox5.Text = Convert.ToString(c);

                //double m9 = Convert.ToDouble(textBox6.Text);
                double m92 = Convert.ToDouble(label36.Text);
                double w9 = c + m92 * a;
                label34.Text = Convert.ToString(w9);
                textBox6.Text = Convert.ToString(c);

                //double m8 = Convert.ToDouble(textBox7.Text);
                double m82 = Convert.ToDouble(trackBar1.Value);
                double w8 = c + m82 * a;
                if (radioButton1.Checked) w8 *= 1.05;
                label40.Text = Convert.ToString(w8);
                textBox7.Text = Convert.ToString(c);
                MessageBox.Show("Gotowe!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Jedna z wprowadzanych wartości posiada błędny format!","Error!");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label38.Text = Convert.ToString(trackBar1.Value);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://l2wiki.com/Main_Page");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*System.Windows.Forms.TextBox t = new System.Windows.Forms.TextBox();
            t.Size = new System.Drawing.Size(180, 23);
            t.Location = new System.Drawing.Point(90, 70);
            t.KeyDown += new System.Windows.Forms.KeyEventHandler(t_);
            //t.KeyDown += new System.Windows.Forms.KeyEventHandler(t_KeyDown);
            t.Name = "Podaj nowy współczynnik";            
            */
            string b = "1";
            int d;
            try
            {
                int w = Convert.ToInt32(maskedTextBox1.Text);
                if (w == 1690) { a = Convert.ToDouble(Interaction.InputBox("Podaj nową wartość a=", "Dostęp odblokowany", b, 100, 100)); }
                else
                {
                    MessageBox.Show("Nastąpi zamknięcie programu", "Nieautoryzowany dostęp");
                    Application.Exit();
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Nieprawidłowy format wejścia", "Błąd");
            }

            /*string b = "1";
            int i = 4;
            
            for (; i >= 0; i--)
            {
                
                try
                {
                    int w = Convert.ToInt32(maskedTextBox1.Text);
                    if (w == 1690)
                    {
                        a = Convert.ToDouble(Interaction.InputBox("Podaj nową wartość a=", "Dostęp odblokowany", b, 100, 100));
                        continue;
                    }
                    else if (i > 1) { MessageBox.Show("Pozostały " + i + " próby", "Błędny Kod!"); break; }
                    else if (i == 1) { MessageBox.Show("Ostatnia Próba! Może nastąpić zamknięcie aplikacji", "Błędny Kod!"); break; }
                    /*async Task PutTaskDelay()
                    {
                        await Task.Delay(3000);
                    }
                    if (i == 0) Application.Exit();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Nieprawidłowy format wejścia", "Błąd");
                    break;
                }
            }*/
        }
    }
}