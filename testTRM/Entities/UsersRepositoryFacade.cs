//using SQLite;

//public interface IDBConnect
//{
//    void GetDBConnect();
//    void GetLocalUserRepository();
//}

//public interface ISaveUser
//{
//    void SetUser();
//}

//public interface IGetUser
//{
//    void GetUser();
//}

//public class DBProvider : IDBConnect
//{
//    public void GetDBConnect()
//    {
//        private SQLiteConnection db = null; // base de dados local
//    }

//    public void GetLocalUserRepository()
//    {
//        protected static UserRepository me;
//    }
//}

//public class SaveUserProvider : ISaveUser
//{

//}

//public class GetUserProvider : IGetUser
//{

//}

//public class UsersRepositoryFacade
//{
//    private IDBConnect _DBProvider;
//    private ISaveUser _SaveUserProvider;
//    private IGetUser _GetUserProvider;

//    public UsersRepositoryFacade()
//    {
//        _DBProvider = new DBProvider();
//        _SaveUserProvider = new SaveUserProvider();
//        _GetUserProvider = new GetUserProvider();
//    }
//}