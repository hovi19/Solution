﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20200308
{
    class DeSelect : Selector
    {
        public void select(Item item)
        {
            item.setState(State.NOT_SELECTED);
        }
    }
}
