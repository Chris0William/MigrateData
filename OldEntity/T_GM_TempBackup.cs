using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///备份数据（只有订单审核通过，数目才会相应减少）
    ///</summary>
    [SugarTable("T_GM_TempBackup")]
	[Tenant("oldDb")]
    public partial class T_GM_TempBackup
    {
           public T_GM_TempBackup(){


           }
           /// <summary>
           /// Desc:主键，自增长型
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public decimal UID {get;set;}

           /// <summary>
           /// Desc:单号
           /// Default:
           /// Nullable:False
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
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

    }
}
