using ZooCoursework.DataBase;

namespace ZooCoursework.Services
{
    public class AuthorizationService
    {
        public Account? CurrentAccount { get; set; }
        public User? CurrentUser { get; set; }
    }
}
