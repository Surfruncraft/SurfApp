using AppConversionDesKMSFinale.Modèles;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace AppConversionDesKMSFinale.Services
{
    public static class UserService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
            {
                return;
            }
            // Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "SurfrunData.db");

            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<User>();
        }

        public static async Task AddUser(string username, string password, string photoPath)
        {
            await Init();
            var user = new User
            {
                Username = username,
                Password = password,
                PhotoPath = photoPath,
            };
            var id = await db.InsertAsync(user);
        }

        public static async Task RemoveUser(int id)
        {
            await Init();

            await db.DeleteAsync<User>(id);
        }

        public static async Task<IEnumerable<User>> GetUser()
        {
            await Init();

            var user = await db.Table<User>().ToListAsync();
            return user;
        }
    }
}
