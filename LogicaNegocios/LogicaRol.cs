using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class LogicaRol
    {
        private static CD_HelpDeskDataContext dc { get; set; }

        public static List<TBL_ROL> getAllRoles()
        {
            try
            {
                dc = new CD_HelpDeskDataContext();
                var lista = dc.TBL_ROL.Where(data => data.rol_status == 'A');
                return lista.ToList();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los Roles " + ex.Message);
            }
        }

        public static TBL_ROL getRolXId(int idRol)
        {
            try
            {
                dc = new CD_HelpDeskDataContext();
                var rol = dc.TBL_ROL.FirstOrDefault(data => data.rol_status == 'A'
                                                    && data.rol_id.Equals(idRol));
                return rol;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los Roles " + ex.Message);
            }
        }

        public static bool saveRol(TBL_ROL _infoRol)
        {
            try
            {
                dc = new CD_HelpDeskDataContext();
                bool resul = false;

                dc.TBL_ROL.InsertOnSubmit(_infoRol);
                //Actualizar el contexto de datos
                dc.SubmitChanges();
                resul = true;
                return resul;

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los Roles " + ex.Message);
            }
        }

        public static bool updateUser(TBL_ROL _infoRol)
        {
            try
            {
                bool resul = false;
                //Actualizar el contexto de datos
                dc.SubmitChanges();
                resul = true;
                return resul;

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los Roles " + ex.Message);
            }
        }

        public static bool deleteRol(TBL_ROL _infoRol)
        {
            try
            {
                bool resul = false;
                _infoRol.rol_status = 'I';
                //Actualizar el contexto de datos
                dc.SubmitChanges();
                resul = true;
                return resul;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Errorr al consultar los Roles " + ex.Message);
            }
        }
    }
}
