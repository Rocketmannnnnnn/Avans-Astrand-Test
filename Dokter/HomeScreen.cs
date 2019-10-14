﻿#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Dokter
{
    public partial class HomeScreen : Form
    {
        private Controller controller;

        public HomeScreen()
        {
            InitializeComponent();
            controller = new Controller(this);
            controller.Connect();
            controller.DataRequest();
        }
    }
}