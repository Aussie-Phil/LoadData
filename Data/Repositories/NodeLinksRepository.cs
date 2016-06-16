using Data.Repositories.Models;

namespace Data.Repositories
{
    public class NodeLinksRepository : GenericRepository<NODE_LINKS, int>
    {

        public void DeleteAll()
        {
            ExecuteSqlCommand("DELETE FROM NODE_LINKS");

        }
    }
}
