﻿using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlRadioButton : HtmlControl<CUITControls.HtmlRadioButton>
    {
        public HtmlRadioButton(By searchConfiguration = null)
            : this(new CUITControls.HtmlRadioButton(), searchConfiguration)
        {
        }

        public HtmlRadioButton(CUITControls.HtmlRadioButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public void Select()
        {
            WaitForControlReady();
            SourceControl.Selected = true;
        }

        public void Select2()
        {
            WaitForControlReady();
            string sOnClick = (string)SourceControl.GetProperty("onclick");
            string sId = SourceControl.Id;
            if (sId == null || sId == "")
            {
                throw new GenericException("Select2(): No ID found for the RadioButton!");
            }
            RunScript("document.getElementById('" + sId + "').checked=true;" + sOnClick);
        }

        public bool IsSelected
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Selected;
            }
        }
    }
}