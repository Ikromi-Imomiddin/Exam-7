using Domain.Entites;
using Domain.Wrapper;
using Infrastructura.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructura.Services;

public class ChallangeServices : IChallangeServices
{
    private readonly DataContext _context;
    public ChallangeServices(DataContext context)
    {
        _context = context;
    }
    public async Task<Response<Challange>> AddChallange(Challange Challange)
    {
        await _context.Challanges.AddAsync(Challange);
        await _context.SaveChangesAsync();
        return new Response<Challange>(Challange);
    }
    public async Task<Response<List<Challange>>> GetChallange()
    {
        var response = await _context.Challanges.ToListAsync();
        return new Response<List<Challange>>(response);
    }
    public async Task<Response<Challange>> UpdateChallange(Challange Challange)
    {
        var record = await _context.Challanges.FindAsync(Challange.Id);
        if (record == null) return new Response<Challange>(System.Net.HttpStatusCode.NotFound, "No record found");
        record.Title = Challange.Title;
        record.Description = Challange.Description;
        await _context.SaveChangesAsync();
        return new Response<Challange>(record);
    }

    public async Task<Response<string>> DaleteChallange(int id)
    {
        var record = await _context.Challanges.FindAsync(id);
        if (record == null)
            return new Response<string>(System.Net.HttpStatusCode.NotFound, "No record found");
        _context.Challanges.Remove(record);
        await _context.SaveChangesAsync();
        return new Response<string>("success");
    }
}