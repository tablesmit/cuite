﻿using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinMenuBar
    /// </summary>
    public class WinMenuBar : WinControl<CUITControls.WinMenuBar>
    {
        public WinMenuBar(By searchConfiguration = null)
            : this(new CUITControls.WinMenuBar(), searchConfiguration)
        {
        }

        public WinMenuBar(CUITControls.WinMenuBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }

        public List<WinMenuItem> ItemsAsCUITe
        {
            get
            {
                List<WinMenuItem> list = new List<WinMenuItem>();
                foreach (CUITControls.WinMenuItem item in SourceControl.Items)
                {
                    WinMenuItem cuiteItem = new WinMenuItem(item);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public List<string> ItemsAsList
        {
            get { return (from x in SourceControl.Items select ((CUITControls.WinMenuItem)x).DisplayText).ToList<string>(); }
        }
    }
}