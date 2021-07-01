using Employee_Leave_Managent.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Leave_Managent.Contracts
{
    interface ILeaveHistoryRepository : IRepositoryBase<LeaveHistory>
    {
    }
}
