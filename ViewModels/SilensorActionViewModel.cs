using Shhh.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shhh.ViewModels
{
    public class SilensorActionViewModel : BaseViewModel
    {
        public Silensor Silensor { set; get; }

        public SilensorActionViewModel(Silensor silcr)
        {
            Silensor = silcr;
        }
    }
}
