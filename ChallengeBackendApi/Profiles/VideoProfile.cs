using AutoMapper;
using ChallengeBackendApi.Data.Dtos;
using ChallengeBackendApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeBackendApi.Profiles
{
    public class VideoProfile : Profile
    {
        public VideoProfile()
        {
            CreateMap<CreateVideoDto, Video>();
            CreateMap<UpdateVideoDto, Video>();
            CreateMap<Video, ReadVideoDto>();
        }
    }
}
