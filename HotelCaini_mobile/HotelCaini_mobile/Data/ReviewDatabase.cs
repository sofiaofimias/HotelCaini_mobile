using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using HotelCaini_mobile.Models;

namespace HotelCaini_mobile.Data
{
    public class ReviewDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public ReviewDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Review>().Wait();
        }

        public Task<List<Review>> GetShopListsAsync()
        {
            return _database.Table<Review>().ToListAsync();
        }

        public Task<Review> GetShopListAsync(int id)
        {
            return _database.Table<Review>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }

        public Task<int> SaveShopListAsync(Review slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }

        public Task<int> DeleteShopListAsync(Review slist)
        {
            return _database.DeleteAsync(slist);
        }

    }
}
