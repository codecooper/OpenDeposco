using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDeposco.Clients;
public interface IBulkClient
{
    public multistatusResponse BulkUpsertItems(bul bulkUpdateCollection)
    {
        var collection = new BulkUpdateCollection();
        var type = new BulkUpdateType()
        throw new NotImplementedException();
    }
}
