namespace MyErp.PrintService.Interfaces
{
    public interface IPrintService
    {
        void Print<T>(T input);
    }
}
