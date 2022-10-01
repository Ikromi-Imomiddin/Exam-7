using Domain.Entites;
using Domain.Wrapper;
using Infrastructura.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructura.Services;

public class LocationServices : ILocationService
{
    private readonly DataContext _context;
    public LocationServices(DataContext context)
    {
        _context = context;
    }
    public async Task<Response<Location>> AddLocation(Location Location)
    {
        await _context.Locations.AddAsync(Location);
        await _context.SaveChangesAsync();
        return new Response<Location>(Location);
    }
    public async Task<Response<List<Location>>> GetLocation()
    {
        var response = await _context.Locations.ToListAsync();
        return new Response<List<Location>>(response);
    }
    public async Task<Response<Location>> UpdateLocation(Location Location)
    {
        var record = await _context.Locations.FindAsync(Location.Id);
        if (record == null) return new Response<Location>(System.Net.HttpStatusCode.NotFound, "No record found");
        record.Name = Location.Name;
        record.Description = Location.Description;
        await _context.SaveChangesAsync();
        return new Response<Location>(record);
    }

    public async Task<Response<string>> DaleteLocation(int id)
    {
        var record = await _context.Locations.FindAsync(id);
        if (record == null)
            return new Response<string>(System.Net.HttpStatusCode.NotFound, "No record found");
        _context.Locations.Remove(record);
        await _context.SaveChangesAsync();
        return new Response<string>("success");
    }
}