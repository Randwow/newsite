using System.Web;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic1.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
        HttpCookie GenCookie(string loginCredential);
        UserMinimal GetUserByCookie(string apiCookieValue);
    }
}
