namespace SaitForPPY.Controllers
{
    public static class UserService
    {
        
        private static List<CreateUserViewModel> _repostory = new List<CreateUserViewModel>();

        public static Task AddUser(CreateUserViewModel model)
        {
            _repostory.Add(model);

            return Task.CompletedTask;
        }

        //public static Task DeleteUser(string userId) { }

        public static List<CreateUserViewModel> GetAllUsers()
        {
            return _repostory;
        }

	}






}