using Domain.Entites;
using Domain.Wrapper;
using Infrastructura.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class LocationController
{
    private readonly ILocationService _LocationService;

    public LocationController(ILocationService LocationService)
    {
        _LocationService = LocationService;
    }

    [HttpGet("getLocation")]
    public Task<Response<List<Location>>> GetLocation()
    {
        return _LocationService.GetLocation();
    }


    [HttpPost("insertLocation")]
    public Task<Response<Location>> AddLocation(Location Location)
    {
        return _LocationService.AddLocation(Location);
    }
    [HttpPut("updateLocation")]
    public Task<Response<Location>> UpdateLocation(Location Location)
    {
        return _LocationService.UpdateLocation(Location);
    }
    [HttpDelete("deleteLocation")]
    public Task<Response<string>> DaleteLocation(int id)
    {
        return _LocationService.DaleteLocation(id);
    }
}
