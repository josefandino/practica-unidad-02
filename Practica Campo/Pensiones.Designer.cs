namespace Practica_Campo {
  partial class Pensiones {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      label2 = new Label();
      label3 = new Label();
      btn_calcular = new Button();
      label6 = new Label();
      cmBox_nota = new ComboBox();
      cmBox_categoria = new ComboBox();
      label4 = new Label();
      label5 = new Label();
      txt_pension = new TextBox();
      txt_promedio = new TextBox();
      txt_descuento = new TextBox();
      txt_total = new TextBox();
      label7 = new Label();
      SuspendLayout();
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      label2.Location = new Point(137, 66);
      label2.Name = "label2";
      label2.Size = new Size(44, 21);
      label2.TabIndex = 3;
      label2.Text = "Nota";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      label3.Location = new Point(231, 242);
      label3.Name = "label3";
      label3.Size = new Size(64, 21);
      label3.TabIndex = 5;
      label3.Text = "Pensión";
      // 
      // btn_calcular
      // 
      btn_calcular.BackColor = Color.ForestGreen;
      btn_calcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_calcular.ForeColor = Color.FromArgb(  224,   224,   224);
      btn_calcular.Location = new Point(137, 149);
      btn_calcular.Name = "btn_calcular";
      btn_calcular.Size = new Size(378, 40);
      btn_calcular.TabIndex = 6;
      btn_calcular.Text = "Calcular";
      btn_calcular.UseVisualStyleBackColor = false;
      btn_calcular.Click += btn_calcular_Click;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      label6.Location = new Point(333, 66);
      label6.Name = "label6";
      label6.Size = new Size(77, 21);
      label6.TabIndex = 12;
      label6.Text = "Categoría";
      // 
      // cmBox_nota
      // 
      cmBox_nota.BackColor = Color.PaleGreen;
      cmBox_nota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      cmBox_nota.ForeColor = Color.FromArgb(  64,   64,   64);
      cmBox_nota.FormattingEnabled = true;
      cmBox_nota.Items.AddRange(new object[ ] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
      cmBox_nota.Location = new Point(142, 93);
      cmBox_nota.MaxLength = 20;
      cmBox_nota.Name = "cmBox_nota";
      cmBox_nota.Size = new Size(153, 29);
      cmBox_nota.TabIndex = 15;
      // 
      // cmBox_categoria
      // 
      cmBox_categoria.BackColor = Color.PaleGreen;
      cmBox_categoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      cmBox_categoria.ForeColor = Color.FromArgb(  64,   64,   64);
      cmBox_categoria.FormattingEnabled = true;
      cmBox_categoria.Items.AddRange(new object[ ] { "A", "B", "C", "D" });
      cmBox_categoria.Location = new Point(333, 93);
      cmBox_categoria.MaxLength = 20;
      cmBox_categoria.Name = "cmBox_categoria";
      cmBox_categoria.Size = new Size(182, 29);
      cmBox_categoria.TabIndex = 17;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      label4.Location = new Point(212, 330);
      label4.Name = "label4";
      label4.Size = new Size(83, 21);
      label4.TabIndex = 10;
      label4.Text = "Descuento";
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      label5.Location = new Point(137, 281);
      label5.Name = "label5";
      label5.Size = new Size(158, 21);
      label5.TabIndex = 8;
      label5.Text = "Promedio ponderado";
      // 
      // txt_pension
      // 
      txt_pension.BackColor = Color.PaleGreen;
      txt_pension.Location = new Point(301, 240);
      txt_pension.Name = "txt_pension";
      txt_pension.ReadOnly = true;
      txt_pension.Size = new Size(182, 23);
      txt_pension.TabIndex = 18;
      // 
      // txt_promedio
      // 
      txt_promedio.BackColor = Color.PaleGreen;
      txt_promedio.Location = new Point(301, 283);
      txt_promedio.Name = "txt_promedio";
      txt_promedio.ReadOnly = true;
      txt_promedio.Size = new Size(182, 23);
      txt_promedio.TabIndex = 7;
      // 
      // txt_descuento
      // 
      txt_descuento.BackColor = Color.PaleGreen;
      txt_descuento.Location = new Point(301, 330);
      txt_descuento.Name = "txt_descuento";
      txt_descuento.ReadOnly = true;
      txt_descuento.Size = new Size(182, 23);
      txt_descuento.TabIndex = 9;
      // 
      // txt_total
      // 
      txt_total.BackColor = Color.PaleGreen;
      txt_total.Location = new Point(301, 377);
      txt_total.Name = "txt_total";
      txt_total.ReadOnly = true;
      txt_total.Size = new Size(182, 23);
      txt_total.TabIndex = 19;
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      label7.Location = new Point(231, 379);
      label7.Name = "label7";
      label7.Size = new Size(42, 21);
      label7.TabIndex = 20;
      label7.Text = "Total";
      // 
      // Pensiones
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(  192,   255,   192);
      ClientSize = new Size(608, 611);
      Controls.Add(label7);
      Controls.Add(txt_total);
      Controls.Add(txt_pension);
      Controls.Add(cmBox_categoria);
      Controls.Add(cmBox_nota);
      Controls.Add(label6);
      Controls.Add(label4);
      Controls.Add(txt_descuento);
      Controls.Add(label5);
      Controls.Add(txt_promedio);
      Controls.Add(btn_calcular);
      Controls.Add(label3);
      Controls.Add(label2);
      Name = "Pensiones";
      Text = "Pensiones";
      Load += Pensiones_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Label label2;
    private Label label3;
    private Button btn_calcular;
    private Label label6;
    private ComboBox cmBox_nota;
    private ComboBox cmBox_categoria;
    private Label label4;
    private Label label5;
    private TextBox txt_pension;
    private TextBox txt_promedio;
    private TextBox txt_descuento;
    private TextBox txt_total;
    private Label label7;
  }
}