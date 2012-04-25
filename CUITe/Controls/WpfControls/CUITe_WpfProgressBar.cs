﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfProgressBar
    /// </summary>
    public class CUITe_WpfProgressBar : CUITe_WpfControl<WpfProgressBar>
    {
        public CUITe_WpfProgressBar() : base() { }
        public CUITe_WpfProgressBar(string sSearchParameters) : base(sSearchParameters) { }

        public double MaximumValue
        {
            get { return this.UnWrap().MaximumValue; }
        }

        public double MinimumValue
        {
            get { return this.UnWrap().MinimumValue; }
        }

        public double Position
        {
            get { return this.UnWrap().Position; }
        }
    }
}