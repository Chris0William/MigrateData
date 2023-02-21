using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///完工评审表
    ///</summary>
    [SugarTable("T_RM_EndWork")]
	[Tenant("newDb")]
    public partial class T_RM_EndWork
    {
           public T_RM_EndWork(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Id {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:评审编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ReviewNo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditProgress {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditResult {get;set;}

           /// <summary>
           /// Desc:项目进度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProSchedule {get;set;}

           /// <summary>
           /// Desc:质量情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Quality {get;set;}

           /// <summary>
           /// Desc:安全情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Security {get;set;}

           /// <summary>
           /// Desc:是否能够修改
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Modify {get;set;}

           /// <summary>
           /// Desc:成本情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Cost {get;set;}

           /// <summary>
           /// Desc:客户满意度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Satisfaction {get;set;}

           /// <summary>
           /// Desc:评审意见
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Suggestion {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
