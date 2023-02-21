using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///项目材料申请表
    ///</summary>
    [SugarTable("T_RD_ApplyMaterial")]
	[Tenant("oldDb")]
    public partial class T_RD_ApplyMaterial
    {
           public T_RD_ApplyMaterial(){


           }
           /// <summary>
           /// Desc:请购单表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string GID {get;set;}

           /// <summary>
           /// Desc:申请单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ApplyMaterialNo {get;set;}

           /// <summary>
           /// Desc:项目单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:客户订单主键（决定申请者最多能申请多少物料）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FPMGID {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckProcess {get;set;}

           /// <summary>
           /// Desc:申请单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplyMState {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:申请人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplyMan {get;set;}

           /// <summary>
           /// Desc:申请时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ApplyTime {get;set;}

           /// <summary>
           /// Desc:预交日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PrepaidDay {get;set;}

           /// <summary>
           /// Desc:申请人联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tel {get;set;}

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
           public string reason {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Adress {get;set;}

    }
}
