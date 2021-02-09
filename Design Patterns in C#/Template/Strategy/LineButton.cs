using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Strategy
{
	/// <summary>
	/// Summary description for LineButton.
	/// </summary>
	public class LineButton : System.Windows.Forms.Button, Command
	{
		private System.ComponentModel.Container components = null;
		private Context contxt;
		public LineButton() 	{
			InitializeComponent();
			this.Text = "Line plot";
		}
		public void setContext(Context ctx) {
			contxt = ctx;
		}
		public void Execute() {
			contxt.setLinePlot();
			contxt.plot();
		}
		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion
	}
}
