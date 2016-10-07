using AutoMapper;

namespace P1DotNetVF.VisaoMVC.AutoMapper
{
	public class AutoMapperConfig
	{
		public static void RegistersMapping()
		{
			Mapper.Initialize(
				x =>
				{
					x.AddProfile<DomainToViewModelMappingProfile>();
					x.AddProfile<ViewModelToDomainMappingProfile>();
				}
			);
		}
	}
}