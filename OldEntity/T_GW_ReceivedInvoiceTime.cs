using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///收到发票时间
    ///</summary>
    [SugarTable("T_GW_ReceivedInvoiceTime")]
	[Tenant("oldDb")]
    public partial class T_GW_ReceivedInvoiceTime
    {
           public T_GW_ReceivedInvoiceTime(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public decimal UID {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:第i次收到发票
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Times {get;set;}

           /// <summary>
           /// Desc:收到发票时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ReceivedInvoiceTime {get;set;}

    }
}
