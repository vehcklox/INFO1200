﻿//Name: Adrien Maranville
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 01/21/2016
//Project #: 1
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMMyFitnessApp
{
    public partial class myProfileForm : Form
    {
        public myProfileForm()
        {
            InitializeComponent();
        }

        private void btnProfileExit_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}