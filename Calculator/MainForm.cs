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
using System.Text;
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
			// TODO inits
			//
			txtFirst.Text = "3,41";
			txtSecond.Text = "356,4";
		}
		
		void BtnCalcClick(object sender, EventArgs e)
		{
			//
			// TODO compute
			//
			StringBuilder sb = new StringBuilder(); 
			
			string str1 = txtFirst.Text;
			int len1 = str1.Length;
			sb.AppendLine("len1=" + len1.ToString());
			
			string str2 = txtSecond.Text;
			int len2 = str2.Length;
			sb.AppendLine("len2=" + len2.ToString());
			
			// string.Format( {0,-12} to define a 12-character right-aligned fieldwidth (nicht Stellenzahl!)
			// :0000.00		4 stellen vor und 2 stellen nach komma
			// :D8 oder X8 : Stellenanzahl gesamt 8 dez oder hex
			// Currency ("C") Decimal ("D") Exponential ("E") Fixed-Point ("F")
    		// General ("G") Numeric ("N") Percent ("P") Round-trip ("R") Hexadecimal ("X")
				
			int komma1 = str1.IndexOf(',');
			if (komma1 == -1) komma1 = len1; // ganz hinten
			sb.AppendLine("komma1=" + komma1.ToString());
			
			int komma2 = str2.IndexOf(',');
			if (komma2 == -1) komma2 = len2; // ganz hinten
			sb.AppendLine("komma2=" + komma2.ToString());
			
			int lenVor;
			if (komma1 > komma2)
				lenVor = komma1;
			else
				lenVor = komma2;
			sb.AppendLine("lenVor=" + lenVor.ToString());
			
//			int lenGes;
//			if (len1 > len2)
//				lenGes = lenkomma1;
//			else
//				lenVor = komma2;
//			sb.AppendLine("lenVor=" + lenVor.ToString());
			
			char[] phraseAsChars = str1.ToCharArray();
			phraseAsChars[index] = 't';
			string s1 = new string(phraseAsChars);
			
			int beg, set;
			string sGet;
			string s1 = "0000000000000000000000000000000";
			for (int i=0; i< lenVor; i++){
				// Zeichen holen
				beg = i;
				sGet = str1.Substring(beg,1);
				// Zeichen setzen
				set = 1+i;
				s1. .Replace(  [set] = sGet[0];
			}
			sb.AppendLine("s1=" + s1);

			txtCalc.Text = sb.ToString();
		}
	}
}
