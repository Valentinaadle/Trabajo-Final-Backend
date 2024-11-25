namespace TrabajoFinal.Dtos
{
    public class ClaseDto
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Profesor { get; set; }  
        public DateTime Fecha { get; set; }
    }
}
