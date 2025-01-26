namespace GamesStore.Models
{
    public class Game
    {
        int appID;
        string name;
        DateTime releaseDate;
        double price;
        string description;
        string headerImage;
        string website;
        bool windows;
        bool mac;
        bool linux;
        int scoreRank;
        string recommendations;
        string publisher;
        int numberOfPurchases;
        static public List<Game> games = new List<Game>();

        public Game(int appID, string name, DateTime releaseDate, double price, string description, string headerImage, string website, bool windows, bool mac, bool linux, int scoreRank, string recommendations, string publisher, int numberOfPurchases)
            
        {
            AppID = appID;
            Name = name;
            ReleaseDate = releaseDate;
            Price = price;
            Description = description;
            HeaderImage = headerImage;
            Website = website;
            Windows = windows;
            Mac = mac;
            Linux = linux;
            ScoreRank = scoreRank;
            Recommendations = recommendations;
            Publisher = publisher;
            NumberOfPurchases = numberOfPurchases;

        }
        public Game() { }
        public int AppID { get => appID; set => appID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public string HeaderImage { get => headerImage; set => headerImage = value; }
        public string Website { get => website; set => website = value; }
        public bool Windows { get => windows; set => windows = value; }
        public bool Mac { get => mac; set => mac = value; }
        public bool Linux { get => linux; set => linux = value; }
        public int ScoreRank { get => scoreRank; set => scoreRank = value; }
        public string Recommendations { get => recommendations; set => recommendations = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int NumberOfPurchases { get => numberOfPurchases; set => numberOfPurchases = value; }


        public static int UserBuyGame(int userID, int appID)
        {
            DBservices db = new DBservices();
            return db.userBuyGame(userID, appID);

             
        }

        public static List<Game> Read()
        {
            DBservices db = new DBservices();
            return db.Read();
        }
        public static List<Game> GetUserGames(int userId)
        {
            DBservices db = new DBservices();
            return db.ReadUserGames(userId);
        }
        public static List<Game> GetGamesByPrice(int Userid,float price)
        {
            DBservices db = new DBservices();
            return db.GetGamesByPrice(Userid, price);
        }
        public static List<Game> GetGamesByRank(int UserID, int Rank)
        {
            DBservices db = new DBservices();
            return db.GetGamesByRank(UserID, Rank);
        }
        public static int DeleteGameById(int UserId, int AppId)
        {
            DBservices db = new DBservices();
            return db.userDeleteGame(UserId, AppId);
        }
        public static object GamesBI()
        {
            DBservices db = new DBservices();
            return db.GamesBI();
        }


    }
}

