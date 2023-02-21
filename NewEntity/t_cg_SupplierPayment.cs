using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///供应商付款类型
    ///</summary>
    [SugarTable("t_cg_SupplierPayment")]
	[Tenant("newDb")]
    public partial class t_cg_SupplierPayment
    {
           public t_cg_SupplierPayment(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:供应商ID 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierID {get;set;}

           /// <summary>
           /// Desc:供应商名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierName {get;set;}

           /// <summary>
           /// Desc:Type
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Type {get;set;}

           /// <summary>
           /// Desc:付款类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayType {get;set;}

           /// <summary>
           /// Desc:Tax
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tax {get;set;}

           /// <summary>
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
