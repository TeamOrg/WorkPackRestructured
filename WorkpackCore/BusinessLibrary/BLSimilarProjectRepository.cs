using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using iTextSharp.text;

namespace BusinessLibrary
{
    public class BLSimilarProjectRepository : IBLSimilarProjectRepository
    {
        

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<SimilarProject> _similarProjects;

        public BLSimilarProjectRepository(WorkpackDBContext context, IGenericDataRepository<SimilarProject> similarProjects)
        {
            _context = context;
            _similarProjects = similarProjects;
        }








        public IList<SimilarProject> GetAllSimilarProject()
        {
            return _similarProjects.GetAll();
        }
        public SimilarProject GetSimilarProjectByID(int similarProjectID)
        {
            return _similarProjects.GetSingle(d => d.SimilarProjectID == similarProjectID);
        }
        public void AddSimilarProject(params SimilarProject[] similarProjects)
        {
            try
            {
                _similarProjects.Add(similarProjects);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateSimilarProject(params SimilarProject[] similarProjects)
        {
            try
            {
                _similarProjects.Update(similarProjects);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveSimilarProject(params SimilarProject[] similarProjects)
        {
            try
            {
                _similarProjects.Remove(similarProjects);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }

        public void RemoveSimilarProjectByProjectID(int ProjectID)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        var x = context.SimilarProjects.Where(a => a.ProjectID == ProjectID);
            //        foreach (var item in x)
            //        {
            //            context.SimilarProjects.Remove(item);
            //            context.SaveChanges();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        throw new Exception("Record not deleted.");
            //    }
            //}
        }
        public List<ListItem> GetSimilarProjectRecursiveByProjectID(int ProjectID)
        {
            try
            {
                var iProjectID = ProjectID;
                List<ListItem> SimilarProjectlst = new List<ListItem>();
                List<int> projectids = new List<int>();                
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var q1 = (from q in context.SimilarProjects where q.ProjectID == iProjectID select new {Projectid=q.SimilarProjectID} ).Distinct();
                //    var q2 = (from q in context.SimilarProjects where q.SimilarProjectID == iProjectID select new {Projectid=q.ProjectID}).Distinct();

                //    foreach (var item in q1)
                //    {
                //        projectids.Add(Convert.ToInt32(item.Projectid));
                //    }
                //    foreach (var item in q2)
                //    {
                //        projectids.Add(Convert.ToInt32(item.Projectid));
                //    }

                   
                //    var query = (from p in context.Projects
                //                 where projectids.Contains(p.ProjectID)
                //                 select new { ProjectName = p.ProjectName, ProjectID = p.ProjectID });

                //    foreach (var l in query.ToList().Distinct())
                //    {
                //        SimilarProjectlst.Add(new ListItem(l.ProjectName, l.ProjectID.ToString()));
                //    }

                  


                //}
                return SimilarProjectlst;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Some error occured.");
            }
        }

        public List<ListItem> GetSimilarProjectByProjectID(int ProjectID)
        {
            try
            {
                var iProjectID=ProjectID;
                List<ListItem> SimilarProjectlst = new List<ListItem>();
                List<int> projectids = new List<int>();  
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var q1 = (from q in context.SimilarProjects where q.ProjectID == iProjectID select new { Projectid = q.SimilarProjectID }).Distinct();
                //    var q2 = (from q in context.SimilarProjects where q.SimilarProjectID == iProjectID select new { Projectid = q.ProjectID }).Distinct();

                //    foreach (var item in q1)
                //    {
                //        projectids.Add(Convert.ToInt32(item.Projectid));
                //    }
                //    foreach (var item in q2)
                //    {
                //        projectids.Add(Convert.ToInt32(item.Projectid));
                //    }


                //    var query = (from p in context.Projects
                //                 where projectids.Contains(p.ProjectID)
                //                 select new { ProjectName = p.ProjectName, ProjectID = p.ProjectID });

                //    foreach (var l in query.ToList().Distinct())
                //    {
                //        SimilarProjectlst.Add(new ListItem(l.ProjectName, l.ProjectID.ToString()));
                //    }
                    

                 

                //}
                return SimilarProjectlst;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Some error occured.");
            }
        }
    }
}
