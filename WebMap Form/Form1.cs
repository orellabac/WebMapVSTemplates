using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UpgradeHelpers.Interfaces;

namespace $rootnamespace$
{
    public class $basename$ : ILogicView<$basename$ViewModel>
    {
        public $basename$ViewModel ViewModel
        {
            get;
            set;
        }

        public IViewManager ViewManager
        {
            get;
            set;
        }

        public IIocContainer Container
        {
            get;
            set;
        }

        internal void button1_click()
        {
            ViewManager.ShowMessage(ViewModel.ClientName.Text);
        }
    }
}