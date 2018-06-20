using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaker
{
    public class Session
    {
        private User currentUser = new User();

        public void loadUser(string userToLoad)
        {
            currentUser.username = userToLoad;
            currentUser.openFile();
        }

        //load user and create user currently do the same thing
        //this may change in the future, so I am going to leave them seperated for now

        public void createUser(string userToCreate)
        {
            currentUser.username = userToCreate;
            currentUser.openFile();
        }
    }
}
