using System;
using System.Collections.Generic;

namespace MonoDella
{
	public class Util
	{
		public Util (){}
		//Utility Klimbim machen wir mal static.
		//Müssen nicht den Speicher vollmüllen.:
		public static bool nameIsLegal (string n)
		{
			//rM : Kurzform für returnMe.
			bool rM = true;
			//darf nur reines UrASCII-Alpha und Unterstrich enthalten
			//Erlaubte ASCII-Codes: 65 - 90,95,97 - 122
			foreach (char c in n) {
				int codewert = Convert.ToInt32(c);
				if (
					( (codewert >= 65) && (codewert <= 90) )
					||
					( (codewert >= 97) && (codewert <= 122) )
					||
					(95 == codewert)
					) {
					// goanix
				} else {
					rM = false;
				}
			}
			return rM;
		}
		public static void dictDebug(Dictionary<String, Entity> thisDict)
		{
			foreach(KeyValuePair<String,Entity> entry in thisDict)
			{

			}
		}
	}
}

