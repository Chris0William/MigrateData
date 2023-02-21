using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///参数配置表
    ///</summary>
    [SugarTable("sys_config")]
	[Tenant("newDb")]
    public partial class sys_config
    {
           public sys_config(){


           }
           /// <summary>
           /// Desc:Id主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long Id {get;set;}

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
           /// Desc:属性值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Value {get;set;}

           /// <summary>
           /// Desc:是否是系统参数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SysFlag {get;set;}

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
           /// Desc:常量所属分类的编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GroupCode {get;set;}

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
