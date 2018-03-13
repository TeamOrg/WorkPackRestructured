using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLUsedProgressLevelTemplateNPA : IBLUsedProgressLevelTemplateNPA
    {
        

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<UsedProgressLevelTemplateNPA> _usedprogressLevelTemplateNPA;

        public BLUsedProgressLevelTemplateNPA(WorkpackDBContext context, IGenericDataRepository<UsedProgressLevelTemplateNPA> usedprogressLevelTemplateNPA)
        {
            _context = context;
            _usedprogressLevelTemplateNPA = usedprogressLevelTemplateNPA;
        }





        public void AddUsedProgressLevelTemplateNPA(params UsedProgressLevelTemplateNPA[] usedprogressLevelTemplateNPA)
        {
            try
            {
                _usedprogressLevelTemplateNPA.Add(usedprogressLevelTemplateNPA);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProjectProgressLevelTemplate(params UsedProgressLevelTemplateNPA[] usedprogressLevelTemplateNPA)
        {
            try
            {
                _usedprogressLevelTemplateNPA.Update(usedprogressLevelTemplateNPA);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProjectProgressLevelTemplate(params UsedProgressLevelTemplateNPA[] usedprogressLevelTemplateNPA)
        {
            try
            {
                _usedprogressLevelTemplateNPA.Remove(usedprogressLevelTemplateNPA);
            }
            catch (Exception ex)
            {
                throw ex;
              
            }
        }


        public List<UsedProgressLevelTemplateNPA> GetUsedProgressLevelTemplateNPAByProjectIDandTempID(int TemplateID, int TasksettingTempID)
        {
            List<UsedProgressLevelTemplateNPA> obj = new List<UsedProgressLevelTemplateNPA>();

            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    obj = context.UsedProgressLevelTemplateNPAs.Where(a => a.TaskSettingID == TasksettingTempID && a.ProgressLevelTemplateID == TemplateID).ToList();
            ////}

            return obj;
        }

    }
}
