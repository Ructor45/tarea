﻿using System;

namespace tarea.Models
{
    public class Cliente
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public bool EsEmpresa { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int CantidadFacturas { get; set; }
        public int NumeroUltimaFactura { get; set; }
        public int MontoUltimaFactura { get; set; }
    }
}
