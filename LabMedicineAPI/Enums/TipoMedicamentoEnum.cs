using System.Text.Json.Serialization;

namespace LabMedicineAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TipoMedicamentoEnum
    {
        Capsula = 1,
        Comprimido = 2,
        Liquido = 3,
        Creme = 4,
        Gel = 5,
        Inalacao = 6,
        Injecao = 7,
        Spray = 8,
    }
}