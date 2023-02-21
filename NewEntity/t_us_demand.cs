using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///需求
    ///</summary>
    [SugarTable("t_us_demand")]
	[Tenant("newDb")]
    public partial class t_us_demand
    {
           public t_us_demand(){


           }
           /// <summary>
           /// Desc:关联审核ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AuditProgress {get;set;}

           /// <summary>
           /// Desc:需求类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DemandType {get;set;}

           /// <summary>
           /// Desc:需求单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Number {get;set;}

           /// <summary>
           /// Desc:申请人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplicantName {get;set;}

           /// <summary>
           /// Desc:模块名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MduleName {get;set;}

           /// <summary>
           /// Desc:问题存在的原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Poblem {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:现状分析/变更内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NeedContent {get;set;}

           /// <summary>
           /// Desc:经办时间
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
           /// Desc:经办人
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
           /// Desc:需求所属
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DemandClass {get;set;}

           /// <summary>
           /// Desc:截图补充
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PictuctPath {get;set;}

           /// <summary>
           /// Desc:所属部门
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AppDivision {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DownName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DownText {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? DownDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? DownETDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Submitter {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Arangement {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SQLMent {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DevelopDoc {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Instructions {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SubmitDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MessageID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MessageText {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? MessageDate {get;set;}

    }
}
