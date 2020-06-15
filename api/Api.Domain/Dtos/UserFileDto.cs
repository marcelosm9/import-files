using System;

namespace Api.Domain.Dtos
{
    public class UserFileDto
    {
        public class UserFileDTO
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime Birthday { get; set; }
            public string Gender { get; set; }
        }
    }
}
