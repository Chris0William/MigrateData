using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///文档表
    ///</summary>
    [SugarTable("documentation")]
	[Tenant("newDb")]
    public partial class documentation
    {
           public documentation(){


           }
           /// <summary>
           /// Desc:Id
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
           public long PId {get;set;}

           /// <summary>
           /// Desc:父ID列表
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PIds {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:文档类型:文件、文件夹
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int DocumentType {get;set;}

           /// <summary>
           /// Desc:文件后缀
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileSuffix {get;set;}

           /// <summary>
           /// Desc:文件大小kb
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? FileSizeKb {get;set;}

           /// <summary>
           /// Desc:存储后的文件名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileObjectName {get;set;}

           /// <summary>
           /// Desc:文件路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FilePath {get;set;}

           /// <summary>
           /// Desc:标签
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Label {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Visible {get;set;}

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
           /// Desc:创建用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CreatedUserId {get;set;}

           /// <summary>
           /// Desc:创建人用户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

           /// <summary>
           /// Desc:修改人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:修改人用户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:是否删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
