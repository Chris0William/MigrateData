using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///项目订单表(报价单中标后)
    ///</summary>
    [SugarTable("t_xm_Project")]
	[Tenant("newDb")]
    public partial class t_xm_Project
    {
           public t_xm_Project(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:报价单主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BudgetGID {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:客户订单号，可在项目目施工后填写
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomerNo {get;set;}

           /// <summary>
           /// Desc:订单状态（异常订单（没有客户订单号），正常订
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OfferStatus {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:附件路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AttachmentPath {get;set;}

           /// <summary>
           /// Desc:客户要求开工日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CusStart {get;set;}

           /// <summary>
           /// Desc:客户预计完工日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CusEnd {get;set;}

           /// <summary>
           /// Desc:收到订单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ReciPODate {get;set;}

           /// <summary>
           /// Desc:订单金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? PurchaseAmount {get;set;}

           /// <summary>
           /// Desc:PO合同日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CusCmfDate {get;set;}

           /// <summary>
           /// Desc:币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Currency {get;set;}

           /// <summary>
           /// Desc:当前汇率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ExchangeRate {get;set;}

           /// <summary>
           /// Desc:付款方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Payway {get;set;}

           /// <summary>
           /// Desc:结算金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RealAmount {get;set;}

           /// <summary>
           /// Desc:项目类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectType {get;set;}

           /// <summary>
           /// Desc:行号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LineNum {get;set;}

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
