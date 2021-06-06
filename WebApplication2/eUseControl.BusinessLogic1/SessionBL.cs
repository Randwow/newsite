using System.Web;
using eUseControl.BusinessLogic1.Core;
using eUseControl.BusinessLogic1.Interfaces;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic1
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }

        public HttpCookie GenCookie(string loginCredential)
        {
            return Cookie(loginCredential);
        }

        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }
    }
}

