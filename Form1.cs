using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sorting_Algorithms
{
    public partial class Form1 : Form
    {
        //Objects for the sorting classes
        InsertionSort insert = new InsertionSort();
        MergeSort m = new MergeSort();
        HeapSort h = new HeapSort();
        QuickSort q = new QuickSort();
        Print p = new Print();
        public Form1()
        {
            InitializeComponent();

            {
                //Objects for the sorting classes
                InsertionSort insert = new InsertionSort();
                MergeSort m = new MergeSort();
                HeapSort h = new HeapSort();
                QuickSort q = new QuickSort();
                Print p = new Print();



                //rng declaration
             //   Random ran = new Random();

                //holds the size of the array
                //int x = 0; //ran.nextInt(6) + 5; 

                //holds the choice of the user for which sorting method to use
              //  char c = ' ';







                //asks the user how long the array should be, and gets their input
                //  System.Console.WriteLine("How many numbers should be sorted? \n10, 100, 1000, 10000, 100000, 1000000 or 10000000");
                //   x = Int32.Parse(Console.ReadLine());

                //declares the array to be sorted
             //   int[] array = new int[x];





                //generates the values for the array
               // for (int i = 0; i < x; i++)
          //      {

             //       array[i] = ran.Next(10001);

             //   }

                //Sentinel for the loop. If the user enters a valid choice s becomes false and lets the loop end.
                //  bool s = true;


                /*
                while (s)
                { //loop, used to ensure that the user enters a valid value. If he does then the loop will be allowed to end

                    //asks the user which sorting method to use
                    System.Console.WriteLine("Please select a sorting method: \nEnter 1 for insertion, 2 for merge, 3 for heap, 4 for quick");
                    c = (char)System.Console.Read();

                    if (c == '1')
                    {
                       insert.insertionSortAsync(array); //uses insertion sort
                        s = false; //lets the loop end
                    }
                    else if (c == '2')
                    {
                        m.mergeSortAsync(array); //uses mergesort
                        s = false;
                    }
                    else if (c == '3')
                    {
                        h.heapsortAsync(array); //uses heapsort
                        s = false;
                    }
                    else if (c == '4')
                    {
                        q.quicksortAsync(array); //uses quicksort
                        s = false;

                    }
                    else
                    {
                        System.Console.WriteLine("You messed up, go again."); //tells the user they did not enter a valid value for sorting
                    }

                }

                if (x == 10)
                {
                    p.print(array); //prints the array if it is ten long
                }

                System.Console.WriteLine("Done!");
            }

    */

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true && checkBox1.Checked == true)
            {
                label5.Visible = true;
            }

            else
            {
                label5.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true && checkBox1.Checked == true)
            {
                label5.Visible = true;
            }

            else
            {
                label5.Visible = false;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            label4.Text = "";
            textBox1.Text = String.Empty;
            long Time;
            int x = 0;
            Random ran = new Random(99);


            if (radioButton1.Checked == true)
            {
                 x = 10;
            }

            else if (radioButton2.Checked == true)
            {
                 x = 100;
            }

            else if (radioButton3.Checked == true)
            {
                 x = 1000;
            }

            else if (radioButton4.Checked == true)
            {
                 x = 10000;
            }

            else if (radioButton5.Checked == true)
            {
                 x = 100000;
            }

            else if (radioButton6.Checked == true)
            {
                 x = 1000000;
            }

            else if (radioButton7.Checked == true)
            {
                 x = 10000000;
            }

            int[] array = new int[x];

            for (int i = 0; i < x; i++)
            {

                array[i] = ran.Next(0,99);

            }

            if (checkBox1.Checked == true)
            {
               array = await Task.Run(() => insert.insertionSortAsync(array));
                if (x ==10)
                {
                    foreach(int herpderp in array){
                        textBox1.Text += $"{herpderp}" + Environment.NewLine;
                    }
                }
            }

            if (checkBox2.Checked == true)
            {
                array = await Task.Run(() => m.mergeSortAsync(array));
                if (x == 10)
                {
                    foreach (int herpderp in array)
                    {
                        textBox1.Text += $"{herpderp}" + Environment.NewLine;
                    }
                }
            }

            if (checkBox3.Checked == true)
            {
                array = await Task.Run(() => h.heapsortAsync(array));
                if (x == 10)
                {
                    foreach (int herpderp in array)
                    {
                        textBox1.Text += $"{herpderp}" + Environment.NewLine;
                    }
                }
            }

            if (checkBox4.Checked == true)
            {
                array = await Task.Run(() => q.quicksortAsync(array));
                if (x == 10)
                {
                    foreach (int herpderp in array)
                    {
                        textBox1.Text += $"{herpderp}" + Environment.NewLine;
                    }
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Time = (elapsedMs / 1000);
            label4.Text = "Sort(s) completed in " + elapsedMs.ToString() + " Milliseconds or " + Time.ToString() + " Second(s)";
        }


    }
    }




/*
 * DialogResult dialogResult = MessageBox.Show("WARNING! Doing 10 million on insertionsort will take at least 8 hours", "I dun warned you herpderp", MessageBoxButtons.YesNo);
if(dialogResult == DialogResult.Yes)
{
    //do something
}
else if (dialogResult == DialogResult.No)
{
    //do something else
}
*/