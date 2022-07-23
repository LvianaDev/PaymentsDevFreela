using DevFreela.Payments.API.Models;
using System.Threading.Tasks;

namespace DevFreela.Payments.API.Services
{
    public interface IPaymentServicePay
    {
        Task<bool> ProcessPay(PaymentInfoInputModel paymentInfoInputModel);
    }
}
