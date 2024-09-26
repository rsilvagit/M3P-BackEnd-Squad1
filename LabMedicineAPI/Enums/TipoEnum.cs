using System.Text.Json.Serialization;

namespace LabMedicineAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TipoEnum
    {
        Medico = 1,
        Administrador = 2,
        Enfermeiro = 3
    }
}