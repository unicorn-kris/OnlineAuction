using OnlineAuction.BLL;
using OnlineAuction.BLL.Interface;
using OnlineAuction.DAL;
using OnlineAuction.DAL.Interface;

namespace OnlineAuction.Dependencies
{
    public class DependencyResolver
    {
        #region user
        private static IUserDao _userDao;

        public static IUserDao UserDao => _userDao ?? (_userDao = new
            UserDao());

        private static IUserLogic _userLogic;

        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new
            UserLogic(UserDao));
        #endregion

        #region lot
        private static ILotDao _lotDao;

        public static ILotDao LotDao => _lotDao ?? (_lotDao = new
            LotDao());

        private static ILotLogic _lotLogic;

        public static ILotLogic LotLogic => _lotLogic ?? (_lotLogic = new
            LotLogic(LotDao));
        #endregion
    }
}
