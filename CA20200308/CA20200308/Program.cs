using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20200308
{
	class Program
	{
		static Random rnd = new Random();
		
		
		public static void Main(String[] args)
		{

			Item root = new Item("Root");

			Base(root);

			root.select(new Writer());
			Console.WriteLine("\n//////////////////////////////\n");

			try
			{
				root.getChild(2).select(new Select());

				root.select(new Writer());
				Console.WriteLine("\n//////////////////////////////\n");

				root.getChild(0).select(new RecSelect());

				root.select(new Writer());
				Console.WriteLine("\n//////////////////////////////\n");


				root.getChild(0).getChild(0).select(new DeSelect());

				root.getChild(0).getChild(0).setExpanded(false);

				root.select(new Writer());
				Console.WriteLine("\n//////////////////////////////\n");

				root.getChild(0).select(new RecDeSelect());

				root.select(new Writer());
				Console.WriteLine("\n//////////////////////////////\n");

			}
			catch (Exception)
			{
				Console.WriteLine("Megadott elem nem létezik");
			}
			Console.ReadKey();
		}


		public static void random(Item root)
		{
			Item item = new Item("Text");
			root.addItem(item);

			int c = rnd.Next(3);

			int e = rnd.Next(2);

			if (e > 0) item.setExpanded(false);

			if (root.getLevel() < 4)
				for (int i = 0; i < c; i++)
				{
					random(item);
				}

		}
		public static void Base(Item root) 
		{
		
		Item item1 = new Item("Base 1");
		root.addItem(item1);
	

		Item item2 = new Item("Base 2");
		root.addItem(item2);
		

		Item item3 = new Item("Base 3");
		root.addItem(item3);
		
		
		Item item4 = new Item("Second 1");
		item1.addItem(item4);
		
		Item item5 = new Item("Second 2");
		item1.addItem(item5);
		
		Item item6 = new Item("2 Second 3");
		item2.addItem(item6);
		
		Item item7 = new Item("Third 1");
		item4.addItem(item7);
		
		}

	}
}

