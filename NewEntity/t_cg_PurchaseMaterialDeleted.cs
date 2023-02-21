using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///采购单表（项目物料）
    ///</summary>
    [SugarTable("t_cg_PurchaseMaterialDeleted")]
	[Tenant("newDb")]
    public partial class t_cg_PurchaseMaterialDeleted
    {
           public t_cg_PurchaseMaterialDeleted(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

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
           public string description {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckProcess {get;set;}

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
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Listdetails {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CreatedUserId {get;set;}

           /// <summary>
           /// Desc:创建者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

    }
}
