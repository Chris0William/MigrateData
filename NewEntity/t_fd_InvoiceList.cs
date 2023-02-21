using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("t_fd_InvoiceList")]
	[Tenant("newDb")]
    public partial class t_fd_InvoiceList
    {
           public t_fd_InvoiceList(){


           }
           /// <summary>
           /// Desc:自增主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:未含税金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? AmountNoTax {get;set;}

           /// <summary>
           /// Desc:发票日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? InvoiceDate {get;set;}

           /// <summary>
           /// Desc:发票号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceNo {get;set;}

           /// <summary>
           /// Desc:关联主键ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReferenceId {get;set;}

    }
}
