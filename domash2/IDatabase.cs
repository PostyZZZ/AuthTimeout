namespace domash2
{
    internal interface IDatabase
    {
        void closeConnection();
        void openConnection();
    }
}