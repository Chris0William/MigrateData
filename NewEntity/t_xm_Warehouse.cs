using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///仓库信息表
    ///</summary>
    [SugarTable("t_xm_Warehouse")]
	[Tenant("newDb")]
    public partial class t_xm_Warehouse
    {
           public t_xm_Warehouse(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:仓库ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WarehouseID {get;set;}

           /// <summary>
           /// Desc:仓库名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WarehouseName {get;set;}

           /// <summary>
           /// Desc:仓库地址
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Location {get;set;}

           /// <summary>
           /// Desc:仓库管理员工号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ManagerId {get;set;}

           /// <summary>
           /// Desc:仓库管理员姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ManagerName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsEnable {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

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
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WareType {get;set;}

    }
}
