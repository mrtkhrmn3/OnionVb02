namespace OnionVb02.Application.CqrsAndMediatr.Common
{
    public class CommandResult<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public static CommandResult<T> SuccessResult(T data, string message = "İşlem başarılı")
        {
            return new CommandResult<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        public static CommandResult<T> FailureResult(string message)
        {
            return new CommandResult<T>
            {
                Success = false,
                Message = message
            };
        }
    }

    public class CommandResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public static CommandResult SuccessResult(string message = "İşlem başarılı")
        {
            return new CommandResult
            {
                Success = true,
                Message = message
            };
        }

        public static CommandResult FailureResult(string message)
        {
            return new CommandResult
            {
                Success = false,
                Message = message
            };
        }
    }
}

