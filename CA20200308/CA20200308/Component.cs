using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20200308
{
    public interface Component
    {
        void select(Selector selector);
        void addItem(Component item);

		 void init(Component parent, int level, int index);

		 List<Component> getChildrens();

		void setState(State state);

		 State getState(State state);

		Component getChild(int index); 

		 Component getParent();
	
		 bool isExpanded();

		 void setExpanded(bool expanded);

		void write();
    }
}
