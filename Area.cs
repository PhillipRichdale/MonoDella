// Entities in Projects are grouped into arbitrary areas
// that make sense to the Projects architect. They are
// added to the corresponding Area.Entities Lists via reference.
using System;
using System.Collections.Generic;

namespace MonoDella
{
	public class Area
	{
		public string name {get;set;}
		public string description {get;set;}
		public Dictionary<String, Entity> Entities;
		public Area (string n, string desc  = "- no description added -")
		{
			Entities = new Dictionary<String, Entity>();
			this.name = n;
			this.description = desc;
		}

		//Entities are only grouped, not copied(!) and thus passed by reference:
		public void attachEntity(Entity item)
		{
			if (!this.Entities.ContainsKey(item.name))
			{
				item.attachToArea(this);
				this.Entities.Add(item.name, item);
			}
		}
	}
}

