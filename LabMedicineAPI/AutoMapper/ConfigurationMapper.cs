using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LabMedicineAPI.DTOs;
using LabMedicineAPI.DTOs.Consulta;
using LabMedicineAPI.DTOs.Dieta;
using LabMedicineAPI.DTOs.Endereco;
using LabMedicineAPI.DTOs.Exame;
using LabMedicineAPI.DTOs.Exercicio;
using LabMedicineAPI.DTOs.Medicamento;
using LabMedicineAPI.DTOs.Paciente;
using LabMedicineAPI.DTOs.Usuario;
using LabMedicineAPI.Model;

namespace LabMedicineAPI.AutoMapper
{
    public class ConfigurationMapper : Profile
    {
        public ConfigurationMapper()
        {
            

            CreateMap<UsuarioCreateDTO, UsuarioModel>().ReverseMap();
            CreateMap<UsuarioGetDTO, UsuarioModel>().ReverseMap();
            CreateMap<UsuarioModel,UsuarioUpdateDTO>().ReverseMap();



            CreateMap<PacienteCreateDTO, PacienteModel>().ReverseMap();
            CreateMap<PacienteGetDTO, PacienteModel>().ReverseMap();
            CreateMap<PacienteModel,PacienteUpdateDTO>().ReverseMap();
            

           
            CreateMap<ExameCreateDTO, ExameModel>().ReverseMap();
            CreateMap<ExameGetDTO, ExameModel>().ReverseMap();
            CreateMap<ExameModel, ExameUpdateDTO>().ReverseMap();
           // CreateMap<ExameDeleteDTO, ExameModel>();

            CreateMap<ConsultaCreateDTO, ConsultaModel>().ReverseMap();
            CreateMap<ConsultaGetDTO, ConsultaModel>().ReverseMap();
            CreateMap<ConsultaUpdateDTO, ConsultaModel>().ReverseMap();
           

            CreateMap<DietaCreateDTO, DietaModel>();
            CreateMap<DietaGetDTO, DietaModel>();
            CreateMap<DietaModel, DietaUpdateDTO>();
            CreateMap<DietaDeleteDTO, DietaModel>();

            CreateMap<ExercicioCreateDTO, ExercicioModel>();
            CreateMap<ExercicioGetDTO, ExercicioModel>();
            CreateMap<ExercicioModel, ExercicioUpdateDTO>();
            CreateMap<ExercicioDeleteDTO, ExercicioModel>();

            CreateMap<MedicamentoCreateDTO, MedicamentoModel>();
            CreateMap<MedicamentoGetDTO, MedicamentoModel>();
            CreateMap<MedicamentoModel, MedicamentoUpdateDTO>();
            CreateMap<MedicamentoDeleteDTO,MedicamentoModel>();

            CreateMap<EnderecoCreateDTO, EnderecoModel>().ReverseMap();
            CreateMap<EnderecoGetDTO, EnderecoModel>().ReverseMap();
            CreateMap<EnderecoModel, EnderecoUpdateDTO>().ReverseMap();
        }
    }
}