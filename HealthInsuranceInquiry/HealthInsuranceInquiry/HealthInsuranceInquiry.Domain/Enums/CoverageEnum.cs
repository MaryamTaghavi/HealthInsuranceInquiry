using System.ComponentModel;

namespace HealthInsuranceInquiry.Domain.Enums;

public enum CoverageEnum
{
    /// <summary>
    /// پوشش جراحی
    /// </summary>
    [Description("پوشش جراحی")]
    Surgical = 1,

    /// <summary>
    /// پوشش دندان پزشکی
    /// </summary>
    [Description("پوشش دندان پزشکی")]
    Dental = 2,

    /// <summary>
    /// پوشش بستری
    /// </summary>
    [Description("پوشش بستری")]
    Inpatient = 3
}