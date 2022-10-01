using Domain.Entites;
using Domain.Wrapper;
using Infrastructura.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class ChallangeController
{
    private readonly IChallangeServices _ChallangeService;

    public ChallangeController(IChallangeServices ChallangeService)
    {
        _ChallangeService = ChallangeService;
    }

    [HttpGet("getChallange")]
    public Task<Response<List<Challange>>> GetChallange()
    {
        return _ChallangeService.GetChallange();
    }


    [HttpPost("insertChallange")]
    public Task<Response<Challange>> AddChallange(Challange Challange)
    {
        return _ChallangeService.AddChallange(Challange);
    }
    [HttpPut("updateChallange")]
    public Task<Response<Challange>> UpdateChallange(Challange Challange)
    {
        return _ChallangeService.UpdateChallange(Challange);
    }
    [HttpDelete("deleteChallange")]
    public Task<Response<string>> DaleteChallange(int id)
    {
        return _ChallangeService.DaleteChallange(id);
    }
}
