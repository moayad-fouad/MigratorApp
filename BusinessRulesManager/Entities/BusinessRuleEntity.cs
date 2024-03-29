﻿namespace BusinessRulesManager.Entities
{
    public class BusinessRuleEntity
    {
        public int? RuleId { set; get; }
        public string EntityName { set; get; }
        public string PropertyName { set; get; }
        public bool? IsRequired { set; get; }
        public bool? IsActive { set; get; }
#nullable enable
        public string? RegEx { set; get; }
        public string? Description { set; get; }
#nullable disable
        public string Origin { set; get; }
        public int? PropertyId { set; get; }

    }
}
