using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///普通采购单表（固定资产）
    ///</summary>
    [SugarTable("T_GM_PurchaseFixedAsset")]
	[Tenant("oldDb")]
    public partial class T_GM_PurchaseFixedAsset
    {
           public T_GM_PurchaseFixedAsset(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string GID {get;set;}

           /// <summary>
           /// Desc:采购单号(1张采购单包含多张固定资产申请单)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PurchaseFNo {get;set;}

           /// <summary>
           /// Desc:申请单主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ApplyNo {get;set;}

           /// <summary>
           /// Desc:供应商ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SupplierID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurchasePrice {get;set;}

           /// <summary>
           /// Desc:订单类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderType {get;set;}

           /// <summary>
           /// Desc:申请时间,入库时间等
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? No_Date {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditProcess {get;set;}

           /// <summary>
           /// Desc:订单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Status {get;set;}

           /// <summary>
           /// Desc:经办人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Operator {get;set;}

           /// <summary>
           /// Desc:经办时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OperateTime {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Address {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tax {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Company {get;set;}

    }
}
