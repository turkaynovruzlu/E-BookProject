using BookService.Dtos.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Services.Interfaces
{
    public interface IAccountService
    {
        Task CreateAdmin();
        Task AssignRole();
        Task CreateUserRegister(CreateUserDTO userDTO);
        Task AuthorLogin(AuthorLoginDTO authorLoginDTO);
        Task UserLogin(UserLoginDTO userLoginDTO);
    }
}
