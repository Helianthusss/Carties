using AuctionService.DTOs;
using AuctionService.Data;
using AuctionService.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using MassTransit;

namespace AuctionService.Controllers;

[ApiController]
[Route("api/auctions")]
public class AuctionController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly AuctionDbContext _auctionContext;

    public AuctionController(AuctionDbContext auctionContext, IMapper mapper)
    {
        _auctionContext = auctionContext;
        _mapper = mapper;
    }
    
}

