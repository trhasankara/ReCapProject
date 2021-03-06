using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Entities.Concrete;

namespace ReCapProject.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
