using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_RM_StartWork")]
	[Tenant("oldDb")]
    public partial class T_RM_StartWork
    {
           public T_RM_StartWork(){


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
           /// Desc:
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
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? modify {get;set;}

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

    }
}
