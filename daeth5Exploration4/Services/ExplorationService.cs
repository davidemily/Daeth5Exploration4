using System;
using daeth5Exploration4.DatabaseConnector;
using Microsoft.AspNetCore.Mvc;

namespace daeth5Exploration4.Services
{
    public class ExplorationService
    {
        public ActionResult NewEntry(string name)
        {
            if (name == null || name.Length>20)
            {
                return new BadRequestResult();
            }

            try
            {
                DBConnector db = new DBConnector();
                db.InsertNewName(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new BadRequestResult();
            }

            return new OkResult();
        }

        public string GetName()
        {
            return "David Emily";
        }

        public string GetExploration()
        {
            return "daeth5 Exploration 4";
        }
    }
}