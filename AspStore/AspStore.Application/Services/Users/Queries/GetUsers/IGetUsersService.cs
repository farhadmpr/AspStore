using AspStore.Domain.Entities.Users;
using System.Collections.Generic;
using System.Text;

namespace AspStore.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersService
    {
        List<GetUsersDto> Execute(RequestGetUsersDto request);
    }
}
