using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_protection_sizeRepository : IRepository<hu_protection_size>
    {
        IEnumerable<hu_protection_size> GetAllByProtectionSize(int tag, int page, int pageSize, out int totalRow);
    }
    public class hu_protection_sizeRepository : RepositoryBase<hu_protection_size>, Ihu_protection_sizeRepository
    {
        public hu_protection_sizeRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_protection_size> GetAllByProtectionSize(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
