using AutoMapper;
using P1DotNetVF.VisaoMVC.ViewModels;
using P1DotNetVF.Domain.Entities;
namespace P1DotNetVF.VisaoMVC.AutoMapper
{
	public class DomainToViewModelMappingProfile : Profile
	{
		public override string ProfileName
		{
			get
			{
				return "ViewModelToDomainMapping";
			}
		}

		protected override void Configure()
		{
			CreateMap<Correntista, CorrentistaViewModel>();
			CreateMap<Cartao, CartaoViewModel>();
		}
	}
}