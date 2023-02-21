using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///通知公告表
    ///</summary>
    [SugarTable("sys_notice")]
	[Tenant("newDb")]
    public partial class sys_notice
    {
           public sys_notice(){


           }
           /// <summary>
           /// Desc:Id主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long Id {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Title {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Content {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Type {get;set;}

           /// <summary>
           /// Desc:发布人Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long PublicUserId {get;set;}

           /// <summary>
           /// Desc:发布人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PublicUserName {get;set;}

           /// <summary>
           /// Desc:发布机构Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long PublicOrgId {get;set;}

           /// <summary>
           /// Desc:发布机构名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PublicOrgName {get;set;}

           /// <summary>
           /// Desc:发布时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime PublicTime {get;set;}

           /// <summary>
           /// Desc:撤回时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CancelTime {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

           /// <summary>
           /// Desc:创建者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CreatedUserId {get;set;}

           /// <summary>
           /// Desc:创建者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

           /// <summary>
           /// Desc:修改者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:修改者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:软删除标记
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsDeleted {get;set;}

    }
}
