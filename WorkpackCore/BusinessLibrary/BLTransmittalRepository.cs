using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using CommonLibrary;

namespace BusinessLibrary
{
    public class BLTransmittalRepository : IBLTransmittalRepository
    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Transmittal> _transmittalRepository;

        public BLTransmittalRepository(WorkpackDBContext context, IGenericDataRepository<Transmittal> transmittalRepository)
        {
            _context = context;
            _transmittalRepository = transmittalRepository;
        }




        public IList<Transmittal> GetAllTransmittals()
        {
            return _transmittalRepository.GetAll();
        }
        public Transmittal GetTransmittalByID(Int32 TransmittalID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _transmittalRepository.GetSingle(d => d.TransmittalId == TransmittalID);
            //include related employees
        }

       
        public void AddTransmittal(params Transmittal[] Transmittal)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmittalRepository.Add(Transmittal);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void UpdateTransmittal(params Transmittal[] Transmittal)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmittalRepository.Update(Transmittal);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void RemoveTransmittal(params Transmittal[] Transmittal)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmittalRepository.Remove(Transmittal);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                throw ex;
                //}
            }
        }

        public OperationResult CheckUnique(string value)
        {
            return GetTransmittalByCode(value);
        }

        private OperationResult GetTransmittalByCode(string value)
        {
            OperationResult op = new OperationResult();
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.Transmittals where q.TransmittalNo == value select q).ToList<object>();
            //}

            if (lst.Count() > 0)
            {
                op.MessageType = "e";
            }
            else
            {
                op.MessageType = "s";
            }

            return op;

        }

        public int GetTransmittalsRunningNumber(int ProjectID)
        {

            List<object> lst = null;
            int Icount = 0;
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    lst = (from q in context.Transmittals where q.ProjectId == ProjectID && q.TransmittalNo != "" select q).ToList<object>();
            ////}

            if (lst.Count() > 0)
            {
                Icount = lst.Count() + 1;
            }
            else
            {
                Icount = lst.Count() + 1;
            }

            return Icount;

        }

        public List<usp_getTransmittalDetails_Result> GetgetTransmittalDetails(string UserID)
        {
            List<usp_getTransmittalDetails_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.usp_getTransmittalDetails(UserID).ToList<usp_getTransmittalDetails_Result>();
            //}
            return lst;
        }

        public List<object> GetTransmittal(int TransmittalId)
        {
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var lstR = (from q in context.Transmittals
            //                join r in context.Projects on q.ProjectId equals r.ProjectID
            //                where q.TransmittalId == TransmittalId
            //                select new
            //                {
            //                    q.TransmittalId,
            //                    q.TransmittalTitle,
            //                    q.TransmittalNo,
            //                    q.Remarks,
            //                    ProjectName = r.ProjectName
            //                });
            //    lst = lstR.ToList<object>();
            //}
            return lst;
        }

        public List<usp_getViewTransmittalDetails_Result> GetViewgetTransmittalDetails(int TransmittalId, string UserId)
        {
            List<usp_getViewTransmittalDetails_Result> lst = null;
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    lst = context.usp_getViewTransmittalDetails(TransmittalId, UserId).ToList<usp_getViewTransmittalDetails_Result>();
            ////}
            return lst;
        }

        public List<object> GetTransmittalUser(int transmittalId)
        {
            List<object> lst = null;
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    lst = context.usp_GetTransmittalUser(transmittalId).ToList<object>();
            ////}
            return lst;
        }

        
    }
}
