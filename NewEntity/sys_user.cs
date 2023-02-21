using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///用户表
    ///</summary>
    [SugarTable("sys_user")]
	[Tenant("newDb")]
    public partial class sys_user
    {
           public sys_user(){


           }
           /// <summary>
           /// Desc:Id主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long Id {get;set;}

           /// <summary>
           /// Desc:工号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JobNum {get;set;}

           /// <summary>
           /// Desc:账号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Account {get;set;}

           /// <summary>
           /// Desc:密码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Password {get;set;}

           /// <summary>
           /// Desc:昵称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NickName {get;set;}

           /// <summary>
           /// Desc:姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:头像
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Avatar {get;set;}

           /// <summary>
           /// Desc:生日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Birthday {get;set;}

           /// <summary>
           /// Desc:性别-男_1、女_2
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Sex {get;set;}

           /// <summary>
           /// Desc:邮箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Email {get;set;}

           /// <summary>
           /// Desc:手机
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Phone {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tel {get;set;}

           /// <summary>
           /// Desc:最后登录IP
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LastLoginIp {get;set;}

           /// <summary>
           /// Desc:最后登录时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LastLoginTime {get;set;}

           /// <summary>
           /// Desc:管理员类型-超级管理员_1、非管理员_2
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AdminType {get;set;}

           /// <summary>
           /// Desc:状态-正常_0、停用_1、删除_2
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

           /// <summary>
           /// Desc:租户id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? TenantId {get;set;}

    }
}
