﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class usuarioDatos
    {

        public Entidad.Usuarios obtenerUsuarioDatos(string login)
        {

            Entidad.CursoNetEntities dc = null;
            Entidad.Usuarios usuario = null;

            try
            {

                dc = new Entidad.CursoNetEntities();
                usuario = dc.Usuarios.Where(u => u.login == login).FirstOrDefault();

                return usuario;

            }
            catch (Exception err)
            {

                throw err;
            }

        }

    }
}
