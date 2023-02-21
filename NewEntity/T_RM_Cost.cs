using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///成本评审表
    ///</summary>
    [SugarTable("T_RM_Cost")]
	[Tenant("newDb")]
    public partial class T_RM_Cost
    {
           public T_RM_Cost(){


           }
           /// <summary>
           /// Desc:GUID主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
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
           /// Desc:审核进度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditProgress {get;set;}

           /// <summary>
           /// Desc:审核结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditResult {get;set;}

           /// <summary>
           /// Desc:客户预算
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Budget {get;set;}

           /// <summary>
           /// Desc:成本汇总
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Cost {get;set;}

           /// <summary>
           /// Desc:是否可以修改
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Modify {get;set;}

           /// <summary>
           /// Desc:评审意见
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Suggestion {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

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
           /// Desc:创建者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

           /// <summary>
           /// Desc:修改者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:修改者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:软删除
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
