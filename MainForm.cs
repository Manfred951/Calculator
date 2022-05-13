/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Manfred Laidler
 * Datum: 13.05.2022
 * Zeit: 09:31
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcClick(object sender, EventArgs e)
		{
			txtCalc.Text = "Calc started";
			
	
		}
	}
}
