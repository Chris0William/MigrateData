using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PM_OrderInfo")]
	[Tenant("oldDb")]
    public partial class T_PM_OrderInfo
    {
           public T_PM_OrderInfo(){


           }
           /// <summary>
           /// Desc:公司订单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CompanyOrderNo {get;set;}

           /// <summary>
           /// Desc:发单人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderMan {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:客户订单编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ClientOrderNo {get;set;}

           /// <summary>
           /// Desc:客户名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ClientName {get;set;}

           /// <summary>
           /// Desc:订单金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? OrderMoney {get;set;}

           /// <summary>
           /// Desc:订单状况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderStatus {get;set;}

           /// <summary>
           /// Desc:订单日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OrderDate {get;set;}

           /// <summary>
           /// Desc:交货日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? DeliveryDate {get;set;}

           /// <summary>
           /// Desc:计划开工日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PlanStartDate {get;set;}

           /// <summary>
           /// Desc:实际开工日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ActualStartDate {get;set;}

           /// <summary>
           /// Desc:计划完工日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PlanEndDate {get;set;}

           /// <summary>
           /// Desc:实际完工日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ActualEndDate {get;set;}

           /// <summary>
           /// Desc:是否入库
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BoolStorage {get;set;}

           /// <summary>
           /// Desc:是否验收
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BoolCheck {get;set;}

           /// <summary>
           /// Desc:是否开发票
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BoolInvoice {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:是否含税
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BoolTax {get;set;}

           /// <summary>
           /// Desc:税率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxRate {get;set;}

           /// <summary>
           /// Desc:付款条件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayCondition {get;set;}

           /// <summary>
           /// Desc:复核人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReviewMan {get;set;}

           /// <summary>
           /// Desc:复核日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ReviewDate {get;set;}

           /// <summary>
           /// Desc:经办人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AgentMan {get;set;}

           /// <summary>
           /// Desc:经办日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AgentDate {get;set;}

    }
}
