using System.Collections.Generic;

namespace AspStore.Application.Services.Users.Queries.GetUsers
{
    public class ResultGetUsersDto
    {
        public List<GetUsersDto> Users { get; set; }
        public int Rows { get; set; }
    }
}
