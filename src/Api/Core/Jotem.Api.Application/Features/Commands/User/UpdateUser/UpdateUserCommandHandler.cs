using Jotem.Api.Application.Interfaces.Repostrories;
using Jotem.Common.Infrastructure;
using Jotem.Common.Models.Event.User;
using Jotem.Common.Models.RequestModels.User;
using Jotem.Infrastructure.Persistence.Exeptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotem.Api.Application.Features.Commands.User.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
    {


        private readonly IUserRepository _userRepository;

        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var dbUser = await _userRepository.GetSingleAsync(i => i.UserName == request.UserName);

            if (dbUser == null)
                throw new DatabaseValidationException("User not found!");

            var pass = PasswordEncryptor.Encrypt(request.Password);

            dbUser.Password = pass;
            await _userRepository.UpdateAsync(dbUser);

            return true;
        }
    }
}
