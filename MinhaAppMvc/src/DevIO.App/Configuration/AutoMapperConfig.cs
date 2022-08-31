using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Business.Models;

namespace DevIO.App.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "AutoMapperConfig";
            }
        }

        public AutoMapperConfig()
        {
            ConfigureMappings();
        } 

        private void ConfigureMappings()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
