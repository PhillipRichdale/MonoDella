using System;
using System.Collections.Generic;

namespace MonoDella
{
	public class Project
	{
		public string name;
		public string description;
		public Dictionary<String, Entity> Entities;
		public Dictionary<String, Area> Areas;
		public Project(string n, string desc = "- no description added -")
		{
			Entities = new Dictionary<string, Entity>();
			Areas = new Dictionary<String, Area>();
			this.name = n;
			this.description = desc;
			//Default Area "all" umfasst alle Entities:
			Areas.Add("all", new Area("all", "The total of all entities in project '" + this.name + "'"));
		}
		public void linkEntityToArea (string eName, string aName)
		{
			if (!Areas[aName].Entities.ContainsKey(eName)) {
				Areas[aName].attachEntity(Entities[eName]);
			}
		}
		public void addEntity (Entity item)
		{
			Console.WriteLine("Project.addEntity(...), Entity name: " + item.name);
			Console.WriteLine(Entities.ToString());
			Console.ReadKey();

			if (!this.Entities.ContainsKey(item.name))
			{
				this.Entities.Add(item.name, item);
			}

			/* Default Area "all" umfasst alle Entities. Hier wollen
			wir die bidirektionale Referenz Area<->Entity anlegen,
			bevor wir die Entity unserer Entitylist zuweisen:	*/
			Areas["all"].attachEntity(item);
		}
		public void addArea (Area item)
		{
			if (!this.Areas.ContainsKey(item.name))
			{
				this.Areas.Add(item.name, item);
			}
		}
	}
}

