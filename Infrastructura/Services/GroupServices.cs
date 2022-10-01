using Domain.Entites;
using Domain.Wrapper;
using Infrastructura.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructura.Services;

public class GroupServices : IGroupServices
{
    private readonly DataContext _context;
    public GroupServices(DataContext context)
    {
        _context = context;
    }
    public async Task<Response<Group>> AddGroup(Group Group)
    {
        await _context.Groups.AddAsync(Group);
        await _context.SaveChangesAsync();
        return new Response<Group>(Group);
    }
    public async Task<Response<List<Group>>> GetGroup()
    {
        var response = await _context.Groups.ToListAsync();
        return new Response<List<Group>>(response);
    }
    public async Task<Response<Group>> UpdateGroup(Group Group)
    {
        var record = await _context.Groups.FindAsync(Group.Id);
        if (record == null) return new Response<Group>(System.Net.HttpStatusCode.NotFound, "No record found");
        record.GroupNick = Group.GroupNick;
        record.TeamSlogan = Group.TeamSlogan;
        await _context.SaveChangesAsync();
        return new Response<Group>(record);
    }

    public async Task<Response<string>> DaleteGroup(int id)
    {
        var record = await _context.Groups.FindAsync(id);
        if (record == null)
            return new Response<string>(System.Net.HttpStatusCode.NotFound, "No record found");
        _context.Groups.Remove(record);
        await _context.SaveChangesAsync();
        return new Response<string>("success");
    }
}