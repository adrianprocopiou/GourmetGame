namespace GourmetGame.Data.Database.Interface
{
    public interface IDatabaseManager
    {
        IGourmetGameDb GetInstance();
    }
}