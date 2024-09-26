using System.Text.Json.Serialization;

namespace LabMedicineAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TipoDietaEnum
    {
        LowCarb = 1,
        Dash = 2,
        Paleolitica = 3,
        Cetogenica = 4,
        Dukan = 5,
        Mediterranea = 6,
        Outra = 7
    }
}