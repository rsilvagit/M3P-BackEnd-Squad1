using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LabMedicineAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UnidadeEnum
    {
        mg = 1,
        mcg = 2,
        g = 3,
        mL = 4,
        Porcentagem = 5

    }
}