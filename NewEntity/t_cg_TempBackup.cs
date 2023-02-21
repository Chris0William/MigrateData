using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///备份数据（只有订单审核通过，数目才会相应减少）
    ///</summary>
    [SugarTable("t_cg_TempBackup")]
	[Tenant("newDb")]
    public partial class t_cg_TempBackup
    {
           public t_cg_TempBackup(){


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
           /// Nullable:True
           /// </summary>           
           public string No {get;set;}

           /// <summary>
           /// Desc:单据类型（主要是采购单，入库单待定）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NoType {get;set;}

           /// <summary>
           /// Desc:物资编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MFlID {get;set;}

           /// <summary>
           /// Desc:申请数量
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
           /// Desc:实际价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:Extra
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

    }
}
