using AutoMapper;
using P1DotNetVF.Domain.Entities;
using P1DotNetVF.VisaoMVC.ViewModels;

namespace P1DotNetVF.VisaoMVC.AutoMapper
{
	public class ViewModelToDomainMappingProfile : Profile
	{
		public override string ProfileName
		{
			get
			{
				return "DomainToViewModelMapping";
			}
		}

		protected override void Configure()
		{
			CreateMap<CorrentistaViewModel, Correntista>();
			CreateMap<CartaoViewModel, Cartao>();
		}

	}
}