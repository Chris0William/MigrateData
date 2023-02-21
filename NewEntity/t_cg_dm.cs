using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///物料详情记录表（目前包括收货单，材料退回单，固定物资入库单）.此表可以再增加两个字段CurrentNum和FinalNum。这样就可以替代Temp表的功能
    ///</summary>
    [SugarTable("t_cg_dm")]
	[Tenant("newDb")]
    public partial class t_cg_dm
    {
           public t_cg_dm(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string NO {get;set;}

           /// <summary>
           /// Desc:单号类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Type {get;set;}

           /// <summary>
           /// Desc:物资编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MFlID {get;set;}

           /// <summary>
           /// Desc:分配的数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Num {get;set;}

           /// <summary>
           /// Desc:实际价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Price {get;set;}

           /// <summary>
           /// Desc:备用字段(现改为记录表单的主键)
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
           /// Desc:billflag
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string billflag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Brand {get;set;}

    }
}
