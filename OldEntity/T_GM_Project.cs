using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///项目订单(报价单中标后)
    ///</summary>
    [SugarTable("T_GM_Project")]
	[Tenant("oldDb")]
    public partial class T_GM_Project
    {
           public T_GM_Project(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UID {get;set;}

           /// <summary>
           /// Desc:报价单主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BudgetGID {get;set;}

           /// <summary>
           /// Desc:
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
           /// Desc:订单状态（异常订单（没有客户订单号），正常订单）
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
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ReciPODate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? PurchaseAmount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CusCmfDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Currency {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public decimal? ExchangeRate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Payway {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RealAmount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LineNum {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectType {get;set;}

    }
}
