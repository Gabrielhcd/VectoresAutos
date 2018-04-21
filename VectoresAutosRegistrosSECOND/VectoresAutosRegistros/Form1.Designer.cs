namespace VectoresAutosRegistros
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPosicion = new System.Windows.Forms.TextBox();
			this.txtRegistro = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Placa:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Marca:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tel:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Modelo:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Año:";
			// 
			// txtPlaca
			// 
			this.txtPlaca.Location = new System.Drawing.Point(90, 6);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(100, 27);
			this.txtPlaca.TabIndex = 5;
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(90, 40);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(100, 27);
			this.txtMarca.TabIndex = 6;
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(90, 75);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(100, 27);
			this.txtModelo.TabIndex = 7;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(90, 109);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(100, 27);
			this.txtTelefono.TabIndex = 8;
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(90, 143);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(100, 27);
			this.txtYear.TabIndex = 9;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(244, 6);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(106, 39);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Agregar";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(244, 51);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(106, 37);
			this.btnSearch.TabIndex = 11;
			this.btnSearch.Text = "Buscar";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(244, 94);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(106, 38);
			this.btnDel.TabIndex = 12;
			this.btnDel.Text = "Eliminar";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(244, 139);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(106, 38);
			this.btnList.TabIndex = 14;
			this.btnList.Text = "Lista";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(369, 157);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 20);
			this.label6.TabIndex = 15;
			this.label6.Text = "Posicion:";
			// 
			// txtPosicion
			// 
			this.txtPosicion.Location = new System.Drawing.Point(454, 154);
			this.txtPosicion.Name = "txtPosicion";
			this.txtPosicion.Size = new System.Drawing.Size(100, 27);
			this.txtPosicion.TabIndex = 16;
			// 
			// txtRegistro
			// 
			this.txtRegistro.Location = new System.Drawing.Point(13, 270);
			this.txtRegistro.Multiline = true;
			this.txtRegistro.Name = "txtRegistro";
			this.txtRegistro.Size = new System.Drawing.Size(542, 225);
			this.txtRegistro.TabIndex = 17;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 507);
			this.Controls.Add(this.txtRegistro);
			this.Controls.Add(this.txtPosicion);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.txtMarca);
			this.Controls.Add(this.txtPlaca);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPlaca;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPosicion;
		private System.Windows.Forms.TextBox txtRegistro;
	}
}

