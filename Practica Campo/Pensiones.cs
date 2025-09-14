using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Campo {
  public partial class Pensiones : Form {

    public Pensiones() {
      InitializeComponent();
      this.Load += new EventHandler(Pensiones_Load);
    }

    private void Pensiones_Load(object sender, EventArgs e) {
      // Limpiar antes de cargar
      cmBox_nota.Items.Clear();
      cmBox_categoria.Items.Clear();

      // Notas del 0 al 20
      for(int i = 0; i <= 20; i++) {
        cmBox_nota.Items.Add(i);
      }
      cmBox_nota.SelectedIndex = 0;

      // Categorías
      cmBox_categoria.Items.Add("A");
      cmBox_categoria.Items.Add("B");
      cmBox_categoria.Items.Add("C");
      cmBox_categoria.Items.Add("D");
      cmBox_categoria.SelectedIndex = 0;
    }

    private void btn_calcular_Click(object sender, EventArgs e) {
      // Pensiones por categoría
      double pension = 0;
      double pension_a = 550;
      double pension_b = 500;
      double pension_c = 460;
      double pension_d = 400;

      // Datos ingresados
      int promedio = Convert.ToInt32(cmBox_nota.SelectedItem);
      string categoria = cmBox_categoria.SelectedItem.ToString();

      // Asignar pensión base
      switch(categoria) {
        case "A":
          pension = pension_a;
          break;
        case "B":
          pension = pension_b;
          break;
        case "C":
          pension = pension_c;
          break;
        case "D":
          pension = pension_d;
          break;
        default:
          pension = 0;
          break;
      }

      // Calcular descuento según promedio
      double descuentoPorcentaje = 0;
      if(promedio >= 14 && promedio <= 15.99) {
        descuentoPorcentaje = 0.10; // 10%
      } else if(promedio >= 16 && promedio <= 17.99) {
        descuentoPorcentaje = 0.12; // 12%
      } else if(promedio >= 18 && promedio <= 20) {
        descuentoPorcentaje = 0.15; // 15%
      }

      // Cálculos finales
      double descuento = pension * descuentoPorcentaje;
      double nuevaPension = pension - descuento;
      double total = pension - descuento;

      // Mostrar en los TextBox del formulario
      txt_pension.Text = $"S/ {pension}";
      txt_promedio.Text = promedio.ToString("0");
      txt_descuento.Text = $"S/ {descuento:0.00}";
      txt_total.Text = $"S/ {total:0.00}";

    }
  
  }

}
