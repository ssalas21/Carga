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
    
    public partial class Transacciones_TesoreriaGeneral
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public int Id_Pedido { get; set; }
        public Nullable<short> Estado { get; set; }
        public Nullable<int> TGR_VERSION_M1 { get; set; }
        public Nullable<int> TGR_REFADDRESS_M1 { get; set; }
        public Nullable<System.DateTime> TGR_DATETIME_M1 { get; set; }
        public Nullable<int> TGR_NUMBER_M1 { get; set; }
        public string TGR_IDEXT_M1 { get; set; }
        public string TGR_STATUS_M1 { get; set; }
        public Nullable<int> TGR_RUT_M1 { get; set; }
        public string TGR_DV_M1 { get; set; }
        public Nullable<int> TGR_FORMULARIO_M1 { get; set; }
        public Nullable<int> TGR_FOLIO_M1 { get; set; }
        public Nullable<System.DateTime> TGR_VENCIMIENTO_M1 { get; set; }
        public Nullable<int> TGR_MONEDA_M1 { get; set; }
        public Nullable<int> TGR_MONTO_M1 { get; set; }
        public string TGR_MOVIMIENTO_M1 { get; set; }
        public Nullable<int> TGR_VERSION_M2 { get; set; }
        public Nullable<int> TGR_REFADDRESS_M2 { get; set; }
        public Nullable<System.DateTime> TGR_DATETIME_M2 { get; set; }
        public Nullable<int> TGR_NUMBER_M2 { get; set; }
        public string TGR_IDEXT_M2 { get; set; }
        public string TGR_STATUS_M2 { get; set; }
        public Nullable<long> TGR_IDOPERACION_M2 { get; set; }
        public Nullable<long> TGR_IDTRANSACCION_M2 { get; set; }
        public Nullable<int> TGR_RUT_M2 { get; set; }
        public Nullable<int> TGR_FORMULARIO_M2 { get; set; }
        public Nullable<int> TGR_FOLIO_M2 { get; set; }
        public Nullable<System.DateTime> TGR_VENCIMIENTO_M2 { get; set; }
        public Nullable<int> TGR_TOTALPAGO_M2 { get; set; }
        public Nullable<int> TGR_CODIGO_M2 { get; set; }
        public string TGR_NOMBRE_M2 { get; set; }
        public Nullable<System.DateTime> TGR_FECHAPAGO_M2 { get; set; }
        public string TGR_TIPOPAGO_M2 { get; set; }
        public string RT_RazonSocial { get; set; }
        public string RT_NumeroCertificado { get; set; }
        public string CS_CiaSeguro { get; set; }
        public string CS_NumeroPoliza { get; set; }
        public Nullable<int> CS_ValorSeguro { get; set; }
        public string DL_NombreContacto { get; set; }
        public string DL_DireccionContacto { get; set; }
        public string DL_TelefonoContacto { get; set; }
        public string DL_DiasVisita { get; set; }
        public string DL_HorasVisita { get; set; }
        public string DL_MailContacto { get; set; }
        public string TGR_M2_completo { get; set; }
    }
}
