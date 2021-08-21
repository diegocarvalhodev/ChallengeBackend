using AutoMapper;
using ChallengeBackendApi.Data;
using ChallengeBackendApi.Data.Dtos;
using ChallengeBackendApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeBackendApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideosController : Controller
    {
        private ChallengeContext _context;
        private IMapper _mapper;

        public VideosController(ChallengeContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Video> GetAllVideos() => this._context.Videos;

        [HttpGet("{id}")]
        public IActionResult GetVideoId(int id)
        {
            var video = this._context.Videos.FirstOrDefault(v => v.Id == id);

            if (video is null)
                return NotFound();

            return Ok(this._mapper.Map<ReadVideoDto>(video));
        }

        [HttpPost]
        public IActionResult AddVideo([FromBody] CreateVideoDto createVideoDto)
        {
            Video video = this._mapper.Map<Video>(createVideoDto);

            this._context.Videos.Add(video);
            this._context.SaveChanges();

            return CreatedAtAction(nameof(GetVideoId), new { Id = video.Id }, video);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVideo(int id, [FromBody] UpdateVideoDto updateVideoDto)
        {
            if (updateVideoDto.Id != id)
                return BadRequest();

            Video video = this._context.Videos.FirstOrDefault(x => x.Id == id);

            if (video is null)
                return NotFound();

            this._mapper.Map(updateVideoDto, video);
            
            this._context.SaveChanges();

            return Ok(video);
        }



    }
}
