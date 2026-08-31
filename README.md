[![](https://img.shields.io/nuget/v/soenneker.trustedform.certificates.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.trustedform.certificates.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.trustedform.certificates.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.trustedform.certificates.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.trustedform.certificates.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.trustedform.certificates.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.trustedform.certificates.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.trustedform.certificates.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.TrustedForm.Certificates.OpenApiClient
A Kiota-generated client for ActiveProspect's TrustedForm Certificate API v4.

## Installation

```bash
dotnet add package Soenneker.TrustedForm.Certificates.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.TrustedForm.Certificates.OpenApiClient;
using Soenneker.TrustedForm.Certificates.OpenApiClient.Item;
using Soenneker.TrustedForm.Certificates.OpenApiClient.Models;

string basicCredentials = Convert.ToBase64String(
    Encoding.UTF8.GetBytes($"API:{trustedFormApiKey}"));

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://cert.trustedform.com/")
};

httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Basic", basicCredentials);
httpClient.DefaultRequestHeaders.Add("Api-Version", "4.0");

var authentication = new AnonymousAuthenticationProvider();
var adapter = new HttpClientRequestAdapter(authentication, httpClient: httpClient);
var trustedForm = new TrustedFormCertificatesOpenApiClient(adapter);

var body = new WithCert_PostRequestBody
{
    MatchLead = new MatchLeadParameters
    {
        MatchLeadEmailParameters = new MatchLeadEmailParameters
        {
            Email = leadEmail
        }
    },
    Retain = new RetainParameters
    {
        Reference = leadId,
        Vendor = leadVendor
    }
};

WithCert_PostResponse? result =
    await trustedForm[certificateId]
        .PostAsync(body, cancellationToken: cancellationToken);
```

The indexer accepts a certificate ID, not an arbitrary URL. If a lead supplies a certificate URL, require HTTPS and the exact host `cert.trustedform.com` before extracting its path; otherwise an authenticated request can disclose the API credential.

HTTP Basic authentication uses the fixed username `API` and the TrustedForm API key as its password. Every v4 request must also include `Api-Version: 4.0`.

`retain`, `match_lead`, `insights`, and `verify` are separate operations and may be contracted and billed independently. Inspect each operation result—an HTTP success does not by itself mean every requested operation succeeded.

Reuse the client, adapter, and `HttpClient`. Keep API keys, certificate URLs, matching values, insights, and identity data out of logs.
