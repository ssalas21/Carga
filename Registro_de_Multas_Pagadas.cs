//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cargar_Subdere
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registro_de_Multas_Pagadas
    {
        public string Placa { get; set; }
        public double ID_Multa { get; set; }
        public string JPL { get; set; }
        public string Comuna { get; set; }
        public string Rol { get; set; }
        public System.DateTime Fecha_Sentencia { get; set; }
        public double Monto_Multa { get; set; }
        public double Arancel { get; set; }
        public short Moneda { get; set; }
        public string Nombres { get; set; }
        public string Rut { get; set; }
        public string Direccion { get; set; }
        public string Motivo_Multa { get; set; }
        public System.DateTime Fecha_Ingreso { get; set; }
        public double Orden_Ingreso { get; set; }
        public Nullable<System.DateTime> Fecha_Pago { get; set; }
        public Nullable<byte> Estado_del_Pago { get; set; }
        public Nullable<int> Item_Pago_Original { get; set; }
        public Nullable<int> TAG { get; set; }
        public Nullable<int> Ano_Proceso_Ingreso { get; set; }
        public Nullable<short> Codigo_JPL { get; set; }
        public string JPL_SRCEI { get; set; }
        public Nullable<short> Codigo_Comuna { get; set; }
        public string Comuna_SRCEI { get; set; }
        public Nullable<short> Año_RolCausa { get; set; }
        public Nullable<System.DateTime> Fecha_Informe { get; set; }
        public Nullable<System.DateTime> Fecha_Registro { get; set; }
        public Nullable<int> Numero_Convenio { get; set; }
        public Nullable<short> Ano_Convenio { get; set; }
    }
}
