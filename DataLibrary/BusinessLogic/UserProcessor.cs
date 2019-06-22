using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class UserProcessor
    {
        public static int CreateUser(int userID, string firstName, 
            string lastName, string emailAddress)
        {
            UserModel data = new UserModel
            {
                UserId = userID,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress
            };

            string sql = @"INSERT INTO dbo.UserTable (UserId, FirstName, LastName, EmailAddress)";
            sql += " values (@UserId, @FirstName, @LastName, @EmailAddress);";

            return SQLDataAccess.SaveData(sql, data);
        }

        public static List<UserModel> LoadUsers()
        {
            string sql = @"SELECT Id, UserId, Firstname, LastName, EmailAddress
                        from dbo.Users;";
            return SQLDataAccess.LoadData<UserModel>(sql);
        }
    }
}
