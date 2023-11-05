using Employee_Managment.Models;

namespace Employee_Managment.Repository
{
    public interface IPunchEventRepository
    {
        Task<IEnumerable<PunchEvent>> GetPunchEventAsync();
        Task CreatePunchEventAsync(PunchEvent punchEvent);
    }
}
