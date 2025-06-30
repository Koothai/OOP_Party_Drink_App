using LiteDB;
using System.Collections.Generic;
using System.Linq;

public class UserDatabase
{
    private readonly string _dbPath = "cocktails.db";

    public void InsertUser(User user)
    {
        using var db = new LiteDatabase(_dbPath);
        var users = db.GetCollection<User>("users");
        users.Insert(user);
    }

    public User GetUser(string username, string password)
    {
        using var db = new LiteDatabase(_dbPath);
        var users = db.GetCollection<User>("users");
        return users.FindOne(u => u.Username == username && u.Password == password);
    }

    public bool UserExists(string username)
    {
        using var db = new LiteDatabase(_dbPath);
        var users = db.GetCollection<User>("users");
        return users.Exists(u => u.Username == username);
    }
    public void UpdateUser(User user)
    {
        using var db = new LiteDB.LiteDatabase(_dbPath);
        var users = db.GetCollection<User>("users");
        users.Update(user);
    }
}
