using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Cargar_Subdere.BLL;

namespace Cargar_Subdere {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            List<Subdere> listado = (new SubdereBLL()).GetSubderes();            
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\CargaSubdere\\script.sql"); // Abrir el txt            
            foreach (Subdere item in listado) {                
                string texto = "INSERT INTO Permisos_de_Circulacion (Placa, Digito, Rut, Año_del_Permiso, Fecha_Emision, Tipo_Vehiculo, Periodo, Clasificacion, Tasacion, Neto_Factura," +
                    "Valor_UTM, Comuna_Anterior, Año_Anterior, Forma_de_Pago, Numero_Boletin, Numero_Caja, Valor_Permiso, Valor_IPC, Valor_Multa, Total_a_Pagar, Estado_del_Pago," +
                    "Fondos_a_Terceros, Valor_Contado, Valor_Cuota, Fecha_Vencimiento, Observaciones, Correccion_Monetaria, Porcentaje_Correccion, Monto_Correccion, Fecha_Pago, Usuario, " +
                    "Municipalidad, Derechos_Varios) VALUES (";
                texto = texto + "'" + item.Patente.ToString() + "'";
                texto = texto + ",";
                texto = texto + "'" + item.DigitoVerificadorPatente.ToString() + "'";
                texto = texto + ",";
                string rut = item.Rut.Replace(".", "");
                if (rut.Length < 11) {
                    do {
                        rut = "0" + rut;
                    } while (rut.Length < 11);
                }
                texto = texto + "'" + rut + "'";
                texto = texto + ",";
                texto = texto + item.FechaVencimiento.Value.Year.ToString();
                texto = texto + ",";
                texto = texto + "'" + item.FechaPago.Value.ToString() + "'";
                texto = texto + ",";
                texto = texto + "'" + (new PermisosBLL()).GetType(item.TipoVehiculo.ToString()) + "'";
                texto = texto + ",1,1,";
                texto = texto + "'" + item.Tasacion.ToString() + "'";
                texto = texto + ",0,50978,220,2020,";
                if (item.Cuota.Equals("T")) texto = texto + "'0'";
                if (item.Cuota.Equals("1"))texto = texto + "'1'";
                if (item.Cuota.Equals("2")) texto = texto + "'2'";
                texto = texto + ",";
                texto = texto + "'" + item.NumeroSerie.ToString() + "'";
                texto = texto + ",1,";
                texto = texto + "'" + item.MontoOriginal.Value + "'";
                texto = texto + ",";
                texto = texto + "'" + item.MontoReajuste.Value + "'";
                texto = texto + ",";
                texto = texto + "'" + item.MontoInteres.Value + "'";
                texto = texto + ",";
                texto = texto + "'" + item.MontoPagar.Value + "'";
                texto = texto + ",0,0,";
                texto = texto + "'" + item.MontoOriginal.Value + "'";
                texto = texto + ",";
                texto = texto + "'" + item.MontoCuota.Value + "'";
                texto = texto + ",";
                texto = texto + "'" + item.FechaVencimiento.Value.AddYears(1).ToString() + "'";
                texto = texto + ",";
                texto = texto + "'PAGADO POR SUBDERE',0,0,0";
                texto = texto + ",";
                texto = texto + "'" + item.FechaPago.Value.ToString() + "'";
                texto = texto + ",";
                texto = texto + "'SSALAS','PUCHUNCAVI','NULL'";                
                texto = texto + ");";
                file.WriteLine(texto);                
            }
            file.Close();
            MessageBox.Show("Revisar en D:\\CargaSubdere\\script.sql");
        }
    }
}
