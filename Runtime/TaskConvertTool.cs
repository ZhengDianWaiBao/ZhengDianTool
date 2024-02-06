using System;
using System.Threading;
using System.Threading.Tasks;

namespace ZhengDianWaiBao.Tool
{
    public static class TaskConvertTool
    {
        public static Task WaitTask(Action<Action> setAction, Action<Action> cancel,
            CancellationTokenSource tokenSource = null) => new TaskConvert(setAction, cancel).Start(tokenSource);

        public static Task<T> WaitTask<T>(Action<Action<T>> setAction, Action<Action<T>> cancel,
            CancellationTokenSource tokenSource = null) => new TaskConvert<T>(setAction, cancel).Start(tokenSource);
    }
}