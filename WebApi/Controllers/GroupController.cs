using Domain.Entites;
using Domain.Wrapper;
using Infrastructura.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class GroupController
{
    private readonly IGroupServices _GroupService;

    public GroupController(IGroupServices GroupService)
    {
        _GroupService = GroupService;
    }

    [HttpGet("getGroup")]
    public Task<Response<List<Group>>> GetGroup()
    {
        return _GroupService.GetGroup();
    }


    [HttpPost("insertGroup")]
    public Task<Response<Group>> AddGroup(Group Group)
    {
        return _GroupService.AddGroup(Group);
    }
    [HttpPut("updateGroup")]
    public Task<Response<Group>> UpdateGroup(Group Group)
    {
        return _GroupService.UpdateGroup(Group);
    }
    [HttpDelete("deleteGroup")]
    public Task<Response<string>> DaleteGroup(int id)
    {
        return _GroupService.DaleteGroup(id);
    }
}
