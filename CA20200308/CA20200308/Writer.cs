using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20200308
{
    class Writer : Selector
    {
        public void select(Item item)
        {
            item.write();

            foreach (var i in item.getChildrens())
            {
                i.select(this);
            }
        }
    }
}
