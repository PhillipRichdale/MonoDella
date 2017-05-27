using System;
using System.Collections.Generic;

namespace MonoDella
{
	/* Bildet ein Attribut einer Entity in Della ab.
	 * Bietet eine vereinfachte Liste an Datentypen, die dann
	 * passend zu angegebenen Maximalgröße für die jeweilige DB, 
	 * das jeweilige Framework oder ORM Toolkit in die passenden
	 * übersetzt werden.
	*/
	public class Attribute:Dellaobject
	{
		public string dellatype;
		public int estimatedMaxSize;

		public Attribute (){}
		public Attribute (string n, string dt, int estSize)
		{
			this.name = n;
			this.dellatype = dt;
			this.estimatedMaxSize = estSize;
		}
	}
}

