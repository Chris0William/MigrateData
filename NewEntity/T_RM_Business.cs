using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///业务评审表
    ///</summary>
    [SugarTable("T_RM_Business")]
	[Tenant("newDb")]
    public partial class T_RM_Business
    {
           public T_RM_Business(){


           }
           /// <summary>
           /// Desc:
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
           /// Desc:项目经理
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
           public string Difficulties {get;set;}

           /// <summary>
           /// Desc:是否可以新增
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? Modify {get;set;}

           /// <summary>
           /// Desc:客户信誉
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Goodwill {get;set;}

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
           /// Desc:项目背景
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Appeal {get;set;}

           /// <summary>
           /// Desc:付款方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Payment {get;set;}

           /// <summary>
           /// Desc:评审意见
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Suggestion {get;set;}

           /// <summary>
           /// Desc:业务经理
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ServiceManager {get;set;}

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
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsDeleted {get;set;}

    }
}
