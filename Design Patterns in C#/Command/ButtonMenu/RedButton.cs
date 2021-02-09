using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace ButtonMenu
{
	/// <summary>
	/// Summary description for RedButton.
	/// </summary>
	public class RedButton : System.Windows.Forms.Button, Command 	{
		//A Command button that turns the background red
		private System.ComponentModel.Container components = null;
		//-----
		public  void Execute() {
			Control c = this.Parent;
			c.BackColor =Color.Red ;
			this.BackColor =Color.LightGray  ;
		}
		public RedButton() 		{
			InitializeComponent();
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
