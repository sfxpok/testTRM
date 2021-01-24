using SQLite;
using testTRM.Entities;

public class PeopleRepository
{
    private SQLiteConnection db = null;
    protected static PeopleRepository me;

    static PeopleRepository()
    {
        me = new PeopleRepository();
    }

    protected PeopleRepository()
    {
        db = new SQLiteConnection(Constants.DbFilePath);
        db.CreateTable<User>();
    }

    public static int SavePerson(User person)
    {
        me.db.Insert(person);
        return person.id_user;
    }

    public static User GetPerson(int id)
    {
        return me.db.Get<User>(p => p.id_user == id);
    }
}