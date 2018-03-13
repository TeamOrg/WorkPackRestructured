using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskDesignationRepository_Contract
    {
        void AddTaskDesignation(params TaskDesignation_Contract[] TaskDesignation);
        IList<TaskDesignation_Contract> GetAllTaskDesignation();
        List<TaskDesignation_Contract> GetTaskDesignationByEstimationTaskID(int EstimationTaskID);
        TaskDesignation_Contract GetTaskDesignationByID(int TaskDesignationID);
        List<TaskDesignation_Contract> GetTaskDesignationByProjectID(int ProjectID);
        List<TaskDesignation_Contract> GetTaskDesignationByProjectTaskID(int ProjectTaskID);
        List<ProjectTaskListCompareCost> GetTaskDesignationDetailsByProjectID(int ProjectID);
        List<object> GetTaskDesignationIDAndNameByProjectTaskID(int ProjectTaskID);
        decimal GetUpdatedHours(int ParentTaskID, int DesignationID, decimal allottedHrs);
        decimal GetUpdatedHoursToOtherDesignation(int ParentTaskID, int selectedDesg, int DesignationID, decimal allottedHrs);
        void InsertIntoTaskDesgnByEstID(int EstimationTaskID);
        void RemoveTaskDesignation(params TaskDesignation_Contract[] TaskDesignation);
        void UpdateTaskDesignation(params TaskDesignation_Contract[] TaskDesignation);
    }
}