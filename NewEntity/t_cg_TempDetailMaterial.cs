using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///保存申请单临时数据(未审核时数量减少)
    ///</summary>
    [SugarTable("t_cg_TempDetailMaterial")]
	[Tenant("newDb")]
    public partial class t_cg_TempDetailMaterial
    {
           public t_cg_TempDetailMaterial(){


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
           public string No {get;set;}

           /// <summary>
           /// Desc:单据类型（主要是物料申请单或固定资产申请单，不包括采购单，入库单待定）
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
           /// Desc:Extra
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
