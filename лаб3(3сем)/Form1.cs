﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб3_3сем_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public interface IMovable
        {
            void Move();
        }

        public interface ICollidable
        {
            void OnCollision(ICollidable other);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
