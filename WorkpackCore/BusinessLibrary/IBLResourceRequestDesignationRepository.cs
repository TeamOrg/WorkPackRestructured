using System.Collections.Generic;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{
    public interface IBLResourceRequestDesignationRepository
    {
        void AddResourceRequestDesignation(params ResourceRequestDesignation[] ResourceRequestDesignation);
        DataTable GetActualResources(int ProjectID);
        IList<ResourceRequestDesignation> GetAllResourceRequestDesignation();
        List<ResourceRequestDesignation> GetAllResourceRequestDesignationByResourceRequest(int ResourceRequestID);
        ResourceRequestDesignation GetResourceRequestDesignationByID(int ResourceRequestDesignationID);
        void RemoveResourceRequestDesignation(params ResourceRequestDesignation[] ResourceRequestDesignation);
        void UpdateResourceRequestDesignation(params ResourceRequestDesignation[] ResourceRequestDesignation);
    }
}