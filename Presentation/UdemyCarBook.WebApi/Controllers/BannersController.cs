using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using UdemyCarBook.Application.Features.CQRS.Queries.BannerQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly GetBannerQueryHandler _queryBannerQueryHandler;
        private readonly GetBannerByIdQueryHandler _queryBannerByIdQueryHandler;
        private readonly CreateBannerCommendHandler _createBannerCommendHandler;
        private readonly UpdateBannerCommandHandler _updateBannerCommandHandler;
        private readonly RemoveBannerCommandHandler _removeBannerCommandHandler;

        public BannersController(GetBannerQueryHandler queryBannerQueryHandler, 
            GetBannerByIdQueryHandler queryBannerByIdQueryHandler, 
            CreateBannerCommendHandler createBannerCommendHandler,
            UpdateBannerCommandHandler updateBannerCommandHandler, 
            RemoveBannerCommandHandler removeBannerCommandHandler)
        {
            _queryBannerQueryHandler = queryBannerQueryHandler;
            _queryBannerByIdQueryHandler = queryBannerByIdQueryHandler;
            _createBannerCommendHandler = createBannerCommendHandler;
            _updateBannerCommandHandler = updateBannerCommandHandler;
            _removeBannerCommandHandler = removeBannerCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> BannerList()
        {
            var values = await _queryBannerQueryHandler.Handle();
            return Ok(values);  
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBanner(int id)
        {
            var value = await _queryBannerByIdQueryHandler.Handle(new GetBannerByIdQuery(id));
            return Ok(value);   
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommand command)
        {
            await _createBannerCommendHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBanner(int id )
        {
            await _removeBannerCommandHandler.Handle(new RemoveBannerCommand(id));
            return Ok("Bilgi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerCommand command)
        {
            await _updateBannerCommandHandler.Handle(command);
            return Ok("Bilgi Güncellendi");
        }
    }
}
