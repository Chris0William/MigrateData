using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_RM_Business_copy1")]
	[Tenant("oldDb")]
    public partial class T_RM_Business_copy1
    {
           public T_RM_Business_copy1(){


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
           /// Desc:业务经理
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Manager {get;set;}

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
           public string CustomerName {get;set;}

           /// <summary>
           /// Desc:项目预算
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Budget {get;set;}

           /// <summary>
           /// Desc:技术难点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string difficulties {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? modify {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string goodwill {get;set;}

           /// <summary>
           /// Desc:竞争者
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Competitor {get;set;}

           /// <summary>
           /// Desc:交期要求
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Delivery {get;set;}

           /// <summary>
           /// Desc:项目诉求
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string appeal {get;set;}

           /// <summary>
           /// Desc:项目预算
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string payment {get;set;}

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
           public string ServiceManager {get;set;}

    }
}
