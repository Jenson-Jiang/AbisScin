using AbisSkin.Utility.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AbisSkin.Controls.Core
{
    public class AbisTabControl : TabControl
    {
        void SelectionState()
        {
            ElementBase.GoToState(this, "SelectionStart");
            ElementBase.GoToState(this, "SelectionEnd");
        }

        public AbisTabControl()
        {
            Loaded += delegate { ElementBase.GoToState(this, "SelectionLoaded"); };
            SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) { if (e.Source is AbisTabControl) { SelectionState(); } };

        }

        static AbisTabControl()
        {
            ElementBase.DefaultStyle<AbisTabControl>(DefaultStyleKeyProperty);
        }
    }
}
