using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflineMarketShopCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineMarketShopCreateModel : AopObject
    {
        /// <summary>
        /// 门店详细地址，注：不含省市区
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店审核时需要的图片；至少包含一张门头照片，两张内景照片，必须反映真实的门店情况，审核才能够通过；多个图片之间以英文逗号分隔；
        /// </summary>
        [XmlElement("audit_images")]
        public string AuditImages { get; set; }

        /// <summary>
        /// 门店授权函,营业执照与签约账号主体不一致时需要
        /// </summary>
        [XmlElement("auth_letter")]
        public string AuthLetter { get; set; }

        /// <summary>
        /// 人均消费价格，最少1元，最大不超过99999元，请按实际情况填写；单位元，不需填写单位；
        /// </summary>
        [XmlElement("avg_price")]
        public string AvgPrice { get; set; }

        /// <summary>
        /// 门店是否有包厢，T表示有，F表示没有，不传在客户端不作展示
        /// </summary>
        [XmlElement("box")]
        public string Box { get; set; }

        /// <summary>
        /// 分店名称，比如：万塘路店，与主门店名合并在客户端显示为：肯德基(万塘路店)
        /// </summary>
        [XmlElement("branch_shop_name")]
        public string BranchShopName { get; set; }

        /// <summary>
        /// 品牌LOGO; 图片ID，不填写则默认为门店首图main_image
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 品牌名，不填写则默认为“其它品牌”
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 经营许可证，只有餐饮类目需要
        /// </summary>
        [XmlElement("business_certificate")]
        public string BusinessCertificate { get; set; }

        /// <summary>
        /// 经营许可证有效期，格式：2020-03-20，只有餐饮类目需要
        /// </summary>
        [XmlElement("business_certificate_expires")]
        public string BusinessCertificateExpires { get; set; }

        /// <summary>
        /// 营业时间，支持分段营业时间，以英文逗号分隔
        /// </summary>
        [XmlElement("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 类目id;类目初始数据由口碑提供
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 城市编码，国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载”</a>
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 门店电话号码；支持座机和手机，只支持数字和+-号，在客户端对用户展现， 支持多个电话， 以英文逗号分隔
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 支付宝内部使用，外部商户不需要填写此字段。店铺创建者,以授权模式创建商户店铺，不需要填写；非授权模式下，需要填写小二的支付宝账号
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 区县编码，国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载”</a>
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 机具号，多个之间以英文逗号分隔
        /// </summary>
        [XmlElement("implement_id")]
        public string ImplementId { get; set; }

        /// <summary>
        /// 是否在其他平台开店，T表示有开店，F表示未开店，用于证明其开店资质，如无营业执照必须有在其他平台的开店资质才能入住口碑平台，其他平台主要包括美团、点评。
        /// </summary>
        [XmlElement("is_operating_online")]
        public string IsOperatingOnline { get; set; }

        /// <summary>
        /// ISV返佣id; 标明该门店是由哪个ISV UID创建的，如果有口碑签订了返佣协议，则该字段作为返佣数据提取的依据
        /// </summary>
        [XmlElement("isv_uid")]
        public string IsvUid { get; set; }

        /// <summary>
        /// 维度；最长15位字符（包括小数点）， 注：高德坐标系
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 门店营业执照图片，营业执照信息与is_operating_online至少填一项
        /// </summary>
        [XmlElement("licence")]
        public string Licence { get; set; }

        /// <summary>
        /// 门店营业执照编号，营业执照信息与is_operating_online至少填一项
        /// </summary>
        [XmlElement("licence_code")]
        public string LicenceCode { get; set; }

        /// <summary>
        /// 营业执照过期时间
        /// </summary>
        [XmlElement("licence_expires")]
        public string LicenceExpires { get; set; }

        /// <summary>
        /// 门店营业执照名称
        /// </summary>
        [XmlElement("licence_name")]
        public string LicenceName { get; set; }

        /// <summary>
        /// 经度；最长15位字符（包括小数点）， 注：高德坐标系
        /// </summary>
        [XmlElement("longitude")]
        public long Longitude { get; set; }

        /// <summary>
        /// 门店首图；非常重要，推荐尺寸2000*1500
        /// </summary>
        [XmlElement("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 主门店名  比如：肯德基
        /// </summary>
        [XmlElement("main_shop_name")]
        public string MainShopName { get; set; }

        /// <summary>
        /// 是否有无烟区，T表示有无烟区，F表示没有无烟区，不传在客户端不展示
        /// </summary>
        [XmlElement("no_smoking")]
        public string NoSmoking { get; set; }

        /// <summary>
        /// 门店店长电话号码；用于接收门店状态变更通知，收款成功通知等通知消息， 不在客户端展示
        /// </summary>
        [XmlElement("notify_mobile")]
        public string NotifyMobile { get; set; }

        /// <summary>
        /// 在其他平台的开店图片
        /// </summary>
        [XmlElement("online_image")]
        public string OnlineImage { get; set; }

        /// <summary>
        /// 支付宝内部使用，外部商户不需要填写此字段。操作角色，MERCHANT或PROVIDER,非授权模式填写PROVIDER,授权模式填写MERCHANT，默认是MERCHANT
        /// </summary>
        [XmlElement("op_role")]
        public string OpRole { get; set; }

        /// <summary>
        /// 当商户的门店审核状态发生变化时，会向该地址推送消息
        /// </summary>
        [XmlElement("operate_notify_url")]
        public string OperateNotifyUrl { get; set; }

        /// <summary>
        /// 支付宝内部使用，外部商户不需要填写此字段。其他资质
        /// </summary>
        [XmlElement("other_authorization")]
        public string OtherAuthorization { get; set; }

        /// <summary>
        /// 门店是否支持停车，T表示支持，F表示不支持，不传在客户端不作展示
        /// </summary>
        [XmlElement("parking")]
        public string Parking { get; set; }

        /// <summary>
        /// 支付宝内部使用，外部商户不需要填写此字段。商户PID，授权模式下不需要填写；非授权模式下，需要填写商户PID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付宝内部使用，外部商户不需要填写此字段。付款方式：code_scanned_pay：付款码  online_pay：在线买单
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 省份编码，国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载”</a>
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 流水id; 支付宝内部参数，leads开店重试支付宝流水ID
        /// </summary>
        [XmlElement("ref_apply_id")]
        public string RefApplyId { get; set; }

        /// <summary>
        /// 支持英文字母和数字，由开发者自行定义（不允许重复），在门店notify消息中也会带有该参数，以此标明本次notify消息是对哪个请求的回应
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 外部门店编号；最长54位字符，该编号将作为收单接口的入参， 请开发者自行确保其唯一性
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店其他的服务，门店与用户线下兑现
        /// </summary>
        [XmlElement("value_added")]
        public string ValueAdded { get; set; }

        /// <summary>
        /// 门店是否支持WIFI，T表示支持，F表示不支持，不传在客户端不作展示
        /// </summary>
        [XmlElement("wifi")]
        public string Wifi { get; set; }
    }
}
