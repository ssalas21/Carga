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
    
    public partial class Documento_Factura
    {
        public long Id_doc { get; set; }
        public string Placa { get; set; }
        public string Nombre_Documento { get; set; }
        public string URL { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string File_Size { get; set; }
        public string File_Type { get; set; }
        public long id_solicitud_Factura { get; set; }
    }
}