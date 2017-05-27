using System;

namespace MonoDella
{
	public class Relation
	{
		public string role;
		//We may only set these at intialisation:
		public Entity myEntity;
		public string myCardinality;
		public Entity farEntity;
		public string farCardinality;

		public Relation(
				string r,
				Entity myE,
				string myCard,
				Entity farE,
				string farCard
			)
		{
			this.role = r;

			this.myEntity = myE;
			this.myCardinality = myCard;
			this.farEntity = farE;
			this.farCardinality = farCard;
		
			Console.WriteLine("RELATION Created.");
		}
	}
}

