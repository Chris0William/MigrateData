using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///固定资产、间接申请等表物料
    ///</summary>
    [SugarTable("t_cg_jm")]
	[Tenant("newDb")]
    public partial class t_cg_jm
    {
           public t_cg_jm(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:物料名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:申请编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string No {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Type {get;set;}

           /// <summary>
           /// Desc:价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Price {get;set;}

           /// <summary>
           /// Desc:型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Size {get;set;}

           /// <summary>
           /// Desc:申请数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Num {get;set;}

           /// <summary>
           /// Desc:当前可申请数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CurrentNum {get;set;}

           /// <summary>
           /// Desc:最终数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? FinalNum {get;set;}

           /// <summary>
           /// Desc:单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Unit {get;set;}

           /// <summary>
           /// Desc:关联ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:物料编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Number {get;set;}

           /// <summary>
           /// Desc:品牌
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Brand {get;set;}

           /// <summary>
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

           /// <summary>
           /// Desc:识别ID，相当于物料编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IdentifyID {get;set;}

    }
}
