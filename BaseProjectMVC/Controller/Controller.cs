using BaseProjectMVC.Model_Persistence;
using BaseProjectMVC.Model_Persistence.DatabaseAdapter;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProjectMVC.Controller
{
    internal class Controller
    {
        private static Controller Ctrl;
        private Controller() { }
        ///<summary>
        ///Singleton instance of main controller. Creates a new one if null (firt call) or return existing one.
        ///Usage: Controller.GetController()
        ///</summary>
        public static Controller GetController()
        {
            if (Ctrl == null)
            {
                Ctrl = new Controller();
            }
            return Ctrl;
        }
        //End of singleton implementation

        private IDatabaseAdapter DB = DatabaseConnection.GetDatabaseConnection();
        
        //code goes here



    }
}
