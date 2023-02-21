using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///收货单（项目物料收货确认）
    ///</summary>
    [SugarTable("t_cg_ReceiptMaterial")]
	[Tenant("newDb")]
    public partial class t_cg_ReceiptMaterial
    {
           public t_cg_ReceiptMaterial(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:收到的项目采购单号
           /// Default:
           /// Nullable:False
           /// </summary>           
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
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ConfirmTime {get;set;}

           /// <summary>
           /// Desc:收货人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ConfirmMan {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

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

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

           /// <summary>
           /// Desc:创建者Id
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

           /// <summary>
           /// Desc:修改者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:修改者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
