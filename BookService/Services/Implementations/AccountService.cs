using BookService.Constants;
using BookService.Dtos.RequestDTO;
using BookService.Services.Interfaces;
using DATA.Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookService.Services.Implementations
{
    public class AccountService:IAccountService
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<User> _userManager;
        public AccountService(RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;

        }
        public async Task AssignRole()
        {
            var roles = new List<Role>
            {
                new Role(){Name="Admin"},
                new Role(){Name="Author"},
                new Role(){Name="User"}
            };
            foreach (var role in roles)
            {
                await _roleManager.CreateAsync(role);
            }
        }
        public async Task CreateAdmin()
        {
            //var adminRole = await _roleManager.Roles.Where(x=>x.Name=="admin").FirstOrDefaultAsync();
            var adminRole = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Name == "Admin");
            User user = new User
            {
                UserName = AdminConfigConstant.UserName,
                Email=AdminConfigConstant.Email,
            };
            await _userManager.CreateAsync(user, AdminConfigConstant.Password);

            await _userManager.AddToRoleAsync(user, adminRole.Name);
        }
        public async Task CreateUserRegister(CreateUserDTO userDTO)
        {

            User user = new User()
            {
                UserName = userDTO.UserName,
                Email = userDTO.Email,
                PhoneNumber = userDTO.PhoneNumber,
                CreatedDate = DateTime.Now,
                DateOfBirth = userDTO.DateOfBirth,
            };
            await _userManager.CreateAsync(user,userDTO.Password);
            await _userManager.AddToRoleAsync(user, "User");
        }
        public async Task CreateAuthorRegister(CreateAuthorDTO authorDTO)
        {

            User user = new User()
            {
                UserName = authorDTO.UserName,
                Email = authorDTO.Email,
                PhoneNumber = authorDTO.PhoneNumber,
                CreatedDate = DateTime.Now,
                DateOfBirth = authorDTO.DateOfBirth,
            };
            await _userManager.CreateAsync(user, authorDTO.Password);
            await _userManager.AddToRoleAsync(user, "User");
        }
        public async Task AuthorLogin(AuthorLoginDTO authorLoginDTO)
        {
            var user=await _userManager.FindByEmailAsync(authorLoginDTO.Email);
            if (user!=null)
            {
                var password = _userManager.CheckPasswordAsync(user, authorLoginDTO.Password);
                
            }
            else
            {
                throw new Exception("Parol ve ya Email düzgün deyil!");
            }
        }
        public async Task UserLogin(UserLoginDTO userLoginDTO)
        {
            var user=await _userManager.FindByEmailAsync(userLoginDTO.Email);
            if(user!=null)
            {
                var password= _userManager.CheckPasswordAsync(user, userLoginDTO.Password);
            }
            else
            {
                throw new Exception("Parol ve ya Email duzgun daxil olunmayib!");
            }
        }
        //Login method
        //registration method

    }
}
