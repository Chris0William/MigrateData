using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PE_WithdrawLog")]
	[Tenant("oldDb")]
    public partial class T_PE_WithdrawLog
    {
           public T_PE_WithdrawLog(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public decimal ID {get;set;}

           /// <summary>
           /// Desc:审核流程名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Checkfunc {get;set;}

           /// <summary>
           /// Desc:撤回时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Creatime {get;set;}

           /// <summary>
           /// Desc:撤回人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Creator {get;set;}

           /// <summary>
           /// Desc:关联ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

    }
}
