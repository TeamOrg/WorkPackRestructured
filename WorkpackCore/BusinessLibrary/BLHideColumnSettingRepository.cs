using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLHideColumnSettingRepository : IBLHideColumnSettingRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<HideColumnSetting> _hideColumnSetting;

        public BLHideColumnSettingRepository(WorkpackDBContext context, IGenericDataRepository<HideColumnSetting> hideColumnSetting)
        {
            _context = context;
            _hideColumnSetting = hideColumnSetting;
        }
        public IList<HideColumnSetting> GetAllhideColumnSetting()
        {
            return _hideColumnSetting.GetAll();
        }
        public HideColumnSetting GetHideColumnSettingByID(int hideColumnSettingID)
        {
            return _hideColumnSetting.GetSingle(d => d.HideColSettingID == hideColumnSettingID);
        }
        public void AddHideColumnSetting(params HideColumnSetting[] hideColumnSetting)
        {
            try
            {
                _hideColumnSetting.Add(hideColumnSetting);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateHideColumnSetting(params HideColumnSetting[] hideColumnSetting)
        {
            try
            {
                _hideColumnSetting.Update(hideColumnSetting);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveHideColumnSetting(params HideColumnSetting[] hideColumnSetting)
        {
            try
            {
                _hideColumnSetting.Remove(hideColumnSetting);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OperationResult hideColumnSettingMethod(int PId, int ProjectId, int UserId, bool IsChecked)
        {
            OperationResult result = new OperationResult();
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    HideColumnSetting hColSet = context.HideColumnSettings.Where(a => a.ProjectID == ProjectId && a.EstimationTaskColumnID == PId && a.UserID == UserId).SingleOrDefault();
                //    if (hColSet != null)
                //    {
                //        hColSet.IsHide = !IsChecked;
                //        hColSet.EntityState = DominModel.EntityState.Modified;
                //        UpdateHideColumnSetting(hColSet);
                //    }
                //    else
                //    {
                //        HideColumnSetting hColSet1 = new HideColumnSetting();
                //        hColSet1.ProjectID = ProjectId;
                //        hColSet1.UserID = UserId;
                //        hColSet1.EstimationTaskColumnID = PId;
                //        hColSet1.IsHide = !IsChecked;
                //        hColSet1.EntityState = DominModel.EntityState.Added;
                //        AddHideColumnSetting(hColSet1);
                //    }

                //    result.Message = MessageConstants.OperationSuccess;
                //    result.MessageType = "S";
                //}
            }
            catch (Exception ex)
            {
                //result.Message = MessageConstants.errorMsg;
                result.MessageType = "E";
            }

            return result;
        }

        public List<HideColumnSetting> GetAllhideColumnSettingByProjectIdAndUserId(int ProjectId, int UserId)
        {
            List<HideColumnSetting> lst = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.HideColumnSettings.Where(a => a.ProjectID == ProjectId && a.UserID == UserId).ToList<HideColumnSetting>();
                //}
            }
            catch (Exception ex)
            {
            }
            return lst;
        }
    }
}
