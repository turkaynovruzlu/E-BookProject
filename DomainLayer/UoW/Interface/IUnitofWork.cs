using Repository.Interfaces;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.UoW.Interface
{
    public interface IUnitofWork
    {
        IBookRepository bookRepository { get; }
        IBookUserRepository bookUserRepository {  get; }
        ICommentRepository commentRepository { get; }
        IPaymentRepository paymentRepository { get; }
        IScoreRepository scoreRepository { get; }
        IRoleRepository roleRepository { get; }
        IUserRepository userRepository { get; }
        Task<int> Submit();
    }
}
