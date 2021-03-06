﻿namespace ICanPay.Alipay
{
    public static class Channels
    {
        /// <summary>
        /// 余额
        /// </summary>
        public static string Balance = "balance";

        /// <summary>
        /// 余额宝
        /// </summary>
        public static string MoneyFund = "moneyFund";

        /// <summary>
        /// 红包
        /// </summary>
        public static string Coupon = "coupon";

        /// <summary>
        /// 花呗
        /// </summary>
        public static string Pcredit = "pcredit";

        /// <summary>
        /// 花呗分期
        /// </summary>
        public static string PcreditpayInstallment = "pcreditpayInstallment";

        /// <summary>
        /// 信用卡
        /// </summary>
        public static string CreditCard = "creditCard";

        /// <summary>
        /// 信用卡快捷
        /// </summary>
        public static string CreditCardExpress = "creditCardExpress";

        /// <summary>
        /// 信用卡卡通
        /// </summary>
        public static string CreditCardCartoon = "creditCardCartoon";

        /// <summary>
        /// 信用支付类型（包含信用卡卡通、信用卡快捷、花呗、花呗分期）
        /// </summary>
        public static string CreditGroup = "credit_group";

        /// <summary>
        /// 借记卡快捷
        /// </summary>
        public static string DebitCardExpress = "debitCardExpress";

        /// <summary>
        /// 商户预存卡
        /// </summary>
        public static string Mcard = "mcard";

        /// <summary>
        /// 个人预存卡
        /// </summary>
        public static string Pcard = "pcard";

        /// <summary>
        /// 优惠（包含实时优惠+商户优惠）
        /// </summary>
        public static string Promotion = "promotion";

        /// <summary>
        /// 营销券
        /// </summary>
        public static string Voucher = "voucher";

        /// <summary>
        /// 积分
        /// </summary>
        public static string Point = "point";

        /// <summary>
        /// 商户优惠
        /// </summary>
        public static string Mdiscount = "mdiscount";

        /// <summary>
        /// 网银
        /// </summary>
        public static string BankPay = "bankPay";

    }
}
