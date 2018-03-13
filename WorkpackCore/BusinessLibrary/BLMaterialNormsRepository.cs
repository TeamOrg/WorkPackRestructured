using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLMaterialNormsRepository : IBLMaterialNormsRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<MaterialNorm> _MaterialNorms;

        public BLMaterialNormsRepository(WorkpackDBContext context, IGenericDataRepository<MaterialNorm> MaterialNorms)
        {
            _context = context;
            _MaterialNorms = MaterialNorms;
        }

        public IList<MaterialNorm> GetAllNorms()
        {
            return _MaterialNorms.GetAll().ToList<MaterialNorm>();
        }
        public MaterialNorm GetNormsByID(int MaterialNormsID)
        {
            return _MaterialNorms.GetSingle(d => d.MaterialNormsID == MaterialNormsID);
        }
        public void AddNorms(params MaterialNorm[] MaterialNorms)
        {
            try
            {
                _MaterialNorms.Add(MaterialNorms);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateNorms(params MaterialNorm[] MaterialNorms)
        {
            try
            {
                _MaterialNorms.Update(MaterialNorms);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveNorms(params MaterialNorm[] MaterialNorms)
        {
            try
            {
                _MaterialNorms.Remove(MaterialNorms);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public List<object> GetAllNormsByCompanyID(int? CompanyId = null)
        {
            List<object> list = new List<object>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        list = (from MN in context.MaterialNorms
            //                join MU in context.MaterialUnits on MN.UnitID equals MU.UnitID into Norms
            //                from y in Norms.DefaultIfEmpty()
            //                join Cu in context.Currencies on MN.CurrencyID equals Cu.CurrencyID into prods
            //                from x in prods.DefaultIfEmpty()
            //                where MN.CompanyId == CompanyId
            //                select new
            //                {
            //                    id = MN.MaterialNormsID,
            //                    SrNo = MN.SrNo,
            //                    Description = MN.Description ,
            //                    MaterialCode = (string.IsNullOrEmpty(MN.Code) ? "" : MN.Code),
            //                    Type = MN.Type,
            //                    Make = MN.Make,
            //                    Capacity = MN.Capacity,
            //                    UnitName = y.UnitCode,
            //                    UnitID = MN.UnitID,
            //                    UnitPrice = MN.UnitPrice,
            //                    UnitPriceJS = MN.UnitPriceJS,
            //                    CurrencyCode = x.CurrencyCode,
            //                    CurrencyId = MN.CurrencyID
            //                }).OrderBy(a => a.SrNo).ToList<object>();
            //    }
            //    catch(Exception ex){}
            //}
            return list;
        }


        public List<object> GetAllNormsTypeByCompanyID(int? CompanyId = null)
        {
            List<object> list = new List<object>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = (from MN in context.MaterialNorms                        
            //            where MN.CompanyId == CompanyId && !string.IsNullOrEmpty(MN.Type)
            //            select new
            //            {
            //                id = MN.MaterialNormsID,                            
            //                Type = MN.Type
            //            }).Distinct().OrderBy(a => a.Type).ToList<object>();
            //}
            return list;
        }

        public List<object> GetCurrency(int? CompanyId)
        {
            List<object> list = new List<object>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = (from u in context.Currencies.Where(c => c.CompanyID == CompanyId) select new { CurrencyId = u.CurrencyID, CurrencyCode = u.CurrencyCode }).ToList<object>();
            //}
            return list;
        }

        public List<object> GetUOM(int? CompanyId)
        {
            List<object> list = new List<object>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = (from u in context.MaterialUnits.Where(c => c.CompanyID == CompanyId) select new { UnitID = u.UnitID, UnitName = u.UnitName }).ToList<object>();
            //}
            return list;
        }

        public bool CheckDuplicateandAdd(List<MaterialNorm> lstmate)
        {
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    foreach (var item in lstmate)
                //    {

                //        List<MaterialNorm> mn = context.MaterialNorms.Where(a => a.Description.Contains(item.Description) && a.Type.Contains(item.Type) && a.Capacity.Contains(item.Capacity) && a.Make.Contains(item.Make) && object.Equals(a.CurrencyID, item.CurrencyID) && object.Equals(a.UnitPrice, item.UnitPrice) && object.Equals(a.UnitID, item.UnitID)).ToList();
                        
                //        if (mn.Count == 0)
                //            AddNorms(item);

                //    }
                //}

                return true;
            }

            catch (Exception ex)
            {
                return false;
            }

        }


        public void RearrangeSrNoafterDelete(int? SrNO)
        {

            List<MaterialNorm> lstmatnorm = new List<MaterialNorm>();
            MaterialNorm matnorm = new MaterialNorm();
            //BLMaterialNormsRepository objblmatnorm = new BLMaterialNormsRepository();
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    lstmatnorm = db.MaterialNorms.Where(a => a.SrNo > SrNO).ToList();
                //}
                //if (lstmatnorm.Count() > 0)
                //{                  
                //    lstmatnorm.ForEach(a => { a.SrNo = a.SrNo - 1; a.EntityState = DominModel.EntityState.Modified; });
                //    objblmatnorm.UpdateNorms(lstmatnorm.ToArray());
                //}
            }
            catch (Exception ex)
            {

            }

        }
    }
}
