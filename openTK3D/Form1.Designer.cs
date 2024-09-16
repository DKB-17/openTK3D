namespace openTK3D
{
    partial class OpenTK3D
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.glControl1 = new OpenTK.GLControl();
            this.glControl2 = new OpenTK.GLControl();
            this.EntradaLados = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EntradaAltura = new System.Windows.Forms.NumericUpDown();
            this.EntradaComprimento = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.ckBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaLados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaComprimento)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(12, 11);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(385, 491);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            this.glControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.glControl1_PreviewKeyDown);
            // 
            // glControl2
            // 
            this.glControl2.BackColor = System.Drawing.Color.Black;
            this.glControl2.Location = new System.Drawing.Point(403, 11);
            this.glControl2.Name = "glControl2";
            this.glControl2.Size = new System.Drawing.Size(385, 491);
            this.glControl2.TabIndex = 1;
            this.glControl2.VSync = false;
            this.glControl2.Load += new System.EventHandler(this.glControl2_Load);
            this.glControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl2_Paint);
            this.glControl2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            this.glControl2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.glControl1_PreviewKeyDown);
            // 
            // EntradaLados
            // 
            this.EntradaLados.Location = new System.Drawing.Point(794, 30);
            this.EntradaLados.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.EntradaLados.Name = "EntradaLados";
            this.EntradaLados.Size = new System.Drawing.Size(102, 20);
            this.EntradaLados.TabIndex = 2;
            this.EntradaLados.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.EntradaLados.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(794, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(794, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Altura";
            // 
            // EntradaAltura
            // 
            this.EntradaAltura.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EntradaAltura.Location = new System.Drawing.Point(794, 72);
            this.EntradaAltura.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EntradaAltura.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EntradaAltura.Name = "EntradaAltura";
            this.EntradaAltura.Size = new System.Drawing.Size(102, 20);
            this.EntradaAltura.TabIndex = 4;
            this.EntradaAltura.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // EntradaComprimento
            // 
            this.EntradaComprimento.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EntradaComprimento.Location = new System.Drawing.Point(794, 114);
            this.EntradaComprimento.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EntradaComprimento.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EntradaComprimento.Name = "EntradaComprimento";
            this.EntradaComprimento.Size = new System.Drawing.Size(102, 20);
            this.EntradaComprimento.TabIndex = 6;
            this.EntradaComprimento.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(797, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckBox
            // 
            this.ckBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ckBox.CheckOnClick = true;
            this.ckBox.FormattingEnabled = true;
            this.ckBox.Items.AddRange(new object[] {
            "Azul",
            "Cimento",
            "Ferro",
            "Grama",
            "Terra"});
            this.ckBox.Location = new System.Drawing.Point(797, 183);
            this.ckBox.Name = "ckBox";
            this.ckBox.Size = new System.Drawing.Size(99, 79);
            this.ckBox.Sorted = true;
            this.ckBox.TabIndex = 9;
            this.ckBox.Tag = "textura";
            this.ckBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Comprimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(794, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Textura";
            // 
            // OpenTK3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 515);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EntradaComprimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EntradaAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EntradaLados);
            this.Controls.Add(this.glControl2);
            this.Controls.Add(this.glControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OpenTK3D";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EntradaLados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaComprimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private OpenTK.GLControl glControl2;
        private System.Windows.Forms.NumericUpDown EntradaLados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown EntradaAltura;
        private System.Windows.Forms.NumericUpDown EntradaComprimento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox ckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

