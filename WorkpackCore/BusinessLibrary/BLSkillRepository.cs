using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLSkillRepository : IBLSkillRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Skill> _skillRepository;
        public BLSkillRepository(WorkpackDBContext context, IGenericDataRepository<Skill> skillRepository)
        {
           _context = context;
           _skillRepository = skillRepository;
        }
        public IList<Skill> GetAllSkills()
        {
           return _skillRepository.GetAll();
        } 
        public Skill GetSkillByID(Int32 skillID)
        {
           //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
           return _skillRepository.GetSingle(d => d.SkillID == skillID);                
           //include related employees
        }        
        public void AddSkill(params Skill[] skill)
        {
            /* Validation and error handling omitted */
            try
            {
                _skillRepository.Add(skill);
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
        public void UpdateSkill(params Skill[] skill)
        {
            /* Validation and error handling omitted */
            try
            {
                _skillRepository.Update(skill);
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
        public void RemoveSkill(params Skill[] skill)
        {
            /* Validation and error handling omitted */
            try
            {
                _skillRepository.Remove(skill);
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
        public Boolean CheckDuplicate(Skill skill,Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _skillRepository.GetSingle(p => p.SkillName.ToUpper() == skill.SkillName.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.SkillID == skill.SkillID)
                        Result = true;
                    else
                        Result = false;
                }
                else
                {
                    if (c == null)
                        Result = true;
                    else
                        Result = false;
                }
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return Result;
        }
        public IList<Skill> GetSkillList(Skill skill)
        {
            IList<Skill> fetchedSkill = new List<Skill>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<Skill> query = Context.Skills;
                //    if (skill.SkillName != string.Empty)
                //        query = query.Where(p => p.SkillName.ToUpper().Contains(skill.SkillName.ToUpper()));
                //    fetchedSkill = query.ToList();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return fetchedSkill;
        }
    }
}
