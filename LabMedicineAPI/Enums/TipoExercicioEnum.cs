using System.Text.Json.Serialization;

namespace LabMedicineAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TipoExercicioEnum
    {
        ResistenciaAerobica = 1,
        ResistenciaMuscular = 2,
        Flexibilidade = 3,
        Forca = 4,
        Agilidade = 5,
        Outro = 6
    }
}