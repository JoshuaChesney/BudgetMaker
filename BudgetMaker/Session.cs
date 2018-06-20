using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaker
{
    public class Session
    {

        public User currentUser = new User();

        public void loadUser(string userToLoad)
        {
            currentUser.username = userToLoad;
            currentUser.openFile();
        }
        
        public void createUser(string userToCreate)
        {
            currentUser.username = userToCreate;
            currentUser.writeToFile();
        }
    }
}
