using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulDomain
{
//<note> BoneEdgeLegacy
public class SecurityMeasure
{
    /// <summary>
    /// Accrued Intereset
    /// </summary>
    public double AccruedIntereset { get; set; }
    /// <summary>
    /// Acquisition Date
    /// </summary>
    public int AcquisitionDate { get; set; }
    /// <summary>
    /// Acquisition Price
    /// </summary>
    public double AcquisitionPrice { get; set; }
    /// <summary>
    /// As Of Date
    /// </summary>
    public int AsOfDate { get; set; }
    /// <summary>
    /// Annual Income
    /// </summary>
    public double AnnualIncome { get; set; }
    /// <summary>
    /// Average Life
    /// </summary>
    public double AverageLife { get; set; }
    /// <summary>
    /// Book Income
    /// </summary>
    public double BookIncome { get; set; }
    /// <summary>
    /// Book Price
    /// </summary>
    public double BookPrice { get; set; }
    /// <summary>
    /// Book Value
    /// </summary>
    public double BookValue { get; set; }
    /// <summary>
    /// Book Yield
    /// </summary>
    public double BookYield { get; set; }
    /// <summary>
    /// Convexity
    /// </summary>
    public double Convexity { get; set; }
    /// <summary>
    /// Coupon Rate
    /// </summary>
    public double CouponRate { get; set; }
    /// <summary>
    /// Maturity Years
    /// </summary>
    public double MaturityYears { get; set; }
    /// <summary>
    /// CPR Life Time
    /// </summary>
    public double CPRLifeTime { get; set; }
    /// <summary>
    /// Currency
    /// </summary>
    public string Currency { get; set; }
    /// <summary>
    /// Current Yield
    /// </summary>
    public double CurrentYield { get; set; }
    /// <summary>
    /// Security Description
    /// </summary>
    public string SecurityDescription { get; set; }
    /// <summary>
    /// Duration To Worst
    /// </summary>
    public double DurationToWorst { get; set; }
    /// <summary>
    /// DV01
    /// </summary>
    public double DV01 { get; set; }
    /// <summary>
    /// Effective Duration
    /// </summary>
    public double EffectiveDuration { get; set; }
    /// <summary>
    /// Factor
    /// </summary>
    public double Factor { get; set; }
    /// <summary>
    /// Factor Date
    /// </summary>
    public int FactorDate { get; set; }
    /// <summary>
    /// Gain Loss
    /// </summary>
    public double GainLoss { get; set; }
    /// <summary>
    /// Identifier
    /// </summary>
    public string Identifier { get; set; }
    /// <summary>
    /// Issuer Name
    /// </summary>
    public string IssuerName { get; set; }
    /// <summary>
    /// Key Rate Duration 6Mo
    /// </summary>
    public double KeyRateDuration6Mo { get; set; }
    /// <summary>
    /// Key Rate Duration 1Yr
    /// </summary>
    public double KeyRateDuration1Yr { get; set; }
    /// <summary>
    /// Key Rate Duration 2Yr
    /// </summary>
    public double KeyRateDuration2Yr { get; set; }
    /// <summary>
    /// Key Rate Duration 3Yr
    /// </summary>
    public double KeyRateDuration3Yr { get; set; }
    /// <summary>
    /// Key Rate Duration 5Yr
    /// </summary>
    public double KeyRateDuration5Yr { get; set; }
    /// <summary>
    /// Key Rate Duration 7Yr
    /// </summary>
    public double KeyRateDuration7Yr { get; set; }
    /// <summary>
    /// Key Rate Duration 10Yr
    /// </summary>
    public double KeyRateDuration10Yr { get; set; }
    /// <summary>
    /// Key RateDuration 20Yr
    /// </summary>
    public double KeyRateDuration20Yr { get; set; }
    /// <summary>
    /// Key Rate Duration 30Yr
    /// </summary>
    public double KeyRateDuration30Yr { get; set; }
    /// <summary>
    /// Libor Oas
    /// </summary>
    public double LiborOas { get; set; }
    /// <summary>
    /// Market Value
    /// </summary>
    public double MarketValue { get; set; }
    /// <summary>
    /// Market Value WO Accrued
    /// </summary>
    public double MarketValueWoAccrued { get; set; }
    /// <summary>
    /// Modified Duration
    /// </summary>
    public double ModifiedDuration { get; set; }
    /// <summary>
    /// Nominal Spread
    /// </summary>
    public double NominalSpread { get; set; }
    /// <summary>
    /// Option Value
    /// </summary>
    public double OptionValue { get; set; }
    /// <summary>
    /// Original Par
    /// </summary>
    public double OriginalPar { get; set; }
    /// <summary>
    /// Par Value
    /// </summary>
    public double ParValue { get; set; }
    /// <summary>
    /// Price
    /// </summary>
    public double Price { get; set; }
    /// <summary>
    /// PSA Life Time
    /// </summary>
    public double PSALifeTime { get; set; }
    /// <summary>
    /// Quality Moody
    /// </summary>
    public string QualityMoody { get; set; }
    /// <summary>
    /// Quality S&P
    /// </summary>
    public string QualitySP { get; set; }
    /// <summary>
    /// Quality Fitch
    /// </summary>
    public string QualityFitch { get; set; }
    /// <summary>
    /// Spread Duration
    /// </summary>
    public double SpreadDuration { get; set; }
    /// <summary>
    /// Sector1
    /// </summary>
    public string Sector1 { get; set; }
    /// <summary>
    /// Sector2
    /// </summary>
    public string Sector2 { get; set; }
    /// <summary>
    /// State Code
    /// </summary>
    public string StateCode { get; set; }
    /// <summary>
    /// TreasuryOAS
    /// </summary>
    public double TreasuryOAS { get; set; }
    /// <summary>
    /// Vega
    /// </summary>
    public double Vega { get; set; }
    /// <summary>
    /// Yield To Maturity
    /// </summary>
    public double YieldToMaturity { get; set; }
    /// <summary>
    /// Yield To Worst
    /// </summary>
    public double YieldToWorst { get; set; }
    /// <summary>
    /// ZVO
    /// </summary>
    public double ZVO { get; set; }
    /// <summary>
    /// Days To Rest
    /// </summary>
    public double DaysToRest { get; set; }
    /// <summary>
    /// Yield To Put
    /// </summary>
    public double YieldToPut { get; set; }
    /// <summary>
    /// Yield32nd
    /// </summary>
    public double Yield32nd { get; set; }
    /// <summary>
    /// SecurityErrorCode - internal
    /// </summary>
    public SecurityErrorCodes SecurityErrorCode { get; set; }
    /// <summary>
    /// Cusip9
    /// </summary>
    public string Cusip9 { get; set; }
    /// <summary>
    /// ISIN
    /// </summary>
    public string ISIN { get; set; }
    /// <summary>
    /// MaturityDate
    /// </summary>
    public int MaturityDate { get; set; }
    /// <summary>
    /// Accrued Interest Rate
    /// </summary>
    public double AccruedInterestRate { get; set; }
}
}
