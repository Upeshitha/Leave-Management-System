using Employee_Leave_Managent.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Leave_Managent.Contracts
{
    public interface ILeaveRequestRepository : IRepositoryBase<LeaveRequest>
    {
        ICollection<LeaveRequest> GetLeaveRequestsByEmployee(string employeeid);
    }
}
