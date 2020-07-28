using AspStore.Application.Interfaces.Contexts;
using AspStore.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspStore.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        private readonly IDataBaseContext _context;

        public GetUsersService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<GetUsersDto> Execute(RequestGetUsersDto request)
        {
            var users = _context.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.SearchKey))
            {
                users = users.Where(p => p.FullName.Contains(request.SearchKey) &&
                    p.Email.Contains(request.SearchKey));
            }

            int rowsCount = 0;
            return users.ToPaged(request.Page, 20, out rowsCount)
                .Select(p => new GetUsersDto
                {
                    Email = p.Email,
                    FullName = p.FullName,
                    Id = p.Id
                }).ToList();
        }
    }
}
