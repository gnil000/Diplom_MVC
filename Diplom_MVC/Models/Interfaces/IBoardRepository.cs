namespace Diplom_MVC.Models.Interfaces
{
    public interface IBoardRepository
    {
        Task Create(Board board);
        List<Board> GetAll();
        Board GetOne(Guid id);
        void Update(Board board);
    }
}
