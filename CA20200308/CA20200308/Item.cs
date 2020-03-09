using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20200308
{
	public class Item : Component
	{
		private string text;

		private bool Expanded;
		private State state;

		private int level;
		private int index;

		private List<Component> childrens;
		private Component parent;

		public Item(string text)
		{
			this.Expanded = true;
			this.state = State.NOT_SELECTED;
			this.text = text;
			this.childrens = new List<Component>();
			this.index = 0;
			this.level = 0;

		}
		public void select(Selector selector)
		{
			selector.select(this);
		}

		public void addItem(Component item)
		{
			childrens.Add(item);

			item.init(this, this.level + 1, this.childrens.Count());
		}


		public void write()
		{
			Console.WriteLine($"Szint:  {level}  Index:  {index}   Nyitva :   {Expanded}   Text:   {text}   isSelected: {state}");
		}


		public void init(Component parent, int level, int index)
		{
			this.parent = parent;
			this.level = level;
			this.index = index;
		}


		public List<Component> getChildrens()
		{
			return childrens;
		}


		public void setState(State state)
		{
			this.state = state;
		}


		public State getState(State state)
		{
			return state;
		}


		public Component getChild(int index)
		{
			if (childrens.Count() <= index) throw new Exception();
			else return childrens[index];
		}


		public Component getParent()
		{
			return parent;
		}


		public bool isExpanded()
		{
			return Expanded;
		}


		public void setExpanded(bool isExpanded)
		{
			this.Expanded = isExpanded;
		}

		
		public int getLevel()
		{
			return level;
		}

		public void setLevel(int level)
		{
			this.level = level;
		}

		public int getIndex()
		{
			return index;
		}

		public void setIndex(int index)
		{
			this.index = index;
		}
	
	}
}

