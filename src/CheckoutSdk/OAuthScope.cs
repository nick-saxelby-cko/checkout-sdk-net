﻿namespace Checkout
{
    public enum OAuthScope
    {
        [OAuthScope("vault")] Vault,
        [OAuthScope("vault:instruments")] VaultInstruments,
        [OAuthScope("vault:tokenization")] VaultTokenization,
        [OAuthScope("vault:customers")] VaultCustomers,
        [OAuthScope("gateway")] Gateway,
        [OAuthScope("gateway:payment")] GatewayPayment,
        [OAuthScope("gateway:payment-details")] GatewayPaymentDetails,
        [OAuthScope("gateway:payment-authorizations")] GatewayPaymentAuthorization,
        [OAuthScope("gateway:payment-voids")] GatewayPaymentVoids,
        [OAuthScope("gateway:payment-captures")] GatewayPaymentCaptures,
        [OAuthScope("gateway:payment-refunds")] GatewayPaymentRefunds,
        [OAuthScope("fx")] Fx,
        [OAuthScope("payouts:bank-details")] PayoutsBankDetails,
        [OAuthScope("sessions:app")] SessionsApp,
        [OAuthScope("sessions:browser")] SessionsBrowser,
        [OAuthScope("disputes")] Disputes,
        [OAuthScope("disputes:view")] DisputesView,
        [OAuthScope("disputes:provide-evidence")] DisputesProvideEvidence,
        [OAuthScope("disputes:accept")] DisputesAccept,
        [OAuthScope("disputes:scheme-files")] DisputesSchemeFiles,
        [OAuthScope("marketplace")] Marketplace,
        [OAuthScope("accounts")] Accounts,
        [OAuthScope("transfers")] Transfers,
        [OAuthScope("transfers:create")] TransfersCreate,
        [OAuthScope("transfers:view")] TransfersView,
        [OAuthScope("flow")] Flow,
        [OAuthScope("flow:workflows")] FlowWorkflows,
        [OAuthScope("flow:events")] FlowEvents,
        [OAuthScope("files")] Files,
        [OAuthScope("files:retrieve")] FilesRetrieve,
        [OAuthScope("files:upload")] FilesUpload,
        [OAuthScope("files:download")] FilesDownload,
        [OAuthScope("balances")] Balances,
        [OAuthScope("balances:view")] BalancesView,
        [OAuthScope("middleware")] Middleware,
        [OAuthScope("middleware:merchants-secret")] MiddlewareMerchantsSecret,
        [OAuthScope("middleware:merchants-public")] MiddlewareMerchantsPublic,
        [OAuthScope("reports")] Reports,
        [OAuthScope("reports:view")] ReportsView,
        [OAuthScope("vault:card-metadata")] VaultCardMetadata
    }
}
