namespace menucomida
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
            this.chbxArroz = new System.Windows.Forms.CheckBox();
            this.chbxTallarines = new System.Windows.Forms.CheckBox();
            this.chbxFideos = new System.Windows.Forms.CheckBox();
            this.chbxLechuga = new System.Windows.Forms.CheckBox();
            this.chbxMango = new System.Windows.Forms.CheckBox();
            this.chbxDurazno = new System.Windows.Forms.CheckBox();
            this.chbxTomate = new System.Windows.Forms.CheckBox();
            this.chbxChampinones = new System.Windows.Forms.CheckBox();
            this.chbxPollo = new System.Windows.Forms.CheckBox();
            this.chbxRolloprimavera = new System.Windows.Forms.CheckBox();
            this.chbxCerdo = new System.Windows.Forms.CheckBox();
            this.chbxSurimi = new System.Windows.Forms.CheckBox();
            this.chbxArandanos = new System.Windows.Forms.CheckBox();
            this.chbxAmaranto = new System.Windows.Forms.CheckBox();
            this.chbxCacahuate = new System.Windows.Forms.CheckBox();
            this.chbxSemillagirasol = new System.Windows.Forms.CheckBox();
            this.chbxAderezohke = new System.Windows.Forms.CheckBox();
            this.chbxAgridulce = new System.Windows.Forms.CheckBox();
            this.chbxSoya = new System.Windows.Forms.CheckBox();
            this.chbxAderMango = new System.Windows.Forms.CheckBox();
            this.avisoBase = new System.Windows.Forms.Label();
            this.avisoProteina = new System.Windows.Forms.Label();
            this.avisoAdereso = new System.Windows.Forms.Label();
            this.avisoTopping = new System.Windows.Forms.Label();
            this.avisoCrujientes = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base a elegir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Topping";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crujiente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proteina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aderesos";
            // 
            // chbxArroz
            // 
            this.chbxArroz.AutoSize = true;
            this.chbxArroz.Location = new System.Drawing.Point(57, 73);
            this.chbxArroz.Name = "chbxArroz";
            this.chbxArroz.Size = new System.Drawing.Size(50, 17);
            this.chbxArroz.TabIndex = 5;
            this.chbxArroz.Text = "Arroz";
            this.chbxArroz.UseVisualStyleBackColor = true;
            this.chbxArroz.CheckedChanged += new System.EventHandler(this.chbxArroz_CheckedChanged);
            // 
            // chbxTallarines
            // 
            this.chbxTallarines.AutoSize = true;
            this.chbxTallarines.Location = new System.Drawing.Point(57, 96);
            this.chbxTallarines.Name = "chbxTallarines";
            this.chbxTallarines.Size = new System.Drawing.Size(71, 17);
            this.chbxTallarines.TabIndex = 6;
            this.chbxTallarines.Text = "Tallarines";
            this.chbxTallarines.UseVisualStyleBackColor = true;
            this.chbxTallarines.CheckedChanged += new System.EventHandler(this.chbxTallarines_CheckedChanged);
            // 
            // chbxFideos
            // 
            this.chbxFideos.AutoSize = true;
            this.chbxFideos.Location = new System.Drawing.Point(57, 119);
            this.chbxFideos.Name = "chbxFideos";
            this.chbxFideos.Size = new System.Drawing.Size(57, 17);
            this.chbxFideos.TabIndex = 7;
            this.chbxFideos.Text = "Fideos";
            this.chbxFideos.UseVisualStyleBackColor = true;
            this.chbxFideos.CheckedChanged += new System.EventHandler(this.chbxFideos_CheckedChanged);
            // 
            // chbxLechuga
            // 
            this.chbxLechuga.AutoSize = true;
            this.chbxLechuga.Location = new System.Drawing.Point(54, 142);
            this.chbxLechuga.Name = "chbxLechuga";
            this.chbxLechuga.Size = new System.Drawing.Size(68, 17);
            this.chbxLechuga.TabIndex = 8;
            this.chbxLechuga.Text = "Lechuga";
            this.chbxLechuga.UseVisualStyleBackColor = true;
            this.chbxLechuga.CheckedChanged += new System.EventHandler(this.chbxLechuga_CheckedChanged);
            // 
            // chbxMango
            // 
            this.chbxMango.AutoSize = true;
            this.chbxMango.Location = new System.Drawing.Point(48, 276);
            this.chbxMango.Name = "chbxMango";
            this.chbxMango.Size = new System.Drawing.Size(59, 17);
            this.chbxMango.TabIndex = 9;
            this.chbxMango.Text = "Mango";
            this.chbxMango.UseVisualStyleBackColor = true;
            this.chbxMango.CheckedChanged += new System.EventHandler(this.chbxMango_CheckedChanged);
            // 
            // chbxDurazno
            // 
            this.chbxDurazno.AutoSize = true;
            this.chbxDurazno.Location = new System.Drawing.Point(48, 299);
            this.chbxDurazno.Name = "chbxDurazno";
            this.chbxDurazno.Size = new System.Drawing.Size(66, 17);
            this.chbxDurazno.TabIndex = 10;
            this.chbxDurazno.Text = "Durazno";
            this.chbxDurazno.UseVisualStyleBackColor = true;
            this.chbxDurazno.CheckedChanged += new System.EventHandler(this.chbxDurazno_CheckedChanged);
            // 
            // chbxTomate
            // 
            this.chbxTomate.AutoSize = true;
            this.chbxTomate.Location = new System.Drawing.Point(48, 322);
            this.chbxTomate.Name = "chbxTomate";
            this.chbxTomate.Size = new System.Drawing.Size(62, 17);
            this.chbxTomate.TabIndex = 11;
            this.chbxTomate.Text = "Tomate";
            this.chbxTomate.UseVisualStyleBackColor = true;
            this.chbxTomate.CheckedChanged += new System.EventHandler(this.chbxTomate_CheckedChanged);
            // 
            // chbxChampinones
            // 
            this.chbxChampinones.AutoSize = true;
            this.chbxChampinones.Location = new System.Drawing.Point(48, 345);
            this.chbxChampinones.Name = "chbxChampinones";
            this.chbxChampinones.Size = new System.Drawing.Size(89, 17);
            this.chbxChampinones.TabIndex = 12;
            this.chbxChampinones.Text = "champiñones";
            this.chbxChampinones.UseVisualStyleBackColor = true;
            this.chbxChampinones.CheckedChanged += new System.EventHandler(this.chbxChampinones_CheckedChanged);
            // 
            // chbxPollo
            // 
            this.chbxPollo.AutoSize = true;
            this.chbxPollo.Location = new System.Drawing.Point(250, 73);
            this.chbxPollo.Name = "chbxPollo";
            this.chbxPollo.Size = new System.Drawing.Size(49, 17);
            this.chbxPollo.TabIndex = 13;
            this.chbxPollo.Text = "Pollo";
            this.chbxPollo.UseVisualStyleBackColor = true;
            this.chbxPollo.CheckedChanged += new System.EventHandler(this.chbxPollo_CheckedChanged);
            // 
            // chbxRolloprimavera
            // 
            this.chbxRolloprimavera.AutoSize = true;
            this.chbxRolloprimavera.Location = new System.Drawing.Point(250, 119);
            this.chbxRolloprimavera.Name = "chbxRolloprimavera";
            this.chbxRolloprimavera.Size = new System.Drawing.Size(100, 17);
            this.chbxRolloprimavera.TabIndex = 14;
            this.chbxRolloprimavera.Text = "Rollo Primavera";
            this.chbxRolloprimavera.UseVisualStyleBackColor = true;
            this.chbxRolloprimavera.CheckedChanged += new System.EventHandler(this.chbxRolloPrimavera_CheckedChanged);
            // 
            // chbxCerdo
            // 
            this.chbxCerdo.AutoSize = true;
            this.chbxCerdo.Location = new System.Drawing.Point(250, 96);
            this.chbxCerdo.Name = "chbxCerdo";
            this.chbxCerdo.Size = new System.Drawing.Size(54, 17);
            this.chbxCerdo.TabIndex = 15;
            this.chbxCerdo.Text = "Cerdo";
            this.chbxCerdo.UseVisualStyleBackColor = true;
            this.chbxCerdo.CheckedChanged += new System.EventHandler(this.chbxCerdo_CheckedChanged);
            // 
            // chbxSurimi
            // 
            this.chbxSurimi.AutoSize = true;
            this.chbxSurimi.Location = new System.Drawing.Point(250, 142);
            this.chbxSurimi.Name = "chbxSurimi";
            this.chbxSurimi.Size = new System.Drawing.Size(54, 17);
            this.chbxSurimi.TabIndex = 16;
            this.chbxSurimi.Text = "Surimi";
            this.chbxSurimi.UseVisualStyleBackColor = true;
            this.chbxSurimi.CheckedChanged += new System.EventHandler(this.chbxSurimi_CheckedChanged);
            // 
            // chbxArandanos
            // 
            this.chbxArandanos.AutoSize = true;
            this.chbxArandanos.Location = new System.Drawing.Point(239, 286);
            this.chbxArandanos.Name = "chbxArandanos";
            this.chbxArandanos.Size = new System.Drawing.Size(77, 17);
            this.chbxArandanos.TabIndex = 17;
            this.chbxArandanos.Text = "Arandanos";
            this.chbxArandanos.UseVisualStyleBackColor = true;
            this.chbxArandanos.CheckedChanged += new System.EventHandler(this.chbxArandanos_CheckedChanged);
            // 
            // chbxAmaranto
            // 
            this.chbxAmaranto.AutoSize = true;
            this.chbxAmaranto.Location = new System.Drawing.Point(239, 309);
            this.chbxAmaranto.Name = "chbxAmaranto";
            this.chbxAmaranto.Size = new System.Drawing.Size(71, 17);
            this.chbxAmaranto.TabIndex = 18;
            this.chbxAmaranto.Text = "Amaranto";
            this.chbxAmaranto.UseVisualStyleBackColor = true;
            this.chbxAmaranto.CheckedChanged += new System.EventHandler(this.chbxAmaranto_CheckedChanged);
            // 
            // chbxCacahuate
            // 
            this.chbxCacahuate.AutoSize = true;
            this.chbxCacahuate.Location = new System.Drawing.Point(238, 332);
            this.chbxCacahuate.Name = "chbxCacahuate";
            this.chbxCacahuate.Size = new System.Drawing.Size(78, 17);
            this.chbxCacahuate.TabIndex = 19;
            this.chbxCacahuate.Text = "Cacahuate";
            this.chbxCacahuate.UseVisualStyleBackColor = true;
            this.chbxCacahuate.CheckedChanged += new System.EventHandler(this.chbxCacahuate_CheckedChanged);
            // 
            // chbxSemillagirasol
            // 
            this.chbxSemillagirasol.AutoSize = true;
            this.chbxSemillagirasol.Location = new System.Drawing.Point(239, 355);
            this.chbxSemillagirasol.Name = "chbxSemillagirasol";
            this.chbxSemillagirasol.Size = new System.Drawing.Size(111, 17);
            this.chbxSemillagirasol.TabIndex = 20;
            this.chbxSemillagirasol.Text = "Semilla De Girasol";
            this.chbxSemillagirasol.UseVisualStyleBackColor = true;
            this.chbxSemillagirasol.CheckedChanged += new System.EventHandler(this.chbxSemillagirasol_CheckedChanged);
            // 
            // chbxAderezohke
            // 
            this.chbxAderezohke.AutoSize = true;
            this.chbxAderezohke.Location = new System.Drawing.Point(426, 73);
            this.chbxAderezohke.Name = "chbxAderezohke";
            this.chbxAderezohke.Size = new System.Drawing.Size(90, 17);
            this.chbxAderezohke.TabIndex = 21;
            this.chbxAderezohke.Text = "Aderezo HKE";
            this.chbxAderezohke.UseVisualStyleBackColor = true;
            this.chbxAderezohke.CheckedChanged += new System.EventHandler(this.aderezohke_CheckedChanged);
            // 
            // chbxAgridulce
            // 
            this.chbxAgridulce.AutoSize = true;
            this.chbxAgridulce.Location = new System.Drawing.Point(426, 96);
            this.chbxAgridulce.Name = "chbxAgridulce";
            this.chbxAgridulce.Size = new System.Drawing.Size(70, 17);
            this.chbxAgridulce.TabIndex = 22;
            this.chbxAgridulce.Text = "Agridulce";
            this.chbxAgridulce.UseVisualStyleBackColor = true;
            this.chbxAgridulce.CheckedChanged += new System.EventHandler(this.chbxAgridulce_CheckedChanged);
            // 
            // chbxSoya
            // 
            this.chbxSoya.AutoSize = true;
            this.chbxSoya.Location = new System.Drawing.Point(426, 119);
            this.chbxSoya.Name = "chbxSoya";
            this.chbxSoya.Size = new System.Drawing.Size(50, 17);
            this.chbxSoya.TabIndex = 23;
            this.chbxSoya.Text = "Soya";
            this.chbxSoya.UseVisualStyleBackColor = true;
            this.chbxSoya.CheckedChanged += new System.EventHandler(this.chbxSoya_CheckedChanged);
            // 
            // chbxAderMango
            // 
            this.chbxAderMango.AutoSize = true;
            this.chbxAderMango.Location = new System.Drawing.Point(426, 142);
            this.chbxAderMango.Name = "chbxAderMango";
            this.chbxAderMango.Size = new System.Drawing.Size(59, 17);
            this.chbxAderMango.TabIndex = 24;
            this.chbxAderMango.Text = "Mango";
            this.chbxAderMango.UseVisualStyleBackColor = true;
            this.chbxAderMango.CheckedChanged += new System.EventHandler(this.chbxAderMango_CheckedChanged);
            // 
            // avisoBase
            // 
            this.avisoBase.AutoSize = true;
            this.avisoBase.Location = new System.Drawing.Point(51, 172);
            this.avisoBase.Name = "avisoBase";
            this.avisoBase.Size = new System.Drawing.Size(16, 13);
            this.avisoBase.TabIndex = 25;
            this.avisoBase.Text = "---";
            // 
            // avisoProteina
            // 
            this.avisoProteina.AutoSize = true;
            this.avisoProteina.Location = new System.Drawing.Point(247, 172);
            this.avisoProteina.Name = "avisoProteina";
            this.avisoProteina.Size = new System.Drawing.Size(16, 13);
            this.avisoProteina.TabIndex = 26;
            this.avisoProteina.Text = "---";
            // 
            // avisoAdereso
            // 
            this.avisoAdereso.AutoSize = true;
            this.avisoAdereso.Location = new System.Drawing.Point(423, 172);
            this.avisoAdereso.Name = "avisoAdereso";
            this.avisoAdereso.Size = new System.Drawing.Size(16, 13);
            this.avisoAdereso.TabIndex = 27;
            this.avisoAdereso.Text = "---";
            // 
            // avisoTopping
            // 
            this.avisoTopping.AutoSize = true;
            this.avisoTopping.Location = new System.Drawing.Point(42, 382);
            this.avisoTopping.Name = "avisoTopping";
            this.avisoTopping.Size = new System.Drawing.Size(16, 13);
            this.avisoTopping.TabIndex = 28;
            this.avisoTopping.Text = "---";
            // 
            // avisoCrujientes
            // 
            this.avisoCrujientes.AutoSize = true;
            this.avisoCrujientes.Location = new System.Drawing.Point(236, 392);
            this.avisoCrujientes.Name = "avisoCrujientes";
            this.avisoCrujientes.Size = new System.Drawing.Size(16, 13);
            this.avisoCrujientes.TabIndex = 29;
            this.avisoCrujientes.Text = "---";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOrdenar.Location = new System.Drawing.Point(366, 292);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(221, 63);
            this.btnOrdenar.TabIndex = 30;
            this.btnOrdenar.Text = "ORDENAR";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 415);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.avisoCrujientes);
            this.Controls.Add(this.avisoTopping);
            this.Controls.Add(this.avisoAdereso);
            this.Controls.Add(this.avisoProteina);
            this.Controls.Add(this.avisoBase);
            this.Controls.Add(this.chbxAderMango);
            this.Controls.Add(this.chbxSoya);
            this.Controls.Add(this.chbxAgridulce);
            this.Controls.Add(this.chbxAderezohke);
            this.Controls.Add(this.chbxSemillagirasol);
            this.Controls.Add(this.chbxCacahuate);
            this.Controls.Add(this.chbxAmaranto);
            this.Controls.Add(this.chbxArandanos);
            this.Controls.Add(this.chbxSurimi);
            this.Controls.Add(this.chbxCerdo);
            this.Controls.Add(this.chbxRolloprimavera);
            this.Controls.Add(this.chbxPollo);
            this.Controls.Add(this.chbxChampinones);
            this.Controls.Add(this.chbxTomate);
            this.Controls.Add(this.chbxDurazno);
            this.Controls.Add(this.chbxMango);
            this.Controls.Add(this.chbxLechuga);
            this.Controls.Add(this.chbxFideos);
            this.Controls.Add(this.chbxTallarines);
            this.Controls.Add(this.chbxArroz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.CheckBox chbxArroz;
        private System.Windows.Forms.CheckBox chbxTallarines;
        private System.Windows.Forms.CheckBox chbxFideos;
        private System.Windows.Forms.CheckBox chbxLechuga;
        private System.Windows.Forms.CheckBox chbxMango;
        private System.Windows.Forms.CheckBox chbxDurazno;
        private System.Windows.Forms.CheckBox chbxTomate;
        private System.Windows.Forms.CheckBox chbxChampinones;
        private System.Windows.Forms.CheckBox chbxPollo;
        private System.Windows.Forms.CheckBox chbxRolloprimavera;
        private System.Windows.Forms.CheckBox chbxCerdo;
        private System.Windows.Forms.CheckBox chbxSurimi;
        private System.Windows.Forms.CheckBox chbxArandanos;
        private System.Windows.Forms.CheckBox chbxAmaranto;
        private System.Windows.Forms.CheckBox chbxCacahuate;
        private System.Windows.Forms.CheckBox chbxSemillagirasol;
        private System.Windows.Forms.CheckBox chbxAderezohke;
        private System.Windows.Forms.CheckBox chbxAgridulce;
        private System.Windows.Forms.CheckBox chbxSoya;
        private System.Windows.Forms.CheckBox chbxAderMango;
        private System.Windows.Forms.Label avisoBase;
        private System.Windows.Forms.Label avisoProteina;
        private System.Windows.Forms.Label avisoAdereso;
        private System.Windows.Forms.Label avisoTopping;
        private System.Windows.Forms.Label avisoCrujientes;
        private System.Windows.Forms.Button btnOrdenar;
    }
}

