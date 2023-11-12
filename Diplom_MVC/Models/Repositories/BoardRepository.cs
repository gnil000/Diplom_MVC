using Diplom_MVC.Models.Contexts;
using Diplom_MVC.Models.Interfaces;

namespace Diplom_MVC.Models.Repositories
{
    public class BoardRepository:IBoardRepository
    {
        private ApplicationContext _context;
        public BoardRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Create(Board board)
        {
            await _context.Boards.AddAsync(board);
            await _context.SaveChangesAsync();
        }

        public List<Board> GetAll()
        {
            return _context.Boards.ToList();
        }

        public Board GetOne(Guid id)
        {
            return _context.Boards.FirstOrDefault(x=> x.Id == id);
        }

        public void Update(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
