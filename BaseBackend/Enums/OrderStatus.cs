namespace BaseBackend.Enums
{
    public enum OrderStatus
    {
        PendingPayment,    // در انتظار پرداخت
        Confirmed,         // تأیید شده
        Shipped,           // ارسال شده
        Delivered          // تحویل داده شده
    }
}
