using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///客户评分表
    ///</summary>
    [SugarTable("T_GW_CustomRating")]
	[Tenant("oldDb")]
    public partial class T_GW_CustomRating
    {
           public T_GW_CustomRating(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public decimal UID {get;set;}

           /// <summary>
           /// Desc:订单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AppNo {get;set;}

           /// <summary>
           /// Desc:服务质量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ServiceQuality {get;set;}

           /// <summary>
           /// Desc:服务速度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ServiceSpeed {get;set;}

           /// <summary>
           /// Desc:服务态度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ServiceAttitude {get;set;}

           /// <summary>
           /// Desc:服务建议
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ServiceAdvice {get;set;}

           /// <summary>
           /// Desc:评价人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Appraiser {get;set;}

           /// <summary>
           /// Desc:评价时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AppraisTime {get;set;}

    }
}
