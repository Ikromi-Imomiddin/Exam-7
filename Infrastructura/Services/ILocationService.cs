using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entites;
using Domain.Wrapper;

namespace Infrastructura.Services
{
    public interface ILocationService
    {
        Task<Response<Location>> AddLocation(Location Location);
        Task<Response<List<Location>>> GetLocation();
        Task<Response<Location>> UpdateLocation(Location Location);
        Task<Response<string>> DaleteLocation(int id);
    }
}