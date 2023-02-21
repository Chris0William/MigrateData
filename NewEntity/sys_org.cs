using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///组织机构表
    ///</summary>
    [SugarTable("sys_org")]
	[Tenant("newDb")]
    public partial class sys_org
    {
           public sys_org(){


           }
           /// <summary>
           /// Desc:Id主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long Id {get;set;}

           /// <summary>
           /// Desc:父Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Pid {get;set;}

           /// <summary>
           /// Desc:父Ids
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Pids {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Code {get;set;}

           /// <summary>
           /// Desc:联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Contacts {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tel {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Sort {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

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
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

           /// <summary>
           /// Desc:租户id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? TenantId {get;set;}

    }
}
