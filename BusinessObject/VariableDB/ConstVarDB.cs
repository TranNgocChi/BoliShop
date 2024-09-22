namespace DataAccess.ConstVariable
{
    
    public class ConstVarDB
    {
        public const string databaseName = "GauFashion";
        public const string connectionString = $"mongodb+srv://brightsuntnc2003:x5FlFVw52JJdpwRf@cluster0.hutpv.mongodb.net/{databaseName}?retryWrites=true&w=majority&appName=Cluster0";

        public const string UserCollection = "User";
        public const string ProductCollection = "Product";
        public const string CartCollection = "Cart";
        public const string OrderCollection = "Order";

    }
}
