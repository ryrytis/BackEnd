namespace API0103
{
    public interface INewUserRepository
    {
        List<NewUser> NewUsers();
        NewUser AddUser(NewUser newUser);
    }
}
