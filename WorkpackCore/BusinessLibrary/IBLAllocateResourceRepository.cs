using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLAllocateResourceRepository
    {
        List<ResourceAllocation> AllocatedResourcesByProjectID(int ProjectID);
        List<ResourceAllocation> chkIsFocalPointByProjectID(int ProjectID, int UserID);
        IList<ResourceAllocation> GetAllResourceAllocation();
        void RemoveResourceRequestAllocation(params ResourceAllocation[] ResourceAllocation);
    }
}