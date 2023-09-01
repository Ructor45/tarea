using System;
using System.Collections.Generic;
using tarea.Models;

namespace tarea.Controllers
{
    public class ClienteController
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }
    }
}
