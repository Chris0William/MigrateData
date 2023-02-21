using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_RM_Design")]
	[Tenant("oldDb")]
    public partial class T_RM_Design
    {
           public T_RM_Design(){


           }
           /// <summary>
           /// Desc:GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

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
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Creator {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:修改人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Modifier {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ModifyTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? godown {get;set;}

    }
}
