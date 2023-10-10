using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LabMedicineAPI.DTOs;
using LabMedicineAPI.Model;

namespace LabMedicineAPI.AutoMapper
{
    public class ConfigurationMapper : Profile
    {
        protected ConfigurationMapper()
        {
            // ConfigurationMapper Usuario

            // Origem ... Destino
            CreateMap<UsuarioCreateDTO, UsuarioModel>();
            
            CreateMap<UsuarioGetDTO, UsuarioModel>();

            CreateMap<UsuarioUpdateDTO, UsuarioModel>();

            CreateMap<UsuarioDeleteDTO, UsuarioModel>();

            // ConfigurationMapper Paciente

            // Origem ... Destino
            CreateMap<PacienteCreateDTO, PacienteModel>();

            CreateMap<PacienteGetDTO, PacienteModel>();

            CreateMap<PacienteUpdateDTO, PacienteModel>();

            CreateMap<PacienteDeleteDTO, PacienteModel>();

            // ConfigurationMapper Exame

            // Origem ... Destino
            CreateMap<ExameCreateDTO, ExameModel>();

            CreateMap<ExameGetDTO, ExameModel>();
        }
    }
}