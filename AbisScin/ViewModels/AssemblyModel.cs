using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbisScin.ViewModels
{
    public class AssemblyModel : ViewModelBase
    {
        private bool _IsLove;
        public bool IsLove 
        {
            get { return _IsLove; }
            set { _IsLove = value; RaisePropertyChanged(nameof(IsLove)); }
        }
    }
}
