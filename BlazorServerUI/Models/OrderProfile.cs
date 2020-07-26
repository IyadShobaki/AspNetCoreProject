using AutoMapper;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerUI.Models
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderModel, OrderUIModel>();
            CreateMap<OrderUIModel, OrderModel>();
        }
    }
}
