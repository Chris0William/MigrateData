using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///审核任务
    ///</summary>
    [SugarTable("t_sys_task")]
	[Tenant("newDb")]
    public partial class t_sys_task
    {
           public t_sys_task(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:StaffID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long StaffID {get;set;}

           /// <summary>
           /// Desc:MenuID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MenuID {get;set;}

           /// <summary>
           /// Desc:url
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string url {get;set;}

           /// <summary>
           /// Desc:state
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int state {get;set;}

           /// <summary>
           /// Desc:OperationTime
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OperationTime {get;set;}

           /// <summary>
           /// Desc:EndTime
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EndTime {get;set;}

           /// <summary>
           /// Desc:CreateTime
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateTime {get;set;}

           /// <summary>
           /// Desc:OperationID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperationID {get;set;}

           /// <summary>
           /// Desc:description
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:是否已读
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool expire {get;set;}

    }
}
