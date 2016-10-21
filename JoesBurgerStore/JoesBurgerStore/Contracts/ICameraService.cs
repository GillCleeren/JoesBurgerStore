using System.Threading.Tasks;
using XLabs.Platform.Services.Media;

namespace JoesBurgerStore.Contracts
{
    public interface ICameraService
    {
        Task<MediaFile> TakePicture();
    }
}