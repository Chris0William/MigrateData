using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///收货单（项目物料收货确认）
    ///</summary>
    [SugarTable("T_GM_ReceiptMaterial")]
	[Tenant("oldDb")]
    public partial class T_GM_ReceiptMaterial
    {
           public T_GM_ReceiptMaterial(){


           }
           /// <summary>
           /// Desc:收到的项目采购单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ReceivePMNo {get;set;}

           /// <summary>
           /// Desc:采购单主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PMNo {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:收货单总额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RMTotalPrice {get;set;}

           /// <summary>
           /// Desc:收货单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReceiveStatus {get;set;}

           /// <summary>
           /// Desc:收货情况(收到or没收到)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ReceivingCase {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:确认操作人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ConfirmMan {get;set;}

           /// <summary>
           /// Desc:确认操作时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ConfirmTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OperationLstId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Consignee {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? autoIsNot {get;set;}

    }
}
