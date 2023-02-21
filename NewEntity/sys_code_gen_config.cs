using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///代码生成字段配置表
    ///</summary>
    [SugarTable("sys_code_gen_config")]
	[Tenant("newDb")]
    public partial class sys_code_gen_config
    {
           public sys_code_gen_config(){


           }
           /// <summary>
           /// Desc:Id主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long Id {get;set;}

           /// <summary>
           /// Desc:代码生成主表ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CodeGenId {get;set;}

           /// <summary>
           /// Desc:数据库字段名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ColumnName {get;set;}

           /// <summary>
           /// Desc:字段描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ColumnComment {get;set;}

           /// <summary>
           /// Desc:.NET数据类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NetType {get;set;}

           /// <summary>
           /// Desc:作用类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EffectType {get;set;}

           /// <summary>
           /// Desc:外键实体名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FkEntityName {get;set;}

           /// <summary>
           /// Desc:外键显示字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FkColumnName {get;set;}

           /// <summary>
           /// Desc:外键显示字段.NET类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FkColumnNetType {get;set;}

           /// <summary>
           /// Desc:字典Code
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DictTypeCode {get;set;}

           /// <summary>
           /// Desc:列表是否缩进
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WhetherRetract {get;set;}

           /// <summary>
           /// Desc:是否必填
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WhetherRequired {get;set;}

           /// <summary>
           /// Desc:是否是查询条件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QueryWhether {get;set;}

           /// <summary>
           /// Desc:查询方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QueryType {get;set;}

           /// <summary>
           /// Desc:列表显示
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WhetherTable {get;set;}

           /// <summary>
           /// Desc:增改
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WhetherAddUpdate {get;set;}

           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ColumnKey {get;set;}

           /// <summary>
           /// Desc:数据库中类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DataType {get;set;}

           /// <summary>
           /// Desc:是否通用字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WhetherCommon {get;set;}

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
