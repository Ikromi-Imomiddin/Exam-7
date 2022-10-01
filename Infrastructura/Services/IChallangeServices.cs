using Domain.Entites;
using Domain.Wrapper;

namespace Infrastructura.Services;

public interface IChallangeServices
{
    Task<Response<Challange>> AddChallange(Challange Challange);
    Task<Response<List<Challange>>> GetChallange();
    Task<Response<Challange>> UpdateChallange(Challange Challange);
    Task<Response<string>> DaleteChallange(int id);

}
