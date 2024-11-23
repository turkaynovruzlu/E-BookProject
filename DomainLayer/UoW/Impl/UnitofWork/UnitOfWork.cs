using Repository.Interfaces;
using DATA.Data;
using DomainLayer.UoW.Interface;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.UoW.Impl.UnitofWork
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly BookDbContext dbContext;
        public IBookRepository bookRepository { get; private set; }
         
        public IBookUserRepository bookUserRepository {  get; private set; }

        public ICommentRepository commentRepository { get; private set; }

        public IPaymentRepository paymentRepository { get; private set; }

        public IScoreRepository scoreRepository { get; private set; }

        public IRoleRepository roleRepository { get; private set; } 

        public IUserRepository userRepository { get; private set; }


        public UnitOfWork(BookDbContext bookDbContext,IBookRepository bookRepository,IBookUserRepository bookUserRepository,
            IUserRepository userRepository,ICommentRepository commentRepository,IPaymentRepository paymentRepository,
            IRoleRepository roleRepository,IScoreRepository scoreRepository)
        {
            this.paymentRepository = paymentRepository;
            this.bookRepository = bookRepository;
            this.bookUserRepository = bookUserRepository;
            this.userRepository = userRepository;
            this.commentRepository = commentRepository;
            this.roleRepository = roleRepository;
            this.scoreRepository = scoreRepository;
            dbContext = bookDbContext;
        }

        public async Task<int> Submit()
        {
            using(var tr=dbContext.Database.BeginTransaction())
            {

                try
                {
                    return await dbContext.SaveChangesAsync();

                    await tr.CommitAsync();
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    throw new Exception(ex.Message, ex);
                }

            }
        }


    }
}
