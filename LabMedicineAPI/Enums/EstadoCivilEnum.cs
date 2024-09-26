using System.Text.Json.Serialization;

namespace LabMedicineAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EstadoCivilEnum
    {
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3,
        Viuvo = 4,
        Outro = 5
    }
}