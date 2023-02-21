using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("t_fd_DetailPlan")]
	[Tenant("newDb")]
    public partial class t_fd_DetailPlan
    {
           public t_fd_DetailPlan(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:收款计划表主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CollectionId {get;set;}

           /// <summary>
           /// Desc:收款类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CollectionType {get;set;}

           /// <summary>
           /// Desc:项目进度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectSchedule {get;set;}

           /// <summary>
           /// Desc:收款进度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CollectionRatio {get;set;}

           /// <summary>
           /// Desc:收款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CollectionAmount {get;set;}

           /// <summary>
           /// Desc:收款状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CollectionState {get;set;}

           /// <summary>
           /// Desc:收款日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CollectionDate {get;set;}

           /// <summary>
           /// Desc:是否发送财务
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Sent {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

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
           /// Desc:付款条件描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CollectionDescribe {get;set;}

           /// <summary>
           /// Desc:预测日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CollectionForecast {get;set;}

           /// <summary>
           /// Desc:付款条件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CollectionPayment {get;set;}

           /// <summary>
           /// Desc:实际应收日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CollectionRealDate {get;set;}

           /// <summary>
           /// Desc:实际条件日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CollectionRealsDate {get;set;}

           /// <summary>
           /// Desc:是否确认true/false
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? CollectionSure {get;set;}

           /// <summary>
           /// Desc:条件天数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CollectionDay {get;set;}

           /// <summary>
           /// Desc:是否触发
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? ISTrigger {get;set;}

           /// <summary>
           /// Desc:生成日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? GenerationDate {get;set;}

           /// <summary>
           /// Desc:金额确认
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? ISPrice {get;set;}

           /// <summary>
           /// Desc:预测金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ForecastPrice {get;set;}

    }
}
