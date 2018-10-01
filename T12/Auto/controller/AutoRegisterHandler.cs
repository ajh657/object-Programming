using System;
using System.Collections;
using Auto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.controller
{


    public class AutoRegisterHandler
    {
        DatabaseController dbController = new controller.DatabaseController();


        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbController.connectDatabase();
            return doesItWork;
        }

        public bool saveAuto(Auto.model.Auto newAuto) 
        {
            bool didItGoIntoDatabase = dbController.saveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public List<string> getAllAutoMakers() {

            return dbController.getAllAutoMakersFromDatabase();
        }

        public List<string> getAutoModels(int makerId) {

            return dbController.getAutoModelsByMakerId(makerId);
        }
    }
}
