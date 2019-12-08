using System;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class N_Usuario
    {
        CapaDatos.D_Usuario objdato = new CapaDatos.D_Usuario();
        public DataTable N_listado()
        {
            return objdato.D_listado();
        }
    }
}
 