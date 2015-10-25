﻿using CUITe.Controls.WpfControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.WorkflowsTest.ObjectRepository
{
    public class FinishedScreenComponent : ScreenComponent
    {
        public bool CongratulationsExists
        {
            get { return Find<WpfText>(By.AutomationId("VFLNy3N30EeNzd8og89CLQ")).Exists; }
        }
    }
}