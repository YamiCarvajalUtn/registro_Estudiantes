using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registroEstudiantes.Models
{
    public class ApplicationRole : IdentityRole

    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName, DateTime creationDate) : base(roleName)
        {
            this.CreationDate = creationDate;
        }
        public ApplicationRole(string roleName) :base(roleName) { }

        public DateTime CreationDate { get; set; }

    }
}
