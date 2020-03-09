using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20200308
{
    class RecSelect : Selector
    {
        public void select(Item item)
        {
            item.setState(State.REC_SELECTED);
            if (item.isExpanded())
            {
                foreach (var i in item.getChildrens())
                {
                    i.select(this);
                }
            }
           
        }
    }
}
