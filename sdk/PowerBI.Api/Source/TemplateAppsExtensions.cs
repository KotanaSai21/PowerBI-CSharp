// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TemplateApps.
    /// </summary>
    public static partial class TemplateAppsExtensions
    {
            /// <summary>
            /// Generates an installation ticket for the [automated install
            /// flow](/power-bi/developer/template-apps/template-apps-auto-install) of the
            /// specified template app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The caller must use service principal for authentication. For more
            /// information, see [Embed Power BI content with service
            /// principal](/power-bi/developer/embed-service-principal) and [Considerations
            /// and
            /// limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
            ///
            /// ## Limitations
            ///
            /// - The tenant making this API call *must* own the specified template app.
            /// - The template app must either be published to Microsoft AppSource, or,
            /// both the ticket creator and the end-user installing with the ticket must
            /// have explicit access to the app.
            /// - All query parameters in the install ticket *must* be configured.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Create Install Ticket parameters
            /// </param>
            public static InstallTicket CreateInstallTicket(this ITemplateApps operations, CreateInstallTicketRequest requestParameters)
            {
                return operations.CreateInstallTicketAsync(requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates an installation ticket for the [automated install
            /// flow](/power-bi/developer/template-apps/template-apps-auto-install) of the
            /// specified template app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The caller must use service principal for authentication. For more
            /// information, see [Embed Power BI content with service
            /// principal](/power-bi/developer/embed-service-principal) and [Considerations
            /// and
            /// limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
            ///
            /// ## Limitations
            ///
            /// - The tenant making this API call *must* own the specified template app.
            /// - The template app must either be published to Microsoft AppSource, or,
            /// both the ticket creator and the end-user installing with the ticket must
            /// have explicit access to the app.
            /// - All query parameters in the install ticket *must* be configured.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Create Install Ticket parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InstallTicket> CreateInstallTicketAsync(this ITemplateApps operations, CreateInstallTicketRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateInstallTicketWithHttpMessagesAsync(requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}