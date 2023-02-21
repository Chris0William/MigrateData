using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PE_DistributeType")]
	[Tenant("oldDb")]
    public partial class T_PE_DistributeType
    {
           public T_PE_DistributeType(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:通知者工号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string InformStaffID {get;set;}

           /// <summary>
           /// Desc:类别名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string referenceId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Creator {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Company {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyNum {get;set;}

    }
}
