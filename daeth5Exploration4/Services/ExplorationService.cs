using System;
using daeth5Exploration4.DatabaseConnector;
using Microsoft.AspNetCore.Mvc;

namespace daeth5Exploration4.Services
{
    public class ExplorationService
    {

        public string GetName()
        {
            DBConnector db = new DBConnector();
            try
            {
                return db.GetName();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}