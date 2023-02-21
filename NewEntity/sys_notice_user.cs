using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///通知公告用户表
    ///</summary>
    [SugarTable("sys_notice_user")]
	[Tenant("newDb")]
    public partial class sys_notice_user
    {
           public sys_notice_user(){


           }
           /// <summary>
           /// Desc:通知公告Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long NoticeId {get;set;}

           /// <summary>
           /// Desc:用户Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:阅读时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ReadTime {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ReadStatus {get;set;}

    }
}
