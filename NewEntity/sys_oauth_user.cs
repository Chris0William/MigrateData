using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///Oauth登录用户表
    ///</summary>
    [SugarTable("sys_oauth_user")]
	[Tenant("newDb")]
    public partial class sys_oauth_user
    {
           public sys_oauth_user(){


           }
           /// <summary>
           /// Desc:Id主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long Id {get;set;}

           /// <summary>
           /// Desc:UUID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Uuid {get;set;}

           /// <summary>
           /// Desc:Token
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AccessToken {get;set;}

           /// <summary>
           /// Desc:昵称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NickName {get;set;}

           /// <summary>
           /// Desc:头像
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Avatar {get;set;}

           /// <summary>
           /// Desc:性别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Gender {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Phone {get;set;}

           /// <summary>
           /// Desc:邮箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Email {get;set;}

           /// <summary>
           /// Desc:位置
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Location {get;set;}

           /// <summary>
           /// Desc:用户网址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Blog {get;set;}

           /// <summary>
           /// Desc:所在公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Company {get;set;}

           /// <summary>
           /// Desc:用户来源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Source {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

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
