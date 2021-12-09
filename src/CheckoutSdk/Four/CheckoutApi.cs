using Checkout.Customers.Four;
using Checkout.Disputes.Four;
using Checkout.Instruments.Four;
using Checkout.Payments.Four;
using Checkout.Risk;
using Checkout.Tokens;

namespace Checkout.Four
{
    public class CheckoutApi : ICheckoutApi
    {
        private readonly ITokensClient _tokensClient;
        private readonly ICustomersClient _customersClient;
        private readonly IPaymentsClient _paymentsClient;
        private readonly IInstrumentsClient _instrumentsClient;
        private readonly IDisputesClient _disputesClient;
        private readonly IRiskClient _riskClient;

        public CheckoutApi(CheckoutConfiguration configuration)
        {
            var apiClient = new ApiClient(configuration);
            _tokensClient = new TokensClient(apiClient, configuration);
            _customersClient = new CustomersClient(apiClient, configuration);
            _paymentsClient = new PaymentsClient(apiClient, configuration);
            _instrumentsClient = new InstrumentsClient(apiClient, configuration);
            _disputesClient = new DisputesClient(apiClient, configuration);
            _riskClient = new RiskClient(apiClient, configuration);
        }

        public ITokensClient TokensClient()
        {
            return _tokensClient;
        }

        public ICustomersClient CustomersClient()
        {
            return _customersClient;
        }

        public IPaymentsClient PaymentsClient()
        {
            return _paymentsClient;
        }

        public IInstrumentsClient InstrumentsClient()
        {
            return _instrumentsClient;
        }

        public IDisputesClient DisputesClient()
        {
            return _disputesClient;
        }

        public IRiskClient RiskClient()
        {
            return _riskClient;
        }
    }
}