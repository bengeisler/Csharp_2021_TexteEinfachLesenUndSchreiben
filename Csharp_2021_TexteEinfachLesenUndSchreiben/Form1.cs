using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_TexteEinfachLesenUndSchreiben
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLöschen_Click(object sender, EventArgs e)
		{
			txtEinUndAusgabe.Text = "";
		}

		private void btnSchreiben_Click(object sender, EventArgs e)
		{
			try
			{
				// SaveFileDialog
				var sfd = new SaveFileDialog()
				{
					InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
					Filter = "Textdateien (*.txt)|*.txt|" +
					"Alle Dateien (*.*)|*.*",
					Title = "Datei speichern unter..."
				};

				//// Prüfen, ob Button "Speichern" gedrückt wurde, andernfalls Abbruch
				//if (sfd.ShowDialog() != DialogResult.OK) return;

				//// Text in die Datei schreiben (Datei wird überschrieben)
				//File.WriteAllText(sfd.FileName, txtEinUndAusgabe.Text);

				// Prüfen, ob Button "Speichern" gedrückt wurde 
				// => Nur dann wird der Text in die Datei geschrieben
				if (sfd.ShowDialog() == DialogResult.OK) 
					File.WriteAllText(sfd.FileName, txtEinUndAusgabe.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnLesen_Click(object sender, EventArgs e)
		{
			try
			{
				// OpenFileDialog
				var ofd = new OpenFileDialog()
				{
					InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
					Filter = "Textdateien (*.txt)|*.txt|" +
						"Alle Dateien (*.*)|*.*",
					Title = "Datei öffnen..."
				};

				if (ofd.ShowDialog() == DialogResult.OK)
					txtEinUndAusgabe.Text = File.ReadAllText(ofd.FileName);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
