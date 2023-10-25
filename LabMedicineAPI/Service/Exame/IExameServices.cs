﻿using LabMedicineAPI.DTOs;
using LabMedicineAPI.DTOs.Exame;
using LabMedicineAPI.Model;

namespace LabMedicineAPI.Service.Exame
{
    public interface IExameServices
    {
        bool DeleteExame(int id);
        ExameModel ExameCreateDTO(ExameCreateDTO exameCreateDTO);
        ExameModel exameUpdateDTO(int id, ExameUpdateDTO updateExameDTO);
        IEnumerable<ExameGetDTO> Get();
        IEnumerable<ExameGetDTO> Get(int? pacienteId);
        ExameGetDTO GetById(int id);
    }
}