﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Selector = Syncfusion.UI.Xaml.Diagram.Selector;
using System.Windows.Input;
using DiagramBuilder.ViewModel;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace DiagramBuilder.View
{
    public sealed partial class SelectorView : Selector
    {
        public SelectorView()
        {
            this.InitializeComponent();
        }
    }
}