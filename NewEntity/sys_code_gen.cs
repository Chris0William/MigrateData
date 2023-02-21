using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///代码生成表
    ///</summary>
    [SugarTable("sys_code_gen")]
	[Tenant("newDb")]
    public partial class sys_code_gen
    {
           public sys_code_gen(){


           }
           /// <summary>
           /// Desc:Id主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long Id {get;set;}

           /// <summary>
           /// Desc:作者姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuthorName {get;set;}

           /// <summary>
           /// Desc:是否移除表前缀
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TablePrefix {get;set;}

           /// <summary>
           /// Desc:生成方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GenerateType {get;set;}

           /// <summary>
           /// Desc:数据库表名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TableName {get;set;}

           /// <summary>
           /// Desc:命名空间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NameSpace {get;set;}

           /// <summary>
           /// Desc:业务名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BusName {get;set;}

           /// <summary>
           /// Desc:菜单应用分类
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MenuApplication {get;set;}

           /// <summary>
           /// Desc:菜单编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long MenuPid {get;set;}

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
