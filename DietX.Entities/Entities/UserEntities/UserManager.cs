using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.Entities.Entities.UserEntities
{
    //Mevcut kullanıcı bilgisini tutmak ve kolayca erişim için kullanıldı.
    public class UserManager
    {
        private static User _currentUser;

        public static User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }
    }
}
