using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UpgradeHelpers.BasicViewModels;
using UpgradeHelpers.Interfaces;

namespace $rootnamespace$
{
    public class $basename$ViewModel : IViewModel
    {
        public string Name
        {
            get { return typeof($basename$).FullName; }
        }

        public bool Visible
        {
            get;
            set;
        }

        public string UniqueID
        {
            get;
            set;
        }


        public virtual TextBoxViewModel ClientName { get; set; }
        public virtual TextBoxViewModel ClientEmail { get; set; }

        public void Build(IIocContainer ctx)
        {
            ClientName = ctx.Resolve<TextBoxViewModel>();
            ClientEmail = ctx.Resolve<TextBoxViewModel>();
        }
    }
}