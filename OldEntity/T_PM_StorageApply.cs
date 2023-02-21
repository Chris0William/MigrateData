using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///申请入库单
    ///</summary>
    [SugarTable("T_PM_StorageApply")]
	[Tenant("oldDb")]
    public partial class T_PM_StorageApply
    {
           public T_PM_StorageApply(){


           }
           /// <summary>
           /// Desc:申请单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ApplyNo {get;set;}

           /// <summary>
           /// Desc:申请人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplyMan {get;set;}

           /// <summary>
           /// Desc:申请时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ApplyDate {get;set;}

           /// <summary>
           /// Desc:复核人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckMan {get;set;}

           /// <summary>
           /// Desc:复核时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CheckDate {get;set;}

           /// <summary>
           /// Desc:复核状态信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckStatus {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:仓库
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Warehouse {get;set;}

    }
}
