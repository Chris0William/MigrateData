using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("t_fd_bill")]
	[Tenant("newDb")]
    public partial class t_fd_bill
    {
           public t_fd_bill(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:预付款关联的采购单Id/付款单关联的对账单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BillNo {get;set;}

           /// <summary>
           /// Desc:预付款单的主键ID/付款单的主键ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string referenceId {get;set;}

           /// <summary>
           /// Desc:申请金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Appcation {get;set;}

    }
}
