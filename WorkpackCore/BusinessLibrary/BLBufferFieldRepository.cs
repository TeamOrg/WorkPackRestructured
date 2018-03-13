using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLBufferFieldRepository : IBLBufferFieldRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<BufferField> _bufferField;

        public BLBufferFieldRepository(WorkpackDBContext context, IGenericDataRepository<BufferField> bufferField)
        {
            _context = context;
            _bufferField = bufferField;
        }
        public List<BufferField> GetAllBufferField()
        {
            List<BufferField> lstTask = new List<BufferField>();

            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    lstTask = (from q in db.BufferFields select q).ToList<BufferField>();
                //}
            }
            catch (Exception ex)
            {
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return lstTask;
        }

        public List<object> GetBufferField()
        {
            List<object> lstTask = new List<object>();

            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    lstTask = (from q in db.BufferFields
                //               select new
                //               {
                //                   id = q.Id,
                //                   Status = q.Status,
                //                   Label = q.Label
                //               }).ToList<object>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return lstTask;
        }
        public BufferField GetBufferFieldByID(int Id)
        {
            return _bufferField.GetSingle(d => d.Id == Id);
        }
        public void AddBufferField(params BufferField[] BufferField)
        {
            try
            {
                _bufferField.Add(BufferField);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateBufferField(params BufferField[] BufferField)
        {
            try
            {
                _bufferField.Update(BufferField);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveBufferField(params BufferField[] BufferField)
        {
            try
            {
                _bufferField.Remove(BufferField);
            }
            catch (Exception ex)
            {
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }
        public List<object> GetBufferDropDownData(int bufferfieldid)
        {
            List<object> lstTask = new List<object>();
            string DropdownTitle = "";
            try
            {

                //using (var db = new Cubicle_EntityEntities())
                //{
                //    DropdownTitle = db.BufferFields.Where(a => a.Id == bufferfieldid).Select(a => a.DropdownTitle).FirstOrDefault();


                //    if (DropdownTitle == "Currency")  //Dropdown1 is for currency
                //    {
                //        lstTask = (from q in db.Currencies
                //                   select new
                //                   {
                //                       id = q.CurrencyID,
                //                       ItemName = q.CurrencyName,
                //                       ItemCode = q.CurrencyCode
                //                   }).ToList<object>();
                //    }
                //    else if (DropdownTitle == "MaterialUnits")  //Dropdown2 is for MaterialUnit
                //    {
                //        lstTask = (from q in db.MaterialUnits
                //                   select new
                //                   {
                //                       id = q.UnitID,
                //                       ItemName = q.UnitName,
                //                       ItemCode = q.UnitCode
                //                   }).ToList<object>();
                //    }
                //    else if (DropdownTitle == "TaxCode") //Dropdown3 is for TaxCode
                //    {
                //        lstTask = (from q in db.TaxCodes
                //                   select new
                //                   {
                //                       id = q.Taxcodeid,
                //                       ItemName = q.Description,
                //                       ItemCode = q.TaxAmount,
                //                       Istaxfield = "Y"
                //                   }).ToList<object>();
                //    }
                //    else if (DropdownTitle == "Dropdown4")
                //    {
                //        lstTask = (from q in db.Dropdown4
                //                   select new
                //                   {
                //                       id = q.ItemId,
                //                       ItemName = q.ItemName,
                //                       ItemCode = q.ItemCode
                //                   }).ToList<object>();
                //    }
                //    else if (DropdownTitle == "Dropdown5")
                //    {
                //        lstTask = (from q in db.Dropdown5
                //                   select new
                //                   {
                //                       id = q.ItemId,
                //                       ItemName = q.ItemName,
                //                       ItemCode = q.ItemCode
                //                   }).ToList<object>();
                //    }
                //    else if (DropdownTitle == "Dropdown6")
                //    {

                //        lstTask = (from q in db.Dropdown6
                //                   select new
                //                   {
                //                       id = q.ItemId,
                //                       ItemName = q.ItemName,
                //                       ItemCode = q.ItemCode
                //                   }).ToList<object>();
                //    }
                //    else if (DropdownTitle == "Dropdown7")
                //    {

                //        lstTask = (from q in db.Dropdown7
                //                   select new
                //                   {
                //                       id = q.ItemId,
                //                       ItemName = q.ItemName,
                //                       ItemCode = q.ItemCode
                //                   }).ToList<object>();
                //    }
                //    else if (DropdownTitle == "Dropdown8")
                //    {
                //        lstTask = (from q in db.Dropdown8
                //                   select new
                //                   {
                //                       id = q.ItemId,
                //                       ItemName = q.ItemName,
                //                       ItemCode = q.ItemCode
                //                   }).ToList<object>();
                //    }
                //    else if (DropdownTitle == "Dropdown9")
                //    {
                //        lstTask = (from q in db.Dropdown9
                //                   select new
                //                   {
                //                       id = q.ItemId,
                //                       ItemName = q.ItemName,
                //                       ItemCode = q.ItemCode
                //                   }).ToList<object>();
                //    }
                //    else if (DropdownTitle == "Dropdown10")
                //    {
                //        lstTask = (from q in db.Dropdown10
                //                   select new
                //                   {
                //                       id = q.ItemId,
                //                       ItemName = q.ItemName,
                //                       ItemCode = q.ItemCode
                //                   }).ToList<object>();
                //    }

                //}
            }
            catch (Exception ex)
            {
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return lstTask;
        }

        public string UpdateBufferDropDownData(int bufferfieldid, int ItemID, string ItemName, string ItemCode)
        {
            string result = "F";
            List<object> lstTask = new List<object>();
            BufferField bf = new BufferField();
            string DropdownTitle = "";
            try
            {

                //using (var db = new Cubicle_EntityEntities())
                //{
                //    DropdownTitle = db.BufferFields.Where(a => a.Id == bufferfieldid).Select(a => a.DropdownTitle).FirstOrDefault();
                //}
                //if (DropdownTitle == "Currency")  //Dropdown1 is for currency
                //{
                //    BLCurrencyRepository objCurr = new BLCurrencyRepository();
                //    Currency Cu = new Currency();
                //    Cu = objCurr.GetCurrencyID(ItemID);
                //    Cu.CurrencyName = ItemName;
                //    Cu.CurrencyCode = ItemCode;
                //    Cu.EntityState = EntityState.Modified;
                //    objCurr.UpdateCurrency(Cu);
                //    result = "S";

                //}
                //else if (DropdownTitle == "MaterialUnits")  //Dropdown2 is for MaterialUnit
                //{
                //    BLMaterialUnit objmat = new BLMaterialUnit();
                //    MaterialUnit Mat = new MaterialUnit();
                //    Mat = objmat.GetMaterialUnitBYID(ItemID);
                //    Mat.UnitName = ItemName;
                //    Mat.UnitCode = ItemCode;
                //    Mat.EntityState = EntityState.Modified;
                //    objmat.UpdateMaterialUnit(Mat);
                //    result = "S";
                //}
                //else if (DropdownTitle == "TaxCode") //Dropdown3 is for TaxCode
                //{
                //    BLTaxCodeRepository objmat = new BLTaxCodeRepository();
                //    TaxCode Mat = new TaxCode();
                //    Mat = objmat.GetTaxCodeByID(ItemID);
                //    Mat.Description = ItemName;
                //    Mat.TaxAmount = Convert.ToDecimal(ItemCode); //TaxAmount accepts only decimal values
                //    Mat.EntityState = EntityState.Modified;
                //    objmat.UpdateTaxCode(Mat);
                //    result = "S";
                //}
                //else if (DropdownTitle == "Dropdown4")
                //{
                //    BLDropDown4Repository bldrop = new BLDropDown4Repository();
                //    Dropdown4 dropdown = new Dropdown4();
                //    dropdown = bldrop.GetDropDown4ByID(ItemID);
                //    dropdown.ItemName = ItemName;
                //    dropdown.ItemCode = ItemCode;
                //    dropdown.EntityState = EntityState.Modified;
                //    bldrop.UpdateDropDown4(dropdown);
                //}
                //else if (DropdownTitle == "Dropdown5")
                //{
                //    BLDropDown5Repository bldrop = new BLDropDown5Repository();
                //    Dropdown5 dropdown = new Dropdown5();
                //    dropdown = bldrop.GetDropDown5ByID(ItemID);
                //    dropdown.ItemName = ItemName;
                //    dropdown.ItemCode = ItemCode;
                //    dropdown.EntityState = EntityState.Modified;
                //    bldrop.UpdateDropDown5(dropdown);
                //}
                //else if (DropdownTitle == "Dropdown6")
                //{

                //    BLDropDown6Repository bldrop = new BLDropDown6Repository();
                //    Dropdown6 dropdown = new Dropdown6();
                //    dropdown = bldrop.GetDropDown6ByID(ItemID);
                //    dropdown.ItemName = ItemName;
                //    dropdown.ItemCode = ItemCode;
                //    dropdown.EntityState = EntityState.Modified;
                //    bldrop.UpdateDropDown6(dropdown);
                //}
                //else if (DropdownTitle == "Dropdown7")
                //{
                //    BLDropDown7Repository bldrop = new BLDropDown7Repository();
                //    Dropdown7 dropdown = new Dropdown7();
                //    dropdown = bldrop.GetDropDown7ByID(ItemID);
                //    dropdown.ItemName = ItemName;
                //    dropdown.ItemCode = ItemCode;
                //    dropdown.EntityState = EntityState.Modified;
                //    bldrop.UpdateDropDown7(dropdown);
                //}
                //else if (DropdownTitle == "Dropdown8")
                //{
                //    BLDropDown8Repository bldrop = new BLDropDown8Repository();
                //    Dropdown8 dropdown = new Dropdown8();
                //    dropdown = bldrop.GetDropDown8ByID(ItemID);
                //    dropdown.ItemName = ItemName;
                //    dropdown.ItemCode = ItemCode;
                //    dropdown.EntityState = EntityState.Modified;
                //    bldrop.UpdateDropDown8(dropdown);
                //}
                //else if (DropdownTitle == "Dropdown9")
                //{
                //    BLDropDown9Repository bldrop = new BLDropDown9Repository();
                //    Dropdown9 dropdown = new Dropdown9();
                //    dropdown = bldrop.GetDropDown9ByID(ItemID);
                //    dropdown.ItemName = ItemName;
                //    dropdown.ItemCode = ItemCode;
                //    dropdown.EntityState = EntityState.Modified;
                //    bldrop.UpdateDropDown9(dropdown);
                //}
                //else if (DropdownTitle == "Dropdown10")
                //{
                //    BLDropDown10Repository bldrop = new BLDropDown10Repository();
                //    Dropdown10 dropdown = new Dropdown10();
                //    dropdown = bldrop.GetDropDown10ByID(ItemID);
                //    dropdown.ItemName = ItemName;
                //    dropdown.ItemCode = ItemCode;
                //    dropdown.EntityState = EntityState.Modified;
                //    bldrop.UpdateDropDown10(dropdown);
                //}
            }

            catch (Exception ex)
            {
              //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return result;
        }
        public string AddBufferDropDownData(int bufferfieldid, string ItemName, string ItemCode)
        {
            string result = "F";
            string DropdownTitle = "";
            //BLUserRepository bluser = new BLUserRepository();
            //int? CompanyID = bluser.GetuserByID(Convert.ToInt32(HttpContext.Current.Session["UserId"])).CompanyId;
            //int? compid = CompanyID > 0 ? CompanyID : null;
            //try
            //{

            //    using (var db = new Cubicle_EntityEntities())
            //    {
            //        DropdownTitle = db.BufferFields.Where(a => a.Id == bufferfieldid).Select(a => a.DropdownTitle).FirstOrDefault();
            //    }
            //    if (DropdownTitle == "Currency")  //Dropdown1 is for currency
            //    {
            //        BLCurrencyRepository objCurr = new BLCurrencyRepository();
            //        Currency Cu = new Currency();
            //        Cu.CurrencyName = ItemName;
            //        Cu.CurrencyCode = ItemCode;
            //        Cu.CompanyID = compid;
            //        Cu.EntityState = EntityState.Added;

            //        objCurr.AddCurrency(Cu);
            //        result = "S";

            //    }
            //    else if (DropdownTitle == "MaterialUnits")  //Dropdown2 is for MaterialUnit
            //    {
            //        BLMaterialUnit objmat = new BLMaterialUnit();
            //        MaterialUnit Mat = new MaterialUnit();
            //        Mat.UnitName = ItemName;
            //        Mat.UnitCode = ItemCode;
            //        Mat.CompanyID = compid;
            //        Mat.EntityState = EntityState.Added;
            //        objmat.AddMaterialUnit(Mat);
            //        result = "S";
            //    }
            //    else if (DropdownTitle == "TaxCode") //Dropdown3 is for TaxCode
            //    {
            //        BLTaxCodeRepository objmat = new BLTaxCodeRepository();
            //        TaxCode Mat = new TaxCode();
            //        Mat.Description = ItemName;
            //        Mat.TaxAmount = Convert.ToDecimal(ItemCode); //TaxAmount accepts only decimal values
            //        //Mat.CompanyID = compid;
            //        Mat.EntityState = EntityState.Added;
            //        objmat.AddTaxCode(Mat);
            //        result = "S_Tax";
            //    }
            //    else if (DropdownTitle == "Dropdown4")
            //    {
            //        BLDropDown4Repository bldrop = new BLDropDown4Repository();
            //        Dropdown4 dropdown = new Dropdown4();
            //        dropdown.ItemName = ItemName;
            //        dropdown.ItemCode = ItemCode;
            //        dropdown.CompanyID = compid;
            //        dropdown.EntityState = EntityState.Added;
            //        bldrop.AddDropDown4(dropdown);
            //    }
            //    else if (DropdownTitle == "Dropdown5")
            //    {
            //        BLDropDown5Repository bldrop = new BLDropDown5Repository();
            //        Dropdown5 dropdown = new Dropdown5();
            //        dropdown.ItemName = ItemName;
            //        dropdown.ItemCode = ItemCode;
            //        dropdown.CompanyID = compid;
            //        dropdown.EntityState = EntityState.Added;
            //        bldrop.AddDropDown5(dropdown);
            //    }
            //    else if (DropdownTitle == "Dropdown6")
            //    {

            //        BLDropDown6Repository bldrop = new BLDropDown6Repository();
            //        Dropdown6 dropdown = new Dropdown6();
            //        dropdown.ItemName = ItemName;
            //        dropdown.ItemCode = ItemCode;
            //        dropdown.CompanyID = compid;
            //        dropdown.EntityState = EntityState.Added;
            //        bldrop.AddDropDown6(dropdown);
            //    }
            //    else if (DropdownTitle == "Dropdown7")
            //    {
            //        BLDropDown7Repository bldrop = new BLDropDown7Repository();
            //        Dropdown7 dropdown = new Dropdown7();
            //        dropdown.ItemName = ItemName;
            //        dropdown.ItemCode = ItemCode;
            //        dropdown.CompanyID = compid;
            //        dropdown.EntityState = EntityState.Added;
            //        bldrop.AddDropDown7(dropdown);
            //    }
            //    else if (DropdownTitle == "Dropdown8")
            //    {
            //        BLDropDown8Repository bldrop = new BLDropDown8Repository();
            //        Dropdown8 dropdown = new Dropdown8();
            //        dropdown.ItemName = ItemName;
            //        dropdown.ItemCode = ItemCode;
            //        dropdown.CompanyID = compid;
            //        dropdown.EntityState = EntityState.Added;
            //        bldrop.AddDropDown8(dropdown);
            //    }
            //    else if (DropdownTitle == "Dropdown9")
            //    {
            //        BLDropDown9Repository bldrop = new BLDropDown9Repository();
            //        Dropdown9 dropdown = new Dropdown9();
            //        dropdown.ItemName = ItemName;
            //        dropdown.ItemCode = ItemCode;
            //        dropdown.CompanyID = compid;
            //        dropdown.EntityState = EntityState.Added;
            //        bldrop.AddDropDown9(dropdown);
            //    }
            //    else if (DropdownTitle == "Dropdown10")
            //    {
            //        BLDropDown10Repository bldrop = new BLDropDown10Repository();
            //        Dropdown10 dropdown = new Dropdown10();
            //        dropdown.ItemName = ItemName;
            //        dropdown.ItemCode = ItemCode;
            //        dropdown.CompanyID = compid;
            //        dropdown.EntityState = EntityState.Added;
            //        bldrop.AddDropDown10(dropdown);
            //    }

            //}

            //catch (Exception ex)
            //{
            //    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //}
            return result;
        }
        public string DeleteBufferDropDownData(int bufferfieldid, int ItemID)
        {
            string result = "F";
            //List<object> lstTask = new List<object>();
            //BufferField bf = new BufferField();
            //string DropdownTitle = "";
            //try
            //{
            //    using (var db = new Cubicle_EntityEntities())
            //    {
            //        DropdownTitle = db.BufferFields.Where(a => a.Id == bufferfieldid).Select(a => a.DropdownTitle).FirstOrDefault();
            //    }
            //    if (DropdownTitle == "Currency")  //Dropdown1 is for currency
            //    {
            //        BLCurrencyRepository objCurr = new BLCurrencyRepository();
            //        Currency Cu = new Currency();
            //        Cu = objCurr.GetCurrencyID(ItemID);
            //        Cu.EntityState = EntityState.Deleted;
            //        objCurr.RemoveCurrency(Cu);
            //        result = "S";

            //    }
            //    else if (DropdownTitle == "MaterialUnits")  //Dropdown2 is for MaterialUnit
            //    {
            //        BLMaterialUnit objmat = new BLMaterialUnit();
            //        MaterialUnit Mat = new MaterialUnit();
            //        Mat = objmat.GetMaterialUnitBYID(ItemID);
            //        Mat.EntityState = EntityState.Deleted;
            //        objmat.RemoveMaterialUnit(Mat);
            //        result = "S";
            //    }
            //    else if (DropdownTitle == "TaxCode") //Dropdown3 is for TaxCode
            //    {
            //        BLTaxCodeRepository objmat = new BLTaxCodeRepository();
            //        TaxCode Mat = new TaxCode();
            //        Mat = objmat.GetTaxCodeByID(ItemID);
            //        Mat.EntityState = EntityState.Deleted;
            //        objmat.RemoveTaxCode(Mat);
            //        result = "S";
            //    }
            //    else if (DropdownTitle == "Dropdown4")
            //    {
            //        BLDropDown4Repository bldrop = new BLDropDown4Repository();
            //        Dropdown4 dropdown = new Dropdown4();
            //        dropdown = bldrop.GetDropDown4ByID(ItemID);
            //        dropdown.EntityState = EntityState.Deleted;
            //        bldrop.RemoveDropDown4(dropdown);
            //        result = "S";
            //    }
            //    else if (DropdownTitle == "Dropdown5")
            //    {
            //        BLDropDown5Repository bldrop = new BLDropDown5Repository();
            //        Dropdown5 dropdown = new Dropdown5();
            //        dropdown = bldrop.GetDropDown5ByID(ItemID);
            //        dropdown.EntityState = EntityState.Deleted;
            //        bldrop.RemoveDropDown5(dropdown);
            //        result = "S";
            //    }
            //    else if (DropdownTitle == "Dropdown6")
            //    {

            //        BLDropDown6Repository bldrop = new BLDropDown6Repository();
            //        Dropdown6 dropdown = new Dropdown6();
            //        dropdown = bldrop.GetDropDown6ByID(ItemID);
            //        dropdown.EntityState = EntityState.Deleted;
            //        bldrop.RemoveDropDown6(dropdown);
            //        result = "S";
            //    }
            //    else if (DropdownTitle == "Dropdown7")
            //    {
            //        BLDropDown7Repository bldrop = new BLDropDown7Repository();
            //        Dropdown7 dropdown = new Dropdown7();
            //        dropdown = bldrop.GetDropDown7ByID(ItemID);
            //        dropdown.EntityState = EntityState.Deleted;
            //        bldrop.RemoveDropDown7(dropdown);
            //        result = "S";
            //    }
            //    else if (DropdownTitle == "Dropdown8")
            //    {
            //        BLDropDown8Repository bldrop = new BLDropDown8Repository();
            //        Dropdown8 dropdown = new Dropdown8();
            //        dropdown = bldrop.GetDropDown8ByID(ItemID);
            //        dropdown.EntityState = EntityState.Deleted;
            //        bldrop.RemoveDropDown8(dropdown);
            //        result = "S";
            //    }
            //    else if (DropdownTitle == "Dropdown9")
            //    {
            //        BLDropDown9Repository bldrop = new BLDropDown9Repository();
            //        Dropdown9 dropdown = new Dropdown9();
            //        dropdown = bldrop.GetDropDown9ByID(ItemID);
            //        dropdown.EntityState = EntityState.Deleted;
            //        bldrop.RemoveDropDown9(dropdown);
            //        result = "S";
            //    }
            //    else if (DropdownTitle == "Dropdown10")
            //    {
            //        BLDropDown10Repository bldrop = new BLDropDown10Repository();
            //        Dropdown10 dropdown = new Dropdown10();
            //        dropdown = bldrop.GetDropDown10ByID(ItemID);
            //        dropdown.EntityState = EntityState.Deleted;
            //        bldrop.RemoveDropDown10(dropdown);
            //        result = "S";
            //    }
            //}

            //catch (Exception ex)
            //{
            //    string msg = ex.InnerException.InnerException.Message.ToString();
            //    if (msg.Contains("REFERENCE"))
            //    {
            //        //result = MessageConstants.DatabaseRelationError;
            //        // Common.GeneralFuntions.ShowMessage("I", "", MessageConstants.DatabaseRelationError, 200, positionArray);
            //    }
            //    else
            //    {
            //        //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //        //result = MessageConstants.errorMsg;
            //        //Common.GeneralFuntions.ShowMessage("E", "", MessageConstants.errorMsg, 200, positionArray);
            //    }
            //}
            return result;
        }

        public bool SetBufferFiledActiveInactive(int bufferfieldid, string Status)
        {
            bool result = false;
            //List<object> lstTask = new List<object>();
            //BufferField bf = new BufferField();
            //NormsManageTable NT = new NormsManageTable();
            //NormsManageTableColumn NTC = new NormsManageTableColumn();
            //BLNormsManageTableRepository objnorms = new BLNormsManageTableRepository();
            //BLNormsManageTableCoulumnRepository blnormstablcol = new BLNormsManageTableCoulumnRepository();
            //string NMTableColName = "";
            //string NMTableColumn = "";

            //string DropdownTitle = "";
            //try
            //{
            //    //using (var db = new Cubicle_EntityEntities())
            //    //{
            //    //    DropdownTitle = db.BufferFields.Where(a => a.Id == bufferfieldid).Select(a => a.DropdownTitle).FirstOrDefault();
            //    //    NT = db.NormsManageTables.Where(a => a.NormsManageTableName == DropdownTitle).FirstOrDefault();
            //    //}
            //    if (NT != null)
            //    {
            //        NT.IsActive = Status;
            //        NT.EntityState = EntityState.Modified;
            //        objnorms.UpdateNormsManageTable(NT);
            //        result = true;
            //    }
            //    else
            //    {
            //        NT = new NormsManageTable();
            //        NT.NormsManageTableName = DropdownTitle;
            //        NT.IsActive = Status;
            //        NT.EntityState = EntityState.Added;
            //        objnorms.AddNormsManageTable(NT);
            //        int idd = NT.NormsManageTableID;
            //        if (DropdownTitle == "Currency")  //Dropdown1 is for currency
            //        {                       
            //            NMTableColName = "CurrencyID";
            //           // NMTableColumn="CurrencyCode";
            //        }
            //        else if (DropdownTitle == "MaterialUnits")  //Dropdown2 is for MaterialUnit
            //        {
            //            NMTableColName = "UnitID";
            //            //NMTableColumn="UnitName ";
            //        }
            //        else if (DropdownTitle == "TaxCode") //Dropdown3 is for TaxCode
            //        {
            //            NMTableColName = "Taxcodeid";
            //            //NMTableColumn ="Description";
            //        }
            //        else if (DropdownTitle == "Dropdown4" || DropdownTitle == "Dropdown5" || DropdownTitle == "Dropdown6" || DropdownTitle == "Dropdown7" || DropdownTitle == "Dropdown8" || DropdownTitle == "Dropdown8" || DropdownTitle == "Dropdown9" || DropdownTitle == "Dropdown10")
            //        {
            //            NMTableColName = "ItemCode";
            //           // NMTableColumn ="ItemName";                                            
            //        }
            //        NTC.NormsManageTableID = NT.NormsManageTableID;
            //        NTC.NormsManageTableColName = NMTableColName;
            //       //NTC.NormsManageMasterTable = DropdownTitle;
            //        //NTC.NormsManageMasterTableColumn = NMTableColumn;
            //        NTC.EntityState = EntityState.Added;
            //        blnormstablcol.AddNormsManageTableCoulumn(NTC);
            //        result = true;
            //    }
                
            //}

            //catch (Exception ex)
            //{
            //    string msg = ex.InnerException.InnerException.Message.ToString();
            //    if (msg.Contains("REFERENCE"))
            //    {
            //        result = false;// MessageConstants.DatabaseRelationError;
            //    }
            //    else
            //    {
            //        //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //        result = false;//MessageConstants.errorMsg;
            //    }
            //}
            return result;
        }



    }


}
