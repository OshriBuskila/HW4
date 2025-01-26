
namespace GamesStore.Models
{
    public class Userr
    {
        int id;
        string name;
        string email;
        string password;
        bool isActive;


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }    
        public bool IsActive { get => isActive; set => isActive = value; }

        public Userr() { }
        public static int Register(string newName,string newEmail, string newPassword)
        {
            DBservices dbServices = new DBservices();

            try
            {
                int result = dbServices.Register(newName, newEmail, newPassword);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error registering user: {ex.Message}");
                return 0;
            }
        }

       
        public  Userr Login(string email, string password)
        {
            DBservices dbServices = new DBservices();
            Userr userid = dbServices.userLogin(email, password);
            return userid; 
        }
        public static int UpdateName(int currentID, string newName)
        { 
            DBservices dbServices = new DBservices();
            int result = dbServices.UpdateName(currentID, newName);
            return result;
            
            
        }
        public static int UpdatePass(int currentID, string newPass)
        {
            DBservices dbServices = new DBservices();
            int result = dbServices.UpdatePass(currentID, newPass);
            return result;
        }
        public static Userr UpdateUser(Userr changesForUser)
        {
            DBservices dBservice = new DBservices();
            return dBservice.UpdateUser(changesForUser);
        }
        public static int changeActivation(int id, bool userActivation)
        {
            DBservices dBservices = new DBservices();
            return dBservices.changeActivation(id,userActivation);
        }
        public static object UsersBI()
        {
            DBservices db = new DBservices();
            return db.UsersBI();
        }

    }
}
