using Distribuidos.Api.Models;
using Distribuidos.Api.Services;

namespace Distribuidos.Api.Services
{
    public interface IPipedreamService
    {

        Task<bool> SendWelcome(WelcomeModel body);

    }
}