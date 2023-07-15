using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*************************************************************************/
/* Program Name:     Ch17Ex3.cs                                          */
/* Date:             05/02/2022                                      	 */
/* Programmer:       Miranda Morris                                      */
/* Class:            CSCI 234                               		     */
/*                                                                       */
/* Program Description: The purpose of this program is to create a file  */
/* that contains the name, id number, class taken, and grade of each     */
/* student within the file and display it into a read-only textbox       */
/*                                                                       */
/* Input: grades.txt file containig name, id number, class taken, & grade*/
/*                                                                       */
/* Output: display the contents of grade.txt on a textbox                */
/*                                                                       */
/* Givens: None							                                 */
/*                                                                       */
/* Testing Data:                                                         */
/*                                                                       */
/* List the Testing Input Data: Run the program                          */
/*                                                                       */
/* List the Testing Output Data: "There was a problem loading the file"  */
/*                                                                       */
/*                                                                       */
/*************************************************************************/

namespace ch17ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //C: \Users\miran\Desktop\ch17ex3\ch17ex3\grades.txt
            //string filePath = @"C:\...\...\...\...\...\...\...\...\grades.txt";
            
            string path = @"C:\Users\miran\Desktop\ch17ex3\ch17ex3\grades.txt";
            //if (!File.Exists(filePath))
            if (!File.Exists(path))
            {
                StreamReader stream = new StreamReader(path);
                txtGrades.AppendText(stream.ReadToEnd());
            }
            else
            {
                MessageBox.Show("There was a problem loading the file");
            }
        }
    }
}
