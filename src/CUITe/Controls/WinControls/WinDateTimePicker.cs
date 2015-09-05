﻿using System;
using System.Windows.Forms;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinDateTimePicker
    /// </summary>
    public class WinDateTimePicker : WinControl<CUITControls.WinDateTimePicker>
    {
        public WinDateTimePicker(By searchConfiguration = null)
            : this(new CUITControls.WinDateTimePicker(), searchConfiguration)
        {
        }

        public WinDateTimePicker(CUITControls.WinDateTimePicker sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public UITestControl Calendar
        {
            get { return SourceControl.Calendar; }
        }

        public WinCalendar CalendarAsCUITe
        {
            get
            {
                WinCalendar calendar = new WinCalendar((CUITControls.WinCalendar)Calendar);
                return calendar;
            }
        }

        public DateTime DateTime
        {
            get { return SourceControl.DateTime; }
            set { SourceControl.DateTime = value; }
        }

        public string DateTimeAsString
        {
            get { return SourceControl.DateTimeAsString; }
            set { SourceControl.DateTimeAsString = value; }
        }

        public DateTimePickerFormat Format
        {
            get { return SourceControl.Format; }
        }

        public bool HasCheckBox
        {
            get { return SourceControl.HasCheckBox; }
        }

        public bool HasDropDownButton
        {
            get { return SourceControl.HasDropDownButton; }
        }

        public bool HasSpinner
        {
            get { return SourceControl.HasSpinner; }
        }

        public bool ShowCalendar
        {
            get { return SourceControl.ShowCalendar; }
            set { SourceControl.ShowCalendar = value; }
        }
    }
}