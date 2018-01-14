using GourmetGame.Data.Database.Interface;

namespace GourmetGame.Data.Database
{
    public class DatabaseManager : IDatabaseManager
    {
        private static IGourmetGameDb _db;
        public IGourmetGameDb GetInstance()
        {
            return _db ?? (_db = new GourmetGameDbList());
        }
    }
}