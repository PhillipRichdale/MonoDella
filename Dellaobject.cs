using System;

namespace MonoDella
{
	public class Dellaobject
	{
		private string _name;
		public Dellaobject () {}
		public string name {
			set {
				try {
				if (Util.nameIsLegal (value)) {
						this._name = value;
					} else {
						throw new System.ArgumentException("Error: "+
					        "Illegal Name passed during " + this.GetType().ToString() +
						" initialization.", "n");
					}
				} catch (Exception ex) {
					Logger.log (ex.ToString());
				}
			}
			get {return _name;}
		}
	}
}

