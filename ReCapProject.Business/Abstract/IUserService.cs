using ReCapProject.Core.Entities.Concrete;
using System.Collections.Generic;

namespace ReCapProject.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
