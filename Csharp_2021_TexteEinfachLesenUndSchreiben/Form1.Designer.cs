
namespace Csharp_2021_TexteEinfachLesenUndSchreiben
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnLesen = new System.Windows.Forms.Button();
			this.btnSchreiben = new System.Windows.Forms.Button();
			this.btnLöschen = new System.Windows.Forms.Button();
			this.txtEinUndAusgabe = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnLesen
			// 
			this.btnLesen.Location = new System.Drawing.Point(13, 13);
			this.btnLesen.Name = "btnLesen";
			this.btnLesen.Size = new System.Drawing.Size(75, 23);
			this.btnLesen.TabIndex = 0;
			this.btnLesen.Text = "Lesen";
			this.btnLesen.UseVisualStyleBackColor = true;
			this.btnLesen.Click += new System.EventHandler(this.btnLesen_Click);
			// 
			// btnSchreiben
			// 
			this.btnSchreiben.Location = new System.Drawing.Point(95, 12);
			this.btnSchreiben.Name = "btnSchreiben";
			this.btnSchreiben.Size = new System.Drawing.Size(75, 23);
			this.btnSchreiben.TabIndex = 1;
			this.btnSchreiben.Text = "Schreiben";
			this.btnSchreiben.UseVisualStyleBackColor = true;
			this.btnSchreiben.Click += new System.EventHandler(this.btnSchreiben_Click);
			// 
			// btnLöschen
			// 
			this.btnLöschen.Location = new System.Drawing.Point(177, 13);
			this.btnLöschen.Name = "btnLöschen";
			this.btnLöschen.Size = new System.Drawing.Size(75, 23);
			this.btnLöschen.TabIndex = 2;
			this.btnLöschen.Text = "Löschen";
			this.btnLöschen.UseVisualStyleBackColor = true;
			this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
			// 
			// txtEinUndAusgabe
			// 
			this.txtEinUndAusgabe.Location = new System.Drawing.Point(12, 42);
			this.txtEinUndAusgabe.Multiline = true;
			this.txtEinUndAusgabe.Name = "txtEinUndAusgabe";
			this.txtEinUndAusgabe.Size = new System.Drawing.Size(240, 197);
			this.txtEinUndAusgabe.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 260);
			this.Controls.Add(this.txtEinUndAusgabe);
			this.Controls.Add(this.btnLöschen);
			this.Controls.Add(this.btnSchreiben);
			this.Controls.Add(this.btnLesen);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLesen;
		private System.Windows.Forms.Button btnSchreiben;
		private System.Windows.Forms.Button btnLöschen;
		private System.Windows.Forms.TextBox txtEinUndAusgabe;
	}
}

