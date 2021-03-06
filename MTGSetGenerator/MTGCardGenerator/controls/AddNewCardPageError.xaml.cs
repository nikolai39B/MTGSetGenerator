﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MTGSetGenerator
{
    /// <summary>
    /// Interaction logic for AddNewCardPageError.xaml
    /// </summary>
    public partial class AddNewCardPageError : UserControl
    {
        public AddNewCardPageError()
            : this("")
        {
        }

        public AddNewCardPageError(string error)
        {
            InitializeComponent();
            ErrorMessage = error;
        }

        public string ErrorMessage
        {
            get { return tbl_Error.Text; }
            set { tbl_Error.Text = value; }
        }
    }
}
