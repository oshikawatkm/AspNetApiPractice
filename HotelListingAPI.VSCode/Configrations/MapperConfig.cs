using AutoMapper;

namespace HotelListing.API.Configurations
{
  public class MapperConfig : Profile
  {
    public MapperConfig()
    {
      CreateMap<Country, CreateCountryDto>().ReverseMap();
    }
  }
}