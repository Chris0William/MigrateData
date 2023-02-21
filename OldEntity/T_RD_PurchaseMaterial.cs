using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///采购单表（项目物料）
    ///</summary>
    [SugarTable("T_RD_PurchaseMaterial")]
	[Tenant("oldDb")]
    public partial class T_RD_PurchaseMaterial
    {
           public T_RD_PurchaseMaterial(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string GID {get;set;}

           /// <summary>
           /// Desc:项目采购单号(1张采购单包含多张已审核的项目物料申请单)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PurchaseMNo {get;set;}

           /// <summary>
           /// Desc:物资申请单号主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AMGID {get;set;}

           /// <summary>
           /// Desc:供应商ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SupplierID {get;set;}

           /// <summary>
           /// Desc:采购金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurchasePrice {get;set;}

           /// <summary>
           /// Desc:项目单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:送货方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReceiptMethod {get;set;}

           /// <summary>
           /// Desc:订单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderStatu {get;set;}

           /// <summary>
           /// Desc:订单类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderType {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckProcess {get;set;}

           /// <summary>
           /// Desc:经办人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Operator {get;set;}

           /// <summary>
           /// Desc:经办日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OperateTime {get;set;}

           /// <summary>
           /// Desc:供应商回复日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SupplierAckDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AttachmentPath {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tax {get;set;}

           /// <summary>
           /// Desc:付款方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PaymentCycle {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Currency {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ExchangeRate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Send {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Location {get;set;}

           /// <summary>
           /// Desc:申请预付款哪些金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ApplicationPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReturnFile {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Contract {get;set;}

           /// <summary>
           /// Desc:发送给供应商邮箱的采购订单文件(pdf)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EmailFile {get;set;}

    }
}
