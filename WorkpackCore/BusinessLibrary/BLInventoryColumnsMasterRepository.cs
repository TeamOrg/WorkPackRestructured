using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLInventoryColumnsMasterRepository : IBLInventoryColumnsMasterRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<InventoryColumnsMaster> _inventorycolmasterRepository;

        public BLInventoryColumnsMasterRepository(WorkpackDBContext context, IGenericDataRepository<InventoryColumnsMaster> inventorycolmasterRepository)
        {
            _context = context;
            _inventorycolmasterRepository = inventorycolmasterRepository;
        }
        public IList<InventoryColumnsMaster> GetAllInventoryColumnsMaster()
        {
            return _inventorycolmasterRepository.GetAll().ToList<InventoryColumnsMaster>();
        }
        public InventoryColumnsMaster GetInventoryColumnsMasterByID(Int32 InventoryColumnsMasterID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _inventorycolmasterRepository.GetSingle(d => d.InventoryColumnsID == InventoryColumnsMasterID);
            //include related employees
        }

        public List<InventoryColumnsMaster> GetInventoryColumnsMasterByTranTypeID(Int32 TranTypeID)
        {
            IList<InventoryColumnsMaster> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.InventoryColumnsMasters.Where(a => a.TranTypeID == TranTypeID).ToList<InventoryColumnsMaster>();
                //}
            }
            catch (Exception ex)
            {
            }

            return list.ToList();
        }

        public void AddInventoryColumnsMaster(params InventoryColumnsMaster[] InventoryColumnsMaster)
        {
            /* Validation and error handling omitted */
            try
            {
                _inventorycolmasterRepository.Add(InventoryColumnsMaster);
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
        public void UpdateInventoryColumnsMaster(params InventoryColumnsMaster[] InventoryColumnsMaster)
        {
            /* Validation and error handling omitted */
            try
            {
                _inventorycolmasterRepository.Update(InventoryColumnsMaster);
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
        public void RemoveInventoryColumnsMaster(params InventoryColumnsMaster[] InventoryColumnsMaster)
        {
            /* Validation and error handling omitted */
            try
            {
                _inventorycolmasterRepository.Remove(InventoryColumnsMaster);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public List<GridMaterialReceiptFormCreationColumns> CreateDynamicControls(int TrantypeId)
        {

            List<InventoryColumnsMaster> lstinventorycolMaster = new List<InventoryColumnsMaster>();
            //BLInventoryColumnsMasterRepository blinventoryColMaster = new BLInventoryColumnsMasterRepository();
            //List<InventoryColumnsMaster> lstColMaster = blinventoryColMaster.GetInventoryColumnsMasterByTranTypeID(TrantypeId).ToList<InventoryColumnsMaster>();
            //lstinventorycolMaster = blinventoryColMaster.GetInventoryColumnsMasterByTranTypeID(TrantypeId).ToList<InventoryColumnsMaster>();
            //TranType _trantype = new TranType();
            //BLTranTypeRepository bltrantype = new BLTranTypeRepository();
            //_trantype = bltrantype.GetTranTypeByID(TrantypeId);
            List<GridMaterialReceiptFormCreationColumns> lstcolumn = new List<GridMaterialReceiptFormCreationColumns>();

            try
            {

            //    foreach (var item in lstinventorycolMaster.ToList())
            //    {
            //        if (item.DisplayInGrid == "Y")
            //        {
            //            GridMaterialReceiptFormCreationColumns column = new GridMaterialReceiptFormCreationColumns();
            //            string Group = null;
            //            List<object> lst = new List<object>();
                        
            //            List<MyMaterialReceiptObject> lstObj = (from q in lstinventorycolMaster
            //                                                    where q.InventoryColumnsID == item.InventoryColumnsID
            //                                                    select new MyMaterialReceiptObject
            //                                                    {
            //                                                        DataType = q.DataType,
            //                                                        InputOutput = q.InputOutput,
            //                                                        IsMandatory = q.IsMandatory,
            //                                                        DefaultValue = q.DefaultValue,
            //                                                        PermanentNameInDb = q.PermanentNameInDb,
            //                                                        NameInDb = q.NameInDb,
            //                                                        ValidationMessage = q.ValidationMessage,
            //                                                        TableName = q.TableName,
            //                                                        DBColName = q.DBColName,
            //                                                        Group = Group,
            //                                                        autoCompleteOption = lst,
            //                                                        colId = q.InventoryColumnsID
            //                                                    }).ToList<MyMaterialReceiptObject>();
            //            column.columnDefaultValues = lstObj;
            //            if (Convert.ToString(item.MaterialInventoryColumn as object) != "")
            //            {
            //                column.id = Convert.ToString(item.PermanentNameInDb as object) == string.Empty ? item.NameInDb : item.PermanentNameInDb;
            //                column.IsDropDown = item.IsDropDown;
            //                column.name = item.DisplayColName;
            //                column.columnType = "MaterialReciept";

            //                column.field = item.MaterialInventoryColumn;
            //                column.DataMappingID = item.MaterialInventoryColumn;


            //                column.cssClass = "cell-title";
            //                column.width = 100;

            //                if (Convert.ToString(item.IsDropDown as object) == "Y")
            //                {
            //                    column.editor = "Slick.Editors.YesNoSelect";
            //                    string FilterValue = "";
            //                    string FilterColumn = "";
            //                    if (item.TableName != "PO")
            //                    {
            //                        bindDropdown(item, ref column, FilterColumn, FilterValue);
            //                    }
            //                }
            //                else
            //                {
            //                    if (Convert.ToString(item.DataType as object).ToLower().Contains("number"))
            //                        column.editor = "Slick.Editors.Integer";
            //                    else if (Convert.ToString(item.DataType as object).ToLower().Contains("date"))
            //                        column.editor = "Slick.Editors.Date";
            //                    else
            //                        column.editor = "Slick.Editors.Text";
            //                }
            //                lstcolumn.Add(column);

            //            }

            //        }
            //    }

            }
            catch (Exception ex)
            {
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);

            }
            return lstcolumn;

        }
        private void bindDropdown(InventoryColumnsMaster item, ref GridMaterialReceiptFormCreationColumns column, string FilterColumn, string FilterValue)  // FilterValue in '' if string
        {
            //DropdownBinding drp = new DropdownBinding();
            //NewBLEstimationTaskListRepository blObj = new NewBLEstimationTaskListRepository();
            //List<usp_getDynamicDropdownData_Result> lst = null;
            //{
            //    if (item.TableName == "Stores" || item.TableName == "PO")
            //    {
            //        FilterColumn = "CompanyId";
            //        FilterValue = Convert.ToString(HttpContext.Current.Session["CompanyId"]);
            //    }
            //    lst = blObj.getDynamicDropdownData1(Convert.ToString(item.TableName), Convert.ToString(item.DBColName), FilterColumn, FilterValue).ToList<usp_getDynamicDropdownData_Result>();
            //    drp.options = lst.ToList<object>();
            //}


            //if (item.TableName != "ProjectWBS" && item.TableName != "Priority")
            //{
            //    drp.optionSelect = true;
            //}
            //if (item.IsDbField == null)
            //{
            //    column.DataMappingID = item.MaterialInventoryColumn;
            //    column.field = item.DBColName;
            //}
            //drp.Id = "Id";
            //drp.Name = "Name";
            //column.options = drp;
        }


        public List<usp_GetMaterialItemsbyId_Result> GetMaterialListById(int MaterialNormsID)
        {
            List<usp_GetMaterialItemsbyId_Result> lst = new List<usp_GetMaterialItemsbyId_Result>();
            try
            {
                //using (var dbcontext = new Cubicle_EntityEntities())
                //{
                //    lst = dbcontext.usp_GetMaterialItemsbyId(MaterialNormsID).ToList();
                //}

            }
            catch (Exception ex)
            {
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);

            }
            return lst;
        }

        public List<usp_GetMaterialItems_Result> GetMaterialList(int StoreID, int TypeID, int MaterialNormsID)
        {
            List<usp_GetMaterialItems_Result> lst = new List<usp_GetMaterialItems_Result>();
            try
            {
                //using (var dbcontext = new Cubicle_EntityEntities())
                //{
                //    lst = dbcontext.usp_GetMaterialItems(StoreID, TypeID, MaterialNormsID).ToList();
                //}
            }
            catch (Exception ex)
            {
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);

            }
            return lst;
        }

    }
}
