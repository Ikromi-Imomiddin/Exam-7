using Domain.Entites;
using Domain.Wrapper;

namespace Infrastructura.Services;

public interface IGroupServices
{
    Task<Response<Group>> AddGroup(Group Group);
    Task<Response<List<Group>>> GetGroup();
    Task<Response<Group>> UpdateGroup(Group Group);
    Task<Response<string>> DaleteGroup(int id);
}
