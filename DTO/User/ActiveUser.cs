using System;

namespace DTO
{
    public class ActiveUser
    {
        public Guid Id { get; set; }

        public string Login { get; set; }
        public string Name { get; set; }
    }
}