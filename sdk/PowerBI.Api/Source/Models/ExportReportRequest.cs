// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The export to file request
    /// </summary>
    public partial class ExportReportRequest
    {
        /// <summary>
        /// Initializes a new instance of the ExportReportRequest class.
        /// </summary>
        public ExportReportRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportReportRequest class.
        /// </summary>
        /// <param name="format">The requested format for the exported file.
        /// Possible values include: 'PPTX', 'PDF', 'PNG', 'IMAGE', 'XLSX',
        /// 'DOCX', 'CSV', 'XML', 'MHTML', 'ACCESSIBLEPDF'</param>
        /// <param name="powerBIReportConfiguration">The configuration used to
        /// export a Power BI report</param>
        /// <param name="paginatedReportConfiguration">The configuration used
        /// to export a paginated report</param>
        public ExportReportRequest(FileFormat format, PowerBIReportExportConfiguration powerBIReportConfiguration = default(PowerBIReportExportConfiguration), PaginatedReportExportConfiguration paginatedReportConfiguration = default(PaginatedReportExportConfiguration))
        {
            Format = format;
            PowerBIReportConfiguration = powerBIReportConfiguration;
            PaginatedReportConfiguration = paginatedReportConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the requested format for the exported file. Possible
        /// values include: 'PPTX', 'PDF', 'PNG', 'IMAGE', 'XLSX', 'DOCX',
        /// 'CSV', 'XML', 'MHTML', 'ACCESSIBLEPDF'
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public FileFormat Format { get; set; }

        /// <summary>
        /// Gets or sets the configuration used to export a Power BI report
        /// </summary>
        [JsonProperty(PropertyName = "powerBIReportConfiguration")]
        public PowerBIReportExportConfiguration PowerBIReportConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the configuration used to export a paginated report
        /// </summary>
        [JsonProperty(PropertyName = "paginatedReportConfiguration")]
        public PaginatedReportExportConfiguration PaginatedReportConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
