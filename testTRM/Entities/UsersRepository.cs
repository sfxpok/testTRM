using SQLite;
using testTRM.Entities;

public class UserRepository
{
    private SQLiteConnection db = null; // base de dados local
    protected static UserRepository me;

    static UserRepository()
    {
        me = new UserRepository();
    }

    protected UserRepository()
    {
        db = new SQLiteConnection(Constants.db_path);
        db.CreateTable<User>();
    }

    public static int SaveUser(User user)
    {
        me.db.Insert(user);
        return user.id_user;
    }

    public static User GetUser(int id)
    {
        return me.db.Get<User>(p => p.id_user == id);
    }
}