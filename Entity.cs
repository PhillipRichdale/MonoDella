using System;
using System.Collections.Generic;

namespace MonoDella
{
	public class Entity:Dellaobject
	{
		public string name;
		public Dictionary<String, Attribute> Attributes;
		public Dictionary<String, Relation> Relations;
		public Dictionary<String, Area> Areas;
		public Entity(string tn)
		{
			Attributes = new Dictionary<String, Attribute>();
			Relations = new Dictionary<String, Relation>();
			Areas = new Dictionary<String, Area>();
			name = tn;
			Console.WriteLine("Entity constructed.");
		}
		public void add(Attribute a)
		{
			this.addAttribute(a);
		}
		public void addRelation(Relation r)
		{
			if (!this.Relations.ContainsKey(r.role)) {
				Relations.Add(r.role, r);
			}
		}
		public void addAttribute(Attribute a)
		{
			if (!this.Attributes.ContainsKey(a.name)) {
				Attributes.Add(a.name, a);
			}
		}
		public void attachToArea(Area thisArea)
		{
			Console.WriteLine("thisArea.name: " + thisArea.name);
			this.Areas.Add(thisArea.name, thisArea);
		}

	}
}

