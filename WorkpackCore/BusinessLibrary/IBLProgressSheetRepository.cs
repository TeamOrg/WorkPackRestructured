using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProgressSheetRepository
    {
        void AddprogressSheet(params ProgressSheet[] progressSheet);
        OperationResult AddUpdateProgressSheetResult(string ProjectID, string UserID, Dictionary<string, string[]> item, string ProjectTaskID, string DeviationJustification, string TaskTypeID, string TaskCancelledDate, string JoiningDate);
        IList<ProgressSheet> GetAllprogressSheet();
        ProgressSheet GetprogressSheetByID(int progressSheetID);
        IList<ProgressSheet> GetProgressSheetRecordsByTaskIDMilestoneID(int TaskID, int Milestone);
        void RemoveprogressSheet(params ProgressSheet[] progressSheet);
        void UpdateprogressSheet(params ProgressSheet[] progressSheet);
        void UpdateprogressSheetDormantUser(int User, int ProjectTaskID, int ProjectID, int ProgressID, DateTime ActualDate, int TaskType, string Deviation);
    }
}