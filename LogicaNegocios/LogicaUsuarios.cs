using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaNegocios
{
    public class LogicaUsuarios
    {
        private static CD_HelpDeskDataContext dc { get; set; }


        public static List<TBL_USUARIO> getAllUsers()
        {
            try
            {
                dc = new CD_HelpDeskDataContext();
                var lista = dc.TBL_USUARIO.Where(data => data.usu_status == 'A');
                return lista.ToList();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }



        public static TBL_USUARIO getUsersXId(int idUsuario)
        {
            try
            {
                dc = new CD_HelpDeskDataContext();
                var usuario = dc.TBL_USUARIO.FirstOrDefault(data => data.usu_status == 'A'
                                                            && data.usu_id.Equals(idUsuario));
                return usuario;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }

        public static List<TBL_USUARIO> getUsersXApellidos(string apellidos)
        {
            try
            {
                dc = new CD_HelpDeskDataContext();
                var usuarios = dc.TBL_USUARIO.Where(data => data.usu_status == 'A'
                                                            && data.usu_apellidos.StartsWith(apellidos)).
                                                            OrderBy(data=>data.usu_id).
                                                            ThenBy(data=>data.usu_correo);
                return usuarios.ToList();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }

        public static List<TBL_USUARIO> getUsersXNombres(string nombres)
        {
            try
            {
                dc = new CD_HelpDeskDataContext();
                var usuarios = dc.TBL_USUARIO.Where(data => data.usu_status == 'A'
                                                            && data.usu_nombres.StartsWith(nombres)).
                                                            OrderBy(data => data.usu_id).
                                                            ThenBy(data => data.usu_correo);
                return usuarios.ToList();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }

        public static List<TBL_USUARIO> getUsersXCorreo(string correo)
        {
            try
            {
                dc = new CD_HelpDeskDataContext();
                var usuarios = dc.TBL_USUARIO.Where(data => data.usu_status == 'A'
                                                            && data.usu_correo.StartsWith(correo)).
                                                            OrderBy(data => data.usu_id).
                                                            ThenBy(data => data.usu_correo);
                return usuarios.ToList();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }

        public static List<TBL_USUARIO> getUsersXRol(string rol)
        {
            try
            {
                dc = new CD_HelpDeskDataContext();
                var usuarios = dc.TBL_USUARIO.Where(data => data.usu_status == 'A'
                                                            && data.TBL_ROL.rol_descripcion.StartsWith(rol)).
                                                            OrderBy(data => data.usu_id).
                                                            ThenBy(data => data.usu_correo);
                return usuarios.ToList();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }


        public static TBL_USUARIO getUsersxLogin(string email, string password)
        {
            try
            {
                dc = new CD_HelpDeskDataContext();
                var usuario = dc.TBL_USUARIO.FirstOrDefault(data => data.usu_status == 'A'
                                                            && data.usu_correo.Equals(email)
                                                            && data.usu_password.Equals(password));
                return usuario;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }

        public static bool saveUser(TBL_USUARIO _infoUsuario)
        {
            try
            {
                dc = new CD_HelpDeskDataContext();
                bool resul = false;
                _infoUsuario.usu_status = 'A';
                _infoUsuario.usu_add = DateTime.Now;
                //Insertar en la base de datos
                dc.TBL_USUARIO.InsertOnSubmit(_infoUsuario);
                //Actualizar el contexto de datos
                dc.SubmitChanges();
                resul = true;
                return resul;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }

        public static bool updateUser1(TBL_USUARIO _infoUsuario)
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
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }

        public static bool updateUser3(TBL_USUARIO _infoUsuario)
        {
            try
            {
                bool resul = false;
                //Actualizar el contexto de datos
                var result =dc.spModificarUsuario(_infoUsuario.usu_id, _infoUsuario.usu_correo, _infoUsuario.usu_password, _infoUsuario.usu_apellidos,_infoUsuario.usu_nombres, _infoUsuario.rol_id);
                
                dc.SubmitChanges();
                resul = true;
                return resul;

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }

        public static bool updateUserPassword(TBL_USUARIO _infoUsuario)
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
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }

        public static bool updateUser2(TBL_USUARIO _infoUsuario)
        {
            try
            {
                bool resul = false;
                dc = new CD_HelpDeskDataContext();
                _infoUsuario.usu_add = DateTime.Now;

                dc.ExecuteCommand("UPDATE [dbo].[TBL_USUARIO] " +
                "SET [usu_correo] = {0} " +
                " ,[usu_password] = {1} " +
                ",[usu_apellidos] = {2} " +
                ",[usu_nombres] = {3} " +
                ",[usu_add] = {4} " +
                ",[rol_id] = {5} " +
                "WHERE [usu_id]={6} ", new object[]
                { 
                  _infoUsuario.usu_correo,
                  _infoUsuario.usu_password,
                  _infoUsuario.usu_apellidos,
                  _infoUsuario.usu_nombres,
                  _infoUsuario.usu_add,
                  _infoUsuario.rol_id,
                  _infoUsuario.usu_id
                });

               
                //envia el comando dml al contexto
                dc.Refresh(RefreshMode.OverwriteCurrentValues, dc.TBL_USUARIO);
               
                resul = true;
                return resul;

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }

        public static bool deleteUser(TBL_USUARIO _infoUsuario)
        {
            try
            {
                bool resul = false;
                _infoUsuario.usu_status = 'I';
                _infoUsuario.usu_add = DateTime.Now;
                //Actualizar el contexto de datos
                dc.SubmitChanges();
                resul = true;
                return resul;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Errorr al consultar los usuarios " + ex.Message);
            }
        }

        public static bool validarCorreo(string correo)
        {
            bool resultado = false;
            //Validacion
            //Correo
            resultado = true;
            return resultado;

        }




    }
}
