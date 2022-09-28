namespace ECOLAB.IOT.Entity
{
    using System;

    public class TData<T>
    {
        public Status Status { get; set; }=Status.OK;
        public string Message { get; set; } = string.Empty;

        public T? Result { get; set; }
    }

    public enum Status
    { 
        OK=0,
        Fail=1
    }
}
