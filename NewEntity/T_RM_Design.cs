using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///设计评审表
    ///</summary>
    [SugarTable("T_RM_Design")]
	[Tenant("newDb")]
    public partial class T_RM_Design
    {
           public T_RM_Design(){


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
           /// Desc:父级ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ParentID {get;set;}

           /// <summary>
           /// Desc:评审类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Type {get;set;}

           /// <summary>
           /// Desc:总的审核进度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Allprogress {get;set;}

           /// <summary>
           /// Desc:设计流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DesignType {get;set;}

           /// <summary>
           /// Desc:电气评审
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ElecOpinion {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? modify {get;set;}

           /// <summary>
           /// Desc:暖通评审
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HeatOpinion {get;set;}

           /// <summary>
           /// Desc:土建评审
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CivilOpinion {get;set;}

           /// <summary>
           /// Desc:工艺评审
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CraftOpinion {get;set;}

           /// <summary>
           /// Desc:自控评审
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AutoControlOpinion {get;set;}

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
           public bool? godown {get;set;}

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
