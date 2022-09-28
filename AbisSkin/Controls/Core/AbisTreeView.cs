using AbisSkin.Utility.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AbisSkin.Controls.Core
{
    public class AbisTreeView : TreeView
    {
        static AbisTreeView()
        {
            ElementBase.DefaultStyle<AbisTreeView>(DefaultStyleKeyProperty);
        }
    }
}
