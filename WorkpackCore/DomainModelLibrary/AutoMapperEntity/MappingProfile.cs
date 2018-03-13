using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModelLibrary.AutoMapperEntity
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Currency, CurrencyViewItem>();
            CreateMap<CurrencyViewItem, Currency>();
            CreateMap<Role, RoleViewItem>();
            CreateMap<RoleViewItem, Currency>();
            CreateMap<DesignationViewItem, Designation>();
        }
    }
}
