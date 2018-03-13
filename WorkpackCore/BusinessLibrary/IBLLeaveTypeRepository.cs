using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLLeaveTypeRepository
    {
        void AddLeaveType(params LeaveType[] LeaveType);
        bool CheckDuplicate(LeaveType LeaveType, bool IsInsert);
        IList<LeaveType> GetAllLeaveTypes();
        LeaveType GetLeaveTypeByID(int LeaveTypeID);
        IList<LeaveType> GetLeaveTypeList(LeaveType LeaveType);
        void RemoveLeaveType(params LeaveType[] LeaveType);
        void UpdateLeaveType(params LeaveType[] LeaveType);
    }
}