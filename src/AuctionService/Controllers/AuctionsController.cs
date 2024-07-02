using AuctionService.DTOs;
using AuctionService.Data;
using AuctionService.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Controllers;

[ApiController]
[Route("api/auctions")]
public class AuctionController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IAuctionRepository _auctionRepository;

    public AuctionController(IAuctionRepository auctionRepository, IMapper mapper)
    {
        _auctionRepository = auctionRepository;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<ActionResult<List<AuctionDto>>> AddAuction(){

    }
}