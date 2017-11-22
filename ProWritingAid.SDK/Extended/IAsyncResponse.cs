namespace ProWritingAid.SDK.Model.Async
{
    public interface IAsyncResponse<TBody>
    {
        string TaskId { get; set; }
        TBody Result { get; set; }
    }
}