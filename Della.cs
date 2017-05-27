using System;
using System.Collections.Generic;

namespace MonoDella
{
	public class Della
	{
		Project activeProject;
		public string entityInFocus;
		
		protected static string[] dellaDataTypes;
		protected static string[] dellaRelationTypes;

		public Dictionary<String, Project> Projects;
		protected Dictionary<string, string> dellaCardinalityTypes;

		public Della()
		{
			Projects = new Dictionary<String, Project>();
			dellaCardinalityTypes = new Dictionary<string,string>();
			initDellaDataTypes();
			initDellaCardinalityTypes();

			this.testRun();
		}
		public void testRun ()
		{
			FileHandler myFh = new FileHandler();
			String tempName = this.generateTestData();

			myFh.saveProject(Projects[tempName]);
			myFh.close();

			Console.WriteLine("Fettich!");
			Console.ReadKey();
		}
		public void addProject (Project p)
		{
			Console.WriteLine (Projects.ToString ());
			foreach(KeyValuePair<String,Project> item in Projects)
			{
				Console.WriteLine("P NAME: " + item.Value.name);
			} //*
			if (this.Projects.ContainsKey(p.name))
			{
				//throw new Exception("There already is a project with the name " +
				//                    p.name + ". Project names must be unique.");
			} else {
				this.Projects.Add(p.name, p);
			} //*/
		}
		public string generateTestData ()
		{
			Project myP =  new Project("Fettes Projekt", "Dieses Projekt ist das beste!");
			this.addProject(myP);
		
			string thisProject = myP.name;
			string thisEntity = "user";
			Entity e = new Entity(thisEntity);
			Console.WriteLine(Projects[thisProject].ToString());
			Projects[thisProject].addEntity(e);
			Projects[thisProject].Entities[thisEntity].add(new Attribute("vorname", "string", 50));
			Projects[thisProject].Entities[thisEntity].add(new Attribute("nachname", "string", 100));
			Projects[thisProject].Entities[thisEntity].add(new Attribute("login", "string", 100));
			Projects[thisProject].Entities[thisEntity].add(new Attribute("passwort", "string", 100));
			//*
			Projects[thisProject].Entities[thisEntity].addRelation(
				new Relation(
					"gruppe",
					Projects[thisProject].Entities[thisEntity],
					dellaCardinalityTypes["1-*"],
					Projects[thisProject].Entities["user"],
					dellaCardinalityTypes["0-*"]
				)
			);//*/
			thisEntity = "content";
			Projects[thisProject].addEntity(new Entity(thisEntity));
			Projects[thisProject].Entities[thisEntity].add(new Attribute("headline", "string", 200));
			Projects[thisProject].Entities[thisEntity].add(new Attribute("content", "string", 2000));

			Projects[thisProject].Entities[thisEntity].addRelation(
				new Relation(
					"author",
					Projects[thisProject].Entities[thisEntity],
					dellaCardinalityTypes["1"],
					Projects[thisProject].Entities["user"],
					dellaCardinalityTypes["0-*"]
				)
			);

			thisEntity = "gruppe";
			Projects[thisProject].addEntity(new Entity(thisEntity));
			Projects[thisProject].Entities[thisEntity].add(new Attribute("name", "string", 50));
			Projects[thisProject].Entities[thisEntity].add(new Attribute("description", "string", 200));

			Projects[thisProject].Entities[thisEntity].addRelation(
				new Relation(
					"user",
					Projects[thisProject].Entities[thisEntity],
					dellaCardinalityTypes["0-*"],
					Projects[thisProject].Entities["user"],
					dellaCardinalityTypes["1-*"]
				)
			);
			/*
			thisEntity = "";
			Projects[thisProject].addEntity(new Entity(thisEntity));
			Projects[thisProject].Entities[thisEntity].add(new Attribute("", "", 50));
			Projects[thisProject].Entities[thisEntity].addRelation(
				new Relation(
					"",
					Projects[thisProject].Entities[thisEntity],
					dellaCardinalityTypes["1"],
             				Projects[thisProject].Entities[""],
					dellaCardinalityTypes["0-*"]
				)
			); */
			Console.WriteLine("gen testdata clear");
			return myP.name;
		}
		//Referenztabellen initialisieren:
		private static void initDellaDataTypes ()
		{
			/* Wir wollen in diesem Modeller nicht groß über Datentypen
			 * nachdenken. Das soll Della später selbst machen. Wir 
			 * geben nur den einfachen Typ und die maximale Größe an. */
			dellaDataTypes = new string[] {
				"string",
				"int",
				"double",
				"binary"
			};
		}
		private static void initDellaRelationTypes ()
		{
			dellaRelationTypes = new string[] {
				"hasOne",
				"hasMany",
				"hasAtLeastOne",
				"mayHaveOne",
				"mustHaveOne"
			};
		}
		private void initDellaCardinalityTypes()
		{
			this.dellaCardinalityTypes.Add("0-1", "0-1");
			this.dellaCardinalityTypes.Add("0-*", "0-*");
			this.dellaCardinalityTypes.Add("1", "1");
			this.dellaCardinalityTypes.Add("1-*", "1-*");
		}
		public void buildProjectView (Project activeProject) {}
		public void loadConfig() {}
	}
}

