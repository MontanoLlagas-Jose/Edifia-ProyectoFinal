public class VisitaBE
{
    public int id { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string documento { get; set; }
    public short tipo_id { get; set; }
    public short? area_comun_id { get; set; }
    public DateTime? fecha_entrada { get; set; } 
    public TimeSpan? hora_entrada { get; set; } 
    public DateTime? fecha_salida { get; set; } 
    public TimeSpan? hora_salida { get; set; } 
    public DateTime Fec_reg { get; set; } 
    public string Usu_Registro { get; set; } 
    public string proposito { get; set; } 
    public DateTime Fec_Ult_Mod { get; set; } 
    public string Usu_Ult_Mod { get; set; } 
    public int departamento_id { get; set; } 
}
