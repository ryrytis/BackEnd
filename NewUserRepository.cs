using System.ComponentModel;

namespace API0103
{
    public class NewUserRepository: INewUserRepository
    {
        private readonly List<NewUser> _addUser = new();

        public NewUser AddUser(NewUser addNewUser)
        {
            _addUser.Add(addNewUser);
            return addNewUser;
        }

    }
}
