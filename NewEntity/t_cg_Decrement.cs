using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///采购减量明细表
    ///</summary>
    [SugarTable("t_cg_Decrement")]
	[Tenant("newDb")]
    public partial class t_cg_Decrement
    {
           public t_cg_Decrement(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:记录表id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string GID {get;set;}

           /// <summary>
           /// Desc:采购单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string NO {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Type {get;set;}

           /// <summary>
           /// Desc:物料编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MFlID {get;set;}

           /// <summary>
           /// Desc:采购单原数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Num {get;set;}

           /// <summary>
           /// Desc:采购单原金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Price {get;set;}

           /// <summary>
           /// Desc:审核流程id
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
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string billflag {get;set;}

           /// <summary>
           /// Desc:品牌
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Brand {get;set;}

           /// <summary>
           /// Desc:变更后数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? NumRecord {get;set;}

           /// <summary>
           /// Desc:变更后金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? PriceRecord {get;set;}

           /// <summary>
           /// Desc:是否触发0/1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IsTrigger {get;set;}

    }
}
