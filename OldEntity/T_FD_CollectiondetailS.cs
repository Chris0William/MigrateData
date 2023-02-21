using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_FD_CollectiondetailS")]
	[Tenant("oldDb")]
    public partial class T_FD_CollectiondetailS
    {
           public T_FD_CollectiondetailS(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string GID {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Project {get;set;}

           /// <summary>
           /// Desc:项目进度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Schedule {get;set;}

           /// <summary>
           /// Desc:计划日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PlanDate {get;set;}

           /// <summary>
           /// Desc:发票
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Invoice {get;set;}

           /// <summary>
           /// Desc:项目状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string State {get;set;}

           /// <summary>
           /// Desc:收款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Price {get;set;}

           /// <summary>
           /// Desc:确认收款金额 0/1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ISPrice {get;set;}

           /// <summary>
           /// Desc:是否触发 0/1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ISTrigger {get;set;}

           /// <summary>
           /// Desc:备用字段1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Spare1 {get;set;}

           /// <summary>
           /// Desc:备用字段2
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Spare2 {get;set;}

           /// <summary>
           /// Desc:备用字段3
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Spare3 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Spare4 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Spare5 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Spare6 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CollectionPayment {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CollectionDescribe {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CollectionRealsDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CollectionRealDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CollectionForecast {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Spare7 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? InvoiceAmount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceNum {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RealReceiveAmount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PaymentState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? InvoiceOrnot {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? OldRealReceive {get;set;}

    }
}
