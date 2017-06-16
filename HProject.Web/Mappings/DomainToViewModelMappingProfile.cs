using AutoMapper;
using HProject.Entities;
using HProject.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HProject.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            // code omitted
            Mapper.CreateMap<Project, ProjectViewModel>();
           
        }
    }
}