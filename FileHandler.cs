using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MonoDella
{
	public class FileHandler
	{
		public string dateiname;
		public string homepath;
		public string completePath;
		private StreamWriter sWriter;
		private StreamReader sReader;

		public FileHandler (string d = "kannweg.della", string p = null)
		{
			if (null == p) {
				this.homepath = (
					Environment.OSVersion.Platform == PlatformID.Unix || 
					Environment.OSVersion.Platform == PlatformID.MacOSX
					)
					? Environment.GetEnvironmentVariable ("HOME")
						: Environment.ExpandEnvironmentVariables ("%HOMEDRIVE%%HOMEPATH%");
			} else {
				this.homepath = p;
			}
			
			this.dateiname = d;
			this.completePath = this.homepath + Path.DirectorySeparatorChar + this.dateiname;
			Console.WriteLine("PAth: " + completePath);
			
			try {
				this.sWriter = new StreamWriter (this.completePath);
				Console.WriteLine("sWriter erzeugt.");
			} catch (Exception ex) {
				Console.WriteLine("Fehler beim Initialisieren des StreamWriters.");
				if (p != null)
				{
					Console.WriteLine("Stimmt der angegebene Pfad? > " + this.completePath);
				} else {
					Console.WriteLine("Rechteprobleme?");
				}
			}
			/*
			try {
				this.sReader = new StreamReader (this.completePath);
			} catch (Exception ex) {
				Console.WriteLine("Fehler beim Initialisieren des StreamReaders.");
				if (p != null)
				{
					Console.WriteLine("Stimmt der angegebene Pfad? > " + this.homepath);
				} else {
					Console.WriteLine("Rechteprobleme?");
				}
			} */
			Console.WriteLine("fh setup clear.");
		}
		public void close()
		{
			this.sWriter.Close();
			//this.sReader.Close();
		}
		public void open()
		{
			//this.sWriter.Flush();
			//this.sReader.
		}
		public int wieOftlInDatei (string searchString)
		{
			int soOft = 0;
			string line;
			while ((line = this.sReader.ReadLine()) != null) {
				soOft += new Regex(line).Matches(searchString).Count;
			}
			return soOft;
		}
		public void saveProject_TEST(Project p = null)
		{
			Console.WriteLine("saveProject");
		}
		public void saveProject(Project p)
		{
			sWriter.WriteLine("Project: " + p.name);
			sWriter.WriteLine("Description: " + p.description);
			sWriter.WriteLine();
			sWriter.WriteLine("Model:");
			foreach(KeyValuePair<String,Entity> eItem in p.Entities)
			{
				Console.WriteLine("writing...");
				//Write Entities with Attributes
				sWriter.WriteLine("\t" + eItem.Value.name);
				if (eItem.Value.Attributes.Count > 0)
				{
					sWriter.WriteLine("\t\t" + "Attributes:");
				}
				foreach(KeyValuePair<String,Attribute> aItem in eItem.Value.Attributes)
				{
					sWriter.WriteLine("\t\t" + aItem.Value.name + " " +
					                  "(Type: "+aItem.Value.dellatype +
					                  ", Size: " + aItem.Value.estimatedMaxSize + ")");
				}
				if (eItem.Value.Relations.Count > 0)
				{
					sWriter.WriteLine("\t\t" + "Relations:");
				}
				/*
		                  this.myEntity = myE;
		                  this.myCardinality = myCard;
		                  this.farEntity = farE;
		                  this.farCardinality = farCard;
				*/
				foreach(KeyValuePair<String,Relation> item in eItem.Value.Relations)
				{
					sWriter.WriteLine("\t\t" + "Role: " + item.Value.role + "\n\t\t" +
					                  "(" +
					                  "My Entity: "+ item.Value.myEntity.name +
					                  ", My Cardinality: " + item.Value.myCardinality  + "\n\t\t" + 
					                  "Far Entity: "+ item.Value.farEntity.name +
					                  ", Far Cardinality: " + item.Value.farCardinality + ")");
				}
				/*
				sWriter.WriteLine("\t\tAreas of this Entity:");
				foreach(KeyValuePair<String,Area> aItem in eItem.Value.Areas)
				{
					sWriter.WriteLine("\t\t\t" + aItem.Value.name);
				} */
				sWriter.WriteLine();
			}
			sWriter.WriteLine();
			sWriter.WriteLine("Areas:");
			foreach(KeyValuePair<String,Area> aItem in p.Areas)
			{
				sWriter.WriteLine("------------------");
				sWriter.WriteLine("Area: " + aItem.Value.name);
				sWriter.WriteLine("Description: " + aItem.Value.description);
			}
		}
	}
}