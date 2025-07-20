using Edifia_ADO;
using Edifia_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BL
{
    public class HabitanteBL
    {
        HabitanteADO objHabitanteADO = new HabitanteADO();

        public DataTable ListarHabitante()
        {
            return objHabitanteADO.ListarHabitantes();
        }
        public HabitanteBE ConsultarHabitante(int id)
        {
            return objHabitanteADO.ConsultarHabitante(id);
        }

        public ResultadoOperacion ActualizarHabitante(HabitanteBE objHabitanteBE)
        {
            if (objHabitanteBE.es_propietario)
            {
                int propietariosExistentes = objHabitanteADO.ContarPropietariosDepartamento(objHabitanteBE.departamento_id, objHabitanteBE.id);

                if (objHabitanteBE.es_propietario && propietariosExistentes >= 2)
                {
                    return ResultadoOperacion.Recuperable("Este departamento ya tiene 2 propietarios registrados. No se pueden asignar más.");
                }

            }

            bool ok = objHabitanteADO.ActualizarHabitante(objHabitanteBE);

            return ok
                ? ResultadoOperacion.Ok("Habitante actualizado correctamente.")
                : ResultadoOperacion.Critico("No se pudo actualizar el habitante.");
        }

        public Boolean EliminarHabitante(int idHabitante, DateTime fecUltMod, String usuUltMod)
        {
            return objHabitanteADO.EliminarHabitante(idHabitante, fecUltMod, usuUltMod);
        }

        public ResultadoOperacion InsertarHabitante(HabitanteBE objHabitanteBE, string usuario)
        {
            if (objHabitanteBE.es_propietario)
            {
                int propietariosExistentes = objHabitanteADO.ContarPropietariosDepartamento(objHabitanteBE.departamento_id, 0);  // 0 porque es nuevo

                if (objHabitanteBE.es_propietario && propietariosExistentes >= 2)
                {
                    return ResultadoOperacion.Recuperable("Este departamento ya tiene 2 propietarios registrados. No se pueden asignar más.");
                }

            }

            bool ok;

            try
            {
                ok = objHabitanteADO.InsertarHabitante(objHabitanteBE);  
            }
            catch (SqlException ex)
            {
                return ResultadoOperacion.Recuperable(
                    ex.Number == 2601
                    ? "El departamento ya tiene un propietario registrado."
                    : ex.Message);
            }

            if (ok)
            {
                string msg =
                    "Habitante registrado correctamente.\n\n" +
                    $"Nombre: {objHabitanteBE.nombre} {objHabitanteBE.apellido}\n" +
                    $"Departamento: {objHabitanteBE.departamento_id}\n" +
                    (objHabitanteBE.es_propietario ? "Rol: Propietario" : "Rol: Habitante");

                return ResultadoOperacion.Ok(msg);
            }
            else
            {
                return ResultadoOperacion.Recuperable("No se pudo registrar al habitante.");
            }
        }

        private void RegistrarError(string modulo, Exception ex, string usuario)
        {
            // Aquí puedes insertar directamente a tu tabla BitacoraErrores con SqlCommand,
            // o usar la clase que ya tengas para insertar logs de errores
            ConexionADO conexion = new ConexionADO();
            using SqlConnection cn = new SqlConnection(conexion.GetCnx());

            string query = @"INSERT INTO BitacoraErrores (Fecha, Modulo, Mensaje, StackTrace, Usuario)
                             VALUES (GETDATE(), @Modulo, @Mensaje, @StackTrace, @Usuario)";
            using SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@Modulo", modulo);
            cmd.Parameters.AddWithValue("@Mensaje", ex.Message);
            cmd.Parameters.AddWithValue("@StackTrace", ex.StackTrace ?? "");
            cmd.Parameters.AddWithValue("@Usuario", usuario);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public ResultadoOperacion CambiarDepartamento(int habitanteId, int nuevoDepartamentoId, string usuario)
        {
            // 1. Consultar habitante actual
            HabitanteBE habitante = objHabitanteADO.ConsultarHabitante(habitanteId);

            if (habitante == null)
            {
                return ResultadoOperacion.Critico("No se encontró al habitante.");
            }

            // 2. Si es propietario, validar que no haya otro propietario en el nuevo departamento
            int propietariosExistentes = objHabitanteADO.ContarPropietariosDepartamento(nuevoDepartamentoId, habitanteId);

            if (habitante.es_propietario && propietariosExistentes >= 2)
            {
                return ResultadoOperacion.Recuperable(
                    "El nuevo departamento ya tiene 2 propietarios registrados. " +
                    "No se puede asignar más.");
            }


            try
            {
                bool ok = objHabitanteADO.CambiarDepartamento(habitanteId, nuevoDepartamentoId, usuario);
                return ok
                    ? ResultadoOperacion.Ok("Departamento actualizado correctamente.")
                    : ResultadoOperacion.Critico("No se pudo cambiar el departamento.");
            }
            catch (Exception ex)
            {
                return ResultadoOperacion.Critico("Error al cambiar departamento: " + ex.Message);
            }
        }


        public DataTable ListarHabitantesReporteExcel()
        {
            try
            {
                // Llamamos al método de la capa ADO y obtenemos el DataTable
                return objHabitanteADO.ListarHabitantesReporteExcel();
            }
            catch (Exception ex)
            {
                // Manejo de la excepción y re-lanzamiento de la misma
                throw new Exception("Error al listar los habitantes para el reporte Excel: " + ex.Message);
            }
        }

    }

}
