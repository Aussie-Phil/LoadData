using Data.Repositories.Models;
using System.Data.Entity;

namespace Data.Repositories
{
    public class NodeRepository : GenericRepository<NODES, int>
    {
        //Put any Node specific methods here - eg. queries or commands that do special things to the DB
        //Not really needed in this test
        

        public void DeleteAll()
        {
            ExecuteSqlCommand("DELETE FROM NODES");

        }
    }
}
