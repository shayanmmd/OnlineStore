namespace _0_FrameWork.Application;

public class OperationResult
{
    public string Message { get; set; }
    public bool IsSuccessful { get; set; }
    public OperationResult()
    {
        IsSuccessful = false;
    }

    public OperationResult Succedded(string message = "عملیات با موفقیت انجام شد")
    {
        IsSuccessful = true;
        Message = message;
        return this;
    }
    public OperationResult Failed(string message)
    {
        Message = message;
        return this;
    }
}

