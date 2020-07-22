using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Calendar.Models;

namespace Calendar.Data
{
    public class JobDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public JobDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Job>().Wait();
        }

        public Task<List<Job>> GetJobsAsync()
        {
            return _database.Table<Job>().ToListAsync();
        }

        public Task<Job> GetJobAsync(int id)
        {
            return _database.Table<Job>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveJobAsync(Job job)
        {
            if (job.ID != 0)
            {
                return _database.UpdateAsync(job);
            }
            else
            {
                return _database.InsertAsync(job);
            }
        }

        public Task<int> DeleteJobAsync(Job job)
        {
            return _database.DeleteAsync(job);
        }
    }
}