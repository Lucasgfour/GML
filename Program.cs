
using System;
using System.Windows.Forms;
using GM.View;

namespace GM {
	internal sealed class Program {

		[STAThread]
		private static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new IDUsuario());
		}
		
	}
}
