using AutoMapper;
using Database.Models;
using RetailProcurementSystem.DTOs;

namespace RetailProcurementSystem.Configuration
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<StoreItem, StoreItemDTO>().ReverseMap();
            CreateMap<SupplierStoreItem, SupplierStoreItemDTO>()
                .ForMember(dest => dest.StoreItemName,
                    opt => opt.MapFrom(src => src.StoreItem.Name))
                .ForMember(dest => dest.StoreItemPrice,
                    opt => opt.MapFrom(src => src.StoreItem.Price))
                .ForMember(dest => dest.StoreItemQuantity,
                    opt => opt.MapFrom(src => src.StoreItem.Quantity))
                .ForMember(dest => dest.SupplierName,
                    opt => opt.MapFrom(src => src.Supplier.Name))
                .ReverseMap();
        }
    }
}
