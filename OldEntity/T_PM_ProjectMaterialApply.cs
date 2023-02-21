using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PM_ProjectMaterialApply")]
	[Tenant("oldDb")]
    public partial class T_PM_ProjectMaterialApply
    {
           public T_PM_ProjectMaterialApply(){


           }
           /// <summary>
           /// Desc:申请单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string MaterialApplyNo {get;set;}

           /// <summary>
           /// Desc:Po编号（客户提供）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PoNo {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:工地
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WorkSite {get;set;}

           /// <summary>
           /// Desc:申请人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplyMan {get;set;}

           /// <summary>
           /// Desc:申请日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ApplyDate {get;set;}

           /// <summary>
           /// Desc:联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tel {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:工程部审核状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckStatusEngineeringDepartment {get;set;}

           /// <summary>
           /// Desc:工程部审核人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckManEngineeringDepartment {get;set;}

           /// <summary>
           /// Desc:工程部审核日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CheckDateEngineeringDepartment {get;set;}

           /// <summary>
           /// Desc:现场确认
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ConfirmStatus {get;set;}

           /// <summary>
           /// Desc:现场确认人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ConfirmMan {get;set;}

           /// <summary>
           /// Desc:现场确认日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ConfirmDate {get;set;}

    }
}
