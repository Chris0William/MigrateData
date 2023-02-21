using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///出库表
    ///</summary>
    [SugarTable("t_xm_EXWarehouse")]
	[Tenant("newDb")]
    public partial class t_xm_EXWarehouse
    {
           public t_xm_EXWarehouse(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:主键Id审核操作流程ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperationListID {get;set;}

           /// <summary>
           /// Desc:出库编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string EXID {get;set;}

           /// <summary>
           /// Desc:出库日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EXDate {get;set;}

           /// <summary>
           /// Desc:出库类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? EXTypeID {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:对应入库的关联单编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RefrenceNo {get;set;}

           /// <summary>
           /// Desc:入库仓库ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IMWarehouse {get;set;}

           /// <summary>
           /// Desc:出库仓库ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EXWarehouse {get;set;}

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

    }
}
