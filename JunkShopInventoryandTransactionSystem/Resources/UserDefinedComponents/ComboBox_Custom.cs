using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkShopInventoryandTransactionSystem.Resources.UserDefinedComponents
{
    public partial class ComboBox_Custom : Component
    {
        public ComboBox_Custom()
        {
            InitializeComponent();
        }

        public ComboBox_Custom(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
