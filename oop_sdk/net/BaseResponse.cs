namespace oop_sdk.net
{
    public class BaseResponse<T> : BaseRequest<T>
    {
        public int error;
        public string message;
    }
}