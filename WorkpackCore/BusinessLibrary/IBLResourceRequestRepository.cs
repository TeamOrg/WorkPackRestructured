using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLResourceRequestRepository
    {
        void AddResourceRequest(params ResourceRequest[] ResourceRequest);
        List<ResourceAllocation> DisableAllocatedResources(int ResourceRequestID);
        List<int> GetAllDistinctResources(int ProjectID);
        IList<ResourceRequest> GetAllResourceRequest();
        ResourceRequest GetResourceRequestByID(int ResourceRequestID);
        List<ResourceRequest> GetResourceRequestByProjectID(int ProjectID);
        List<ResourceRequest> GetResourceRequestByProjectIDRequestIDAndDeptID(int ProjectID, int RequestID, int DeptID);
        void RemoveResourceRequestDesignation(params ResourceRequest[] ResourceRequest);
        void UpdateResourceRequest(params ResourceRequest[] ResourceRequest);
    }
}