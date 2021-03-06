using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Iot_other_list_typeRepository : IRepository<ot_other_list_type>
    {
        IEnumerable<ot_other_list_type> GetAllByListType(int tag, int page, int pageSize, out int totalRow);
    }
    public class ot_other_list_typeRepository : RepositoryBase<ot_other_list_type>, Iot_other_list_typeRepository
    {
        public ot_other_list_typeRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<ot_other_list_type> GetAllByListType(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}

