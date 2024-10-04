namespace Sesion14
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(38, 66);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 16);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Edad:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(38, 106);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(39, 16);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Text = "Nota:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(38, 149);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 16);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Genero:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(116, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(116, 100);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(100, 22);
            this.tbGrade.TabIndex = 6;
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(116, 143);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(100, 22);
            this.tbGender.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 66);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 16;
            this.lbResults.Location = new System.Drawing.Point(460, 38);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(315, 244);
            this.lbResults.TabIndex = 9;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(116, 66);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 22);
            this.tbAge.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.TextBox tbAge;
    }
}

