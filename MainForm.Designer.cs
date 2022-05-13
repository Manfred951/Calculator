/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Manfred Laidler
 * Datum: 13.05.2022
 * Zeit: 09:31
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace Calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFirst;
		private System.Windows.Forms.TextBox txtSecond;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.TextBox txtCalc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtResult;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFirst = new System.Windows.Forms.TextBox();
			this.txtSecond = new System.Windows.Forms.TextBox();
			this.btnCalc = new System.Windows.Forms.Button();
			this.txtCalc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Erste Zahl";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(30, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Zweite Zahl";
			// 
			// txtFirst
			// 
			this.txtFirst.Location = new System.Drawing.Point(113, 27);
			this.txtFirst.Name = "txtFirst";
			this.txtFirst.Size = new System.Drawing.Size(218, 20);
			this.txtFirst.TabIndex = 2;
			// 
			// txtSecond
			// 
			this.txtSecond.Location = new System.Drawing.Point(113, 80);
			this.txtSecond.Name = "txtSecond";
			this.txtSecond.Size = new System.Drawing.Size(218, 20);
			this.txtSecond.TabIndex = 3;
			// 
			// btnCalc
			// 
			this.btnCalc.Location = new System.Drawing.Point(113, 126);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(75, 23);
			this.btnCalc.TabIndex = 4;
			this.btnCalc.Text = "Addiere";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.BtnCalcClick);
			// 
			// txtCalc
			// 
			this.txtCalc.Location = new System.Drawing.Point(113, 176);
			this.txtCalc.Multiline = true;
			this.txtCalc.Name = "txtCalc";
			this.txtCalc.Size = new System.Drawing.Size(218, 61);
			this.txtCalc.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(30, 176);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Berechnung";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(30, 313);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Ergebnis";
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(113, 313);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(218, 20);
			this.txtResult.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 366);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCalc);
			this.Controls.Add(this.btnCalc);
			this.Controls.Add(this.txtSecond);
			this.Controls.Add(this.txtFirst);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
