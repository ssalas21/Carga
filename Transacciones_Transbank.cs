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
    
    public partial class Transacciones_Transbank
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public int Id_Pedido { get; set; }
        public Nullable<short> Numero_de_Pagos { get; set; }
        public Nullable<short> Estado { get; set; }
        public string TBK_ORDEN_COMPRA { get; set; }
        public string TBK_TIPO_TRANSACCION { get; set; }
        public string TBK_ID_SESION { get; set; }
        public string TBK_ID_TRANSACCION { get; set; }
        public string TBK_CODIGO_AUTORIZACION { get; set; }
        public string TBK_RESPUESTA { get; set; }
        public string TBK_MONTO { get; set; }
        public string TBK_NUMERO_TARJETA { get; set; }
        public string TBK_FECHA_EXPIRACION { get; set; }
        public string TBK_FECHA_CONTABLE { get; set; }
        public string TBK_FECHA_TRANSACCION { get; set; }
        public string TBK_HORA_TRANSACCION { get; set; }
        public string TBK_COD_AUT_M001 { get; set; }
        public string TBK_TIPO_PAGO_M001 { get; set; }
        public string TBK_NUMERO_CUOTAS_M001 { get; set; }
        public string TBK_COD_RESP_M001 { get; set; }
        public string TBK_MONTO_TIENDA_M001 { get; set; }
        public string TBK_ORDEN_TIENDA_M001 { get; set; }
        public string TBK_COD_AUT_M002 { get; set; }
        public string TBK_TIPO_PAGO_M002 { get; set; }
        public string TBK_NUMERO_CUOTAS_M002 { get; set; }
        public string TBK_COD_RESP_M002 { get; set; }
        public string TBK_MONTO_TIENDA_M002 { get; set; }
        public string TBK_ORDEN_TIENDA_M002 { get; set; }
        public string TBK_MAC { get; set; }
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
        public string HOMOLOGADO { get; set; }
        public string REVTEC_WS_MTT { get; set; }
        public string SEGURO_ONLINE_WS_AACH { get; set; }
        public string COMPRA_SEGURO_ONLINE { get; set; }
        public string ID_HOMOLOGADO { get; set; }
        public string ID_MTT_REVTEC { get; set; }
        public string ID_MTT_REVGAS { get; set; }
        public string URL { get; set; }
        public Nullable<int> Folio_Permiso { get; set; }
        public Nullable<int> Forma_de_Pago { get; set; }
        public Nullable<int> CS_CodigoCiaSeguro { get; set; }
        public Nullable<int> Anno { get; set; }
        public string Ruta_Log_Permiso { get; set; }
        public string Ruta_Log_Multa { get; set; }
        public Nullable<System.DateTime> Fecha_VencRevTec { get; set; }
        public Nullable<int> CobroAdicional { get; set; }
        public Nullable<short> movil { get; set; }
    }
}