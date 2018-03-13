using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLSkillRepository
    {
        void AddSkill(params Skill[] skill);
        bool CheckDuplicate(Skill skill, bool IsInsert);
        IList<Skill> GetAllSkills();
        Skill GetSkillByID(int skillID);
        IList<Skill> GetSkillList(Skill skill);
        void RemoveSkill(params Skill[] skill);
        void UpdateSkill(params Skill[] skill);
    }
}