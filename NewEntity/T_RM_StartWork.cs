using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///开工评审表
    ///</summary>
    [SugarTable("T_RM_StartWork")]
	[Tenant("newDb")]
    public partial class T_RM_StartWork
    {
           public T_RM_StartWork(){


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
           /// Desc:客户名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierName {get;set;}

           /// <summary>
           /// Desc:报价分析
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Analyse {get;set;}

           /// <summary>
           /// Desc:项目团队
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectTeam {get;set;}

           /// <summary>
           /// Desc:项目计划
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectPlan {get;set;}

           /// <summary>
           /// Desc:是否能够修改
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Modify {get;set;}

           /// <summary>
           /// Desc:开工仪式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Rite {get;set;}

           /// <summary>
           /// Desc:技术交底
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TechnicalFile {get;set;}

           /// <summary>
           /// Desc:EHS风险评估
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EHS {get;set;}

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
